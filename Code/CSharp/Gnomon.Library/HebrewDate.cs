/***********************************************************************************
* File:         HebrewDate.cs                                                      *
* Contents:     Class HebrewDate                                                   *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-10 20:35                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gnomon.Library.Enumerations;
using Gnomon.Library.Tools;

namespace Gnomon.Library
{
	public class HebrewDate : TriadicDate
	{
		#region region Constants
		private const int NISAN	= 1;
		private const int TISHRI = 7;
		private static readonly int[] CRITICAL_MONTHS = {2, 4, 6, 10, 13};
		private const double AVERAGE_YEAR_LENGTH = (double)35975351/98496;

		#endregion

		#region Construction
		public HebrewDate(int year, int month, double day): base(year, month, day)	{}
		public HebrewDate(HebrewDate date): base(date.Year, date.Month, date.Day)	{}
		public HebrewDate(): base()	{}
		#endregion

		#region Overridden
		public override double ToMoment()
		{
			double t = HebrewNewYear(this.Year) + this.Day - 1;

			if (this.Month < TISHRI)
			{
				int lastMonthInYear = LastMonthOfHebrewYear(this.Year);

				for (int m = TISHRI; m <= lastMonthInYear; m++)
				{
					int lastDayOfMonth = LastDayOfHebrewMonth(this.Year, m);
					t += lastDayOfMonth;
				}

				for (int m = NISAN; m < this.Month; m++)
				{
					int lastDayOfMonth = LastDayOfHebrewMonth(this.Year, m);
					t += lastDayOfMonth;
				}
			}
			else
			{
				for (int m = TISHRI; m < this.Month; m++)
				{
					int lastDayOfMonth = LastDayOfHebrewMonth(this.Year, m);
					t += lastDayOfMonth;
				}
			}

			this._rataDie = t;

			return this._rataDie;
		}

		public override void FromMoment(double t)
		{
			this._rataDie = t;

			double approx = 1 + Math.Floor((t - ChronoTools.HEBREW_EPOCH) / AVERAGE_YEAR_LENGTH);

			int year = 0;
			for (year = (int)(approx - 1); HebrewNewYear(year) <= t; year++)
			{
			}
			
			year--;

			int start = t < new HebrewDate(year, 1, 1).ToMoment() ? TISHRI : NISAN;

			int month = 0;

			for (month = start; !(t <= new HebrewDate(year, month, LastDayOfHebrewMonth(year, month)).ToMoment()); month++)
			{
			}

			int day = (int)(1 + t - new HebrewDate(year, month, 1).ToMoment());

			this.Year	= year;
			this.Month	= month;
			this.Day	= day;
		}
		#endregion

		/// <summary>
		/// Supported Formats:
		///		"DD MM YYYY":	"05 12 5756"
		///		"DD MMMM YYYY":	"05 Adar 5756"
		/// </summary>
		/// <param name="format"></param>
		/// <returns></returns>
		public override string ToString(string format)
		{
			string monthName = MonthNames.Names[CalendarSystem.Hebrew][this.Month - 1];

			switch (format.ToUpper())
			{
				case "DD MM YYYY":
					return $"{(int)this.Day:00} {this.Month} {this.Year}";

				case "DD MMMM YYYY":
					return $"{(int)this.Day:00} {monthName} {this.Year}";

				default:
					return null;
			}
		}

		#region Private Auxiliary
		/// <summary>
		/// RDM (7.10)
		/// </summary>
		/// <param name="year"></param>
		/// <returns></returns>
		private static double HebrewNewYear(int year)
		{
			return ChronoTools.HEBREW_EPOCH + HebrewCalendarElapsedDays(year) + HebrewNewYearDelay(year);
		}

		/// <summary>
		/// RDM (7.9)
		/// </summary>
		/// <param name="year"></param>
		/// <returns></returns>
		private static int HebrewNewYearDelay(int year)
		{
			int ny0 = (int)HebrewCalendarElapsedDays(year - 1);
			int ny1 = (int)HebrewCalendarElapsedDays(year);
			int ny2 = (int)HebrewCalendarElapsedDays(year + 1);

			if (ny2 - ny1 == 356)
			{
				return 2;
			}
			else if (ny1 - ny0 == 382)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}

		/// <summary>
		/// RDM (7.8)
		/// </summary>
		/// <param name="year"></param>
		/// <returns></returns>
		private static double HebrewCalendarElapsedDays(int year)
		{
			double monthsElapsed = Math.Floor((235 * year - 234) / 19d);
			double partsElapsed = 12084 + 13753 * monthsElapsed;
			double day	= 29 * monthsElapsed + Math.Floor(partsElapsed / 25920d);

			if ((int)ChronoTools.Fmod(3 * (day + 1), 7) < 3)
			{
				return day + 1;
			}
			else
			{
				return day;
			}
		}

		/// <summary>
		/// RDM (7.4).
		/// </summary>
		/// <param name="year"></param>
		/// <returns></returns>
		private static int LastMonthOfHebrewYear(int year)
		{
			return ChronoTools.IsHebrewLeapYear(year) ? 13 : 12;
		}

		/// <summary>
		/// RDM (7.11)
		/// </summary>
		/// <param name="year"></param>
		/// <param name="month"></param>
		/// <returns></returns>
		private static int LastDayOfHebrewMonth(int year, int month)
		{
			if 
				(
					CRITICAL_MONTHS.Contains(month) ||
					(month == 12 && !ChronoTools.IsHebrewLeapYear(year))	||
					(month == 8 && !IsLongMarheshvan(year))	||
					(month == 9 && IsShortKislev(year))
				)
			{
				return 29;
			}
			else
			{
				return 30;
			}
		}

		/// <summary>
		/// RDM (7.12)
		/// </summary>
		/// <param name="year"></param>
		/// <returns></returns>
		private static bool IsLongMarheshvan(int year)
		{
			int daysInHebrewYear = DaysInHebrewYear(year);
			return daysInHebrewYear == 355 || daysInHebrewYear == 385;
		}

		/// <summary>
		/// RDM (7.13)
		/// </summary>
		/// <param name="year"></param>
		/// <returns></returns>
		private static bool IsShortKislev(int year)
		{
			int daysInHebrewYear = DaysInHebrewYear(year);
			return daysInHebrewYear == 353 || daysInHebrewYear == 383;
		}

		/// <summary>
		/// RDM (7.14)
		/// </summary>
		/// <param name="year"></param>
		/// <returns></returns>
		private static int DaysInHebrewYear(int year)
		{
			return (int)(HebrewNewYear(year + 1) - HebrewNewYear(year));
		}
		#endregion

	}
}
