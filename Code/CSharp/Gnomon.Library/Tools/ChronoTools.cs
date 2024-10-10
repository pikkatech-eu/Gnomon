/***********************************************************************************
* File:         ChronoTools.cs                                                     *
* Contents:     Class ChronoTools                                                  *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-10-20 1436                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Reflection;

namespace Gnomon.Library.Tools
{
	public static class ChronoTools
	{
		#region Constants
		public const double DEGREE						= 001745329251994329576923690768489;
		public const double MEAN_TROPICAL_YEAR			= 365.242189;
		public const int	DEFAULT_MAX_ITERATIONS		= 100;
		public const double	DEFAULT_BRACKETING_FACTOR	= 0.6180339887498948482045868343656;

		public const double JULIAN_DAY_EPOCH			= -1721424.5;
		public const double MJD_EPOCH					= 678576;
		public const double JULIAN_EPOCH				= -1;
		public const double HEBREW_EPOCH				= -1373427;
		public const double ISLAMIC_EPOCH				= 227015;
		public const double BAHAI_EPOCH					= 673222.0;	// R.D. for March 21, 1844
		public const double PERSIAN_EPOCH				= 226896;
		#endregion

		#region Mathematical Operations
		/// <summary>
		/// RDU (1.17): The	remainder, or modulus, of float numbers.
		/// </summary>
		/// <param name="x">The first operand</param>
		/// <param name="y">The second operand</param>
		/// <returns>The result of the operation.</returns>
		/// <example>fmod(9, 4) = 5; fmod(-9, 5) = 1; fmod(9, -5) = -1; fmod(-9, -5) = -4.</example>
		public static double Fmod(double x, double y)
		{
			return x - y * Math.Floor(x / y);
		}

		/// <summary>
		/// The Fmod function for integer arguments.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public static double Fmod(int x, int y)
		{
			return Fmod((double)x, (double)y);
		}

		/// <summary>
		/// Calculates the whole part of a ratio.
		/// </summary>
		/// <param name="x">The dividend</param>
		/// <param name="y">The divisor</param>
		/// <returns>The result</returns>
		public static double Quotient(double x, double y)
		{
			return Math.Floor(x / y);
		}

		/// <summary>
		/// Calculates the whole part of a ratio as an integer number.
		/// </summary>
		/// <param name="x">The dividend</param>
		/// <param name="y">The divisor</param>
		/// <returns>The result</returns>
		public static int IntegerQuotient(double x, double y)
		{
			return (int)Quotient(x, y);
		}

		/// <summary>
		/// RDU (1.29): Adjusted Remainder, a "function like mod with its values adjusted in such a	way 
		/// that the modulus of	a multiple of the divisor is the divisor itself rather than 0".
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public static double Amod(double x, double y)
		{
			return x + Fmod(x, -y);
		}

		/// <summary>
		/// Sine of an argument given in degrees. (Neither math nor numpy seem to have these simple functions).
		/// </summary>
		/// <param name="x">The argument in degrees</param>
		/// <returns>sin(x°)</returns>
		public static double Sind(double x)
		{
			return Math.Sin(DEGREE * x);
		}

		/// <summary>
		/// Cosine of an argument given in degrees. (Neither math nor numpy seem to have these simple functions).
		/// </summary>
		/// <param name="x">The argument in degrees</param>
		/// <returns>cos(x°)</returns>
		public static double Cosd(double x)
		{
			return Math.Cos(DEGREE * x);
		}

		/// <summary>
		/// Tangent of an argument given in degrees. (Neither math nor numpy seem to have these simple functions).
		/// </summary>
		/// <param name="x">The argument in degrees</param>
		/// <returns>tan(x°)</returns>
		public static double Tand(double x)
		{
			return Math.Tan(DEGREE * x);
		}
		#endregion

		#region Root finding related
		public static double Bisection(Func<double, double> f, double left, double right, double precision, int maxIterations = DEFAULT_MAX_ITERATIONS)
		{
			double fLeft = f(left);
			double fRight = f(right);

			if (Math.Sign(fLeft) == Math.Sign(fRight))
			{
				throw new InvalidOperationException("Wrong initial interval: the values of the function are of the same sign");
			}

			double middle = 0.5 * (left + right);

			int iterations = 0;
			double accuracy = Math.Abs(f(middle));

			while (accuracy > precision && iterations < maxIterations)
			{
				double fMiddle = f(middle);

				if (Math.Sign(fMiddle) == Math.Sign(fLeft))
				{
					left = middle;
				}
				else
				{
					right = middle;
				}

				middle = 0.5 * (left + right);
				accuracy = Math.Abs(f(middle));
				iterations++;
			}

			return middle;
		}

		/// <summary>
		/// Tries to bracket an interval with respect to a function, i.e. if the initial interval is not a bracket itself, 
		/// it successively increases its boundaries before it reaches a bracketing interval.
		/// </summary>
		/// <param name="f">The function f(x) that should be bracketed</param>
		/// <param name="left">The initial left boundary of the interval to start bracketing from</param>
		/// <param name="right">The initial right boundary of the interval to start bracketing from</param>
		/// <param name="factor">The factor to expand the intervals' boundaries. Default = 0.618...</param>
		/// <param name="maxIterations"></param>
		/// <returns>A bracketing interval, if successfull.</returns>
		/// <exception cref="OverflowException">Raised if no bracket was found after maxIterations.</exception>
		public static (double Left, double Right) Bracket
															(
																Func<double, double> f, 
																double left, 
																double right, 
																double factor = DEFAULT_BRACKETING_FACTOR, 
																int maxIterations = DEFAULT_MAX_ITERATIONS
															)
		{
			left = Math.Min(left, right);
			right = Math.Max(left, right);

			double fLeft = f(left);
			double fRight = f(right);

			if (Math.Sign(fLeft) != Math.Sign(fRight))
			{
				return (left, right);
			}

			int iterations = 0;

			while (iterations < maxIterations)
			{
				double width = right - left;
				left -= factor * width;

				if (Math.Sign(fLeft) != Math.Sign(fRight))
				{
					return (left, right);
				}

				right += factor * width;

				if (Math.Sign(fLeft) != Math.Sign(fRight))
				{
					return (left, right);
				}

				iterations++;
			}

			throw new OverflowException("Maximum iterations reached. No bracket found");
		}
		#endregion

		#region Lap Year related
		/// <summary>
		/// Determine whether a year is a leap year.
		/// Source: https://stackoverflow.com/questions/11621740/how-to-determine-whether-a-year-is-a-leap-year
		/// </summary>
		/// <param name="year">Gregorian year.</param>
		/// <returns>True, if the year is a leap year.</returns>
		public static bool IsGregorianLeapYear(int year)
		{
			return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
		}

		/// <summary>
		/// mod(jYear, 4) == (jYear > 0 ? 0 : 3);
		/// In RDM (3.3) there is mod(year, 4), which should be fmod(year, 4).
		/// Otherwise there is an erroe with the negative Julian leap year -169.
		/// </summary>
		/// <param name="year">Julian year.</param>
		/// <returns>True, if the Julian year is a leap one.</returns>
		public static bool IsJulianLeapYear(int year)
		{
			if (year > 0)
			{
				return (int)Fmod(year, 4) == 0;
			}
			else
			{
				return (int)Fmod(year, 4) == 3;
			}
		}

		/// <summary>
		/// RDM (7.3)
		/// </summary>
		/// <param name="year"></param>
		/// <returns></returns>
		public static bool IsHebrewLeapYear(int year)
		{
			return (int)Fmod((7 * year + 1), 19) < 7;
		}
		#endregion

		#region Gregorian Date-related
		/// <summary>
		///	RDM (2.18)
		/// </summary>
		/// <param name="instant"></param>
		public static int GregorianYearFromInstant(double instant)
		{
			double d0	= instant - 1;
			double n400	= Math.Floor(d0 / 146097);
			double d1	= Fmod(d0, 146097);
			double n100 = Math.Floor(d1 / 36524);
			double d2	= Fmod(d1, 36524);
			double n4	= Math.Floor(d2 / 1461);
			double d3	= Fmod(d2, 1461);
			double n1	= Math.Floor(d3 / 365);

			int year	= (int)(400.0 * n400 + 100.0 * n100 + 4.0 * n4 + n1);

			if ((int)n100 != 4 && (int)n1 != 4)
			{
				year += 1;
			}

			return year;
		}

		/// <summary>
		/// Day of week from RD moment.
		/// </summary>
		/// <param name="t">The RD moment value</param>
		/// <returns>The week's day number (0 == Sunday; 1 == Monday,..., 6 == Saturday)</returns>
		public static double DayOfWeekFromMoment(double t)
		{
			return Fmod(t, 7);
		}

		/// <summary>
		/// RDM (1.41): The k-th day of the week that falls in the 7-day period ending on the moment's date.
		/// </summary>
		/// <param name="t">The RD moment value.</param>
		/// <param name="k">The number of the week's day.</param>
		/// <returns>The number of the day fulfilling the definition above.</returns>
		public static double KDayOnOrBefore(double t, int k)
		{
			return t - DayOfWeekFromMoment(t - k);
		}

		/// <summary>
		/// RDM (1.48): The k-th day of the week that falls in the 7-day period ending exclusively on the moment's date.
		/// </summary>
		/// <param name="t">The RD moment value.</param>
		/// <param name="k">The number of the week's day.</param>
		/// <returns>The number of the day fulfilling the definition above.</returns>
		public static double KDayBefore(double t, int k)
		{
			return KDayOnOrBefore(t - 1, k);
		}

		/// <summary>
		/// RDM (1.49): The k-th day of the week that falls in the 7-day period beginning exclusively with the moment's date.
		/// </summary>
		/// <param name="t">The RD moment value.</param>
		/// <param name="k">The number of the week's day.</param>
		/// <returns>The number of the day fulfilling the definition above.</returns>
		public static double KDayAfter(double t, int k)
		{
			return KDayOnOrBefore(t + 7, k);
		}

		/// <summary>
		/// RDM (2.28): The n-th repetition of the weekday number k after/before(+/-) a given Gregorian date.
		/// </summary>
		/// <param name="n">The number of the repetition.</param>
		/// <param name="k">The number of the week's day.</param>
		/// <param name="t">The moment of the Gregorian date.</param>
		/// <returns>The number of the date fulfilling the definition above.</returns>
		public static double NthKDay(int n, int k, double t)
		{
			if (n > 0)
			{
				return 7 * n + KDayBefore(t, k);
			}
			else
			{
				return 7 * n + KDayAfter(t, k);
			}
		}
		#endregion
	}
}
