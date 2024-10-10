/***********************************************************************************
* File:         ChronoTools.cs                                                     *
* Contents:     Class ChronoTools                                                  *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-10-20 1436                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;

namespace Gnomon.Library.Tools
{
	public static class ChronoTools
	{
		#region Constants
		public const double JULIAN_DAY_EPOCH	= -1721424.5;
		public const double MJD_EPOCH			= 678576;
		public const double JULIAN_EPOCH		= -1;
		public const double HEBREW_EPOCH		= -1373427;
		public const double ISLAMIC_EPOCH		= 227015;
		public const double BAHAI_EPOCH			= 673222.0;	// R.D. for March 21, 1844
		#endregion

		#region Mathematics
		/// <summary>
		/// RDU (1.17): The The	remainder, or modulus, of float numbers.
		/// </summary>
		/// <param name="x">The first operand</param>
		/// <param name="y">The second operand</param>
		/// <returns>The result of the operation.</returns>
		/// <example>fmod(9, 4) = 5; fmod(-9, 5) = 1; fmod(9, -5) = -1; fmod(-9, -5) = -4.</example>
		public static double Fmod(double x, double y)
		{
			return x - y * Math.Floor(x / y);
		}
		#endregion

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
	}
}
