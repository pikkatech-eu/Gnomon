/***********************************************************************************
* File:         GregorianDate.cs                                                   *
* Contents:     Class GregorianDate                                                *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-10-20 1459                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Linq;
using System.Text.RegularExpressions;
using Gnomon.Library.Enumerations;
using Gnomon.Library.Tools;

namespace Gnomon.Library
{
	public class GregorianDate: TriadicDate
	{
		#region String constants
		// public static readonly string[] MONTHS_GEDCOM = {"JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"};

		//public static readonly string[] MONTHS = {"January",  "February",  "March",  "April",  "May",  "June",  
		//										  "July",  "August",  "September",  "October",  "November",  "December"};

		//internal static readonly string GREGORIAN_GEDCOM_CALENDAR_NAME	= "GREGORIAN";
		//internal static readonly string JULIAN_GEDCOM_CALENDAR_NAME		= "JULIAN";
		#endregion

		#region Regex Constants
		private static readonly Regex _rxIso			= new Regex(@"(?'year'\d{1,4})\s*-\s*(?'month'\d{1,2})\s*-\s*(?'day'\d{1,2})");		// "1996-02-25"
		private static readonly Regex _rx_dd_mm_yyyy	= new Regex(@"(?'day'\d{1,2})\s*\.\s*(?'month'\d{1,2})\s*\.\s*(?'year'\d{1,4})");	// "25.02.1996"
		private static readonly Regex _rx_dd_MM_yyyy	= new Regex(@"(?'day'\d{1,2})\s*(?'month'\w+)\s*(?'year'\d{1,4})");					// "25 February 1996"
		private static readonly Regex _rxUS				= new Regex(@"(?'month'\d{1,2})\s*/\s*(?'day'\d{1,2})\s*/\s*(?'year'\d{1,4})");		// "02/25/1996"

		private static Regex[] _rxsDate = new Regex[]
		{
			_rxIso,
			_rx_dd_mm_yyyy,
			_rx_dd_MM_yyyy,
			_rxUS
		};
		#endregion

		#region Construction
		public GregorianDate(int year, int month, double day): base(year, month, day)	{}

		public GregorianDate(GregorianDate date): base(date.Year, date.Month, date.Day)	{}
		public GregorianDate(): base()	{}
		public GregorianDate(DateTime dateTime): this(dateTime.Year, dateTime.Month, dateTime.Day)	
		{
			this.Day += (double)dateTime.Hour / 24 + (double)dateTime.Minute / (24 * 60) + (double)dateTime.Second / (24 * 3600);
		}

		public static implicit operator GregorianDate(DateTime dateTime) => new GregorianDate(dateTime);

		public static implicit operator DateTime(GregorianDate value)
		{
			double dHours		= 24 * (value.Day - (int)value.Day);
			int hours			= (int)dHours;
			double dMinutes		= 60 * (dHours - hours);
			int minutes			= (int)dMinutes;
			double dSeconds		= 60 * (dMinutes - minutes);
			int seconds			= (int)dSeconds;
			double milliseconds	= 1000 * (dSeconds - seconds);

			DateTime result		= new DateTime(value.Year, value.Month, (int)value.Day, hours, minutes, seconds);

			result.AddMilliseconds(milliseconds);

			return result;
		}
		#endregion

		#region Overridden
		/// <summary>
		///		Calculates the value of RataDie (Reingold & Dershowitz).
		/// </summary>
		/// <returns>The value of RataDie for GregorianGeneoDate, days.</returns>
		public override double ToMoment()
		{
			this._rataDie = 365.0 * (this.Year - 1) + 
					Math.Floor((this.Year - 1) / 4d) -
					Math.Floor((this.Year - 1) / 100d) + 
					Math.Floor((this.Year - 1) / 400d) + 
					Math.Floor((367 * this.Month - 362) / 12d);

			if (this.Month > 2)
			{
				if (ChronoTools.IsGregorianLeapYear(this.Year))
				{
					this._rataDie -= 1;
				}
				else
				{
					this._rataDie -= 2;
				}
			}

			this._rataDie += this.Day;

			return this._rataDie;
		}

		/// <summary>
		///		Creates an instance of GregorianGeneoDate from a RataDie value.
		/// </summary>
		/// <param name="t">The value of RataDie.</param>
		public override void FromMoment(double t)
		{
			this._rataDie = t;

			int year = ChronoTools.GregorianYearFromInstant(this._rataDie);
			GregorianDate newYear	= new GregorianDate(year, 1, 1);

			double daysPrior		= this._rataDie - newYear.ToMoment();
			double correction		= 0;

			GregorianDate march1 = new GregorianDate(year, 3, 1);

			if (t >= march1.ToMoment())
			{
				if (ChronoTools.IsGregorianLeapYear(year))
				{
					correction = 1;
				}
				else
				{
					correction = 2;
				}
			}

			double d	= (12.0 * (daysPrior + correction) + 373) / 367;

			int month	= (int)Math.Floor(d);

			d			= this._rataDie - new GregorianDate(year, month, 1).ToMoment();

			int day		= (int)d + 1;

			this.Year	= year;
			this.Month	= month;
			this.Day	= day;
		}
		#endregion

		#region String Representations
		/// <summary>
		/// Supported formats:
		///		"yyyy-mm-dd":	"1996-02-25"
		///		"dd.mm.yyyy":	"25.02.1996"
		///		"dd MM yyyy":	"25 February 1996"
		///		"mm/dd/yyyy":	"02/25/1996"
		///		"JD":			"JD:2450138.5"
		///		"RD":			"RD:728714"
		/// </summary>
		/// <param name="format">The format to use.</param>
		/// <returns>Date as formatted string.</returns>
		public override string ToString(string format)
		{
			if (!this.IsValid())
			{
				return null;
			}

			if (format.StartsWith("RD"))
			{
				// Rata Die
				return $"RD {this.ToMoment()}";
			}
			else if (format.StartsWith("JD"))
			{
				// Julian days
				return $"JD {this.JulianDays}";
			}
			else
			{
				string year = format.Contains("yyyy") ? this.Year.ToString() : "";
				
				string day = format.Contains("dd") ? this.Day.ToString() : "";

				string month = format.Contains("mm") ? this.Month.ToString() : "";

				month = format.Contains("MM") ? MonthNames.Names[CalendarSystem.Gregorian][this.Month] : "";

				string result = format.Replace("yyyy", year).Replace("mm", month).Replace("MM", month).Replace("dd", day);

				return result;
			}
		}

		///// <summary>
		///// Common for Gregorian and Julian dates.
		///// </summary>
		///// <param name="date"></param>
		///// <param name="format"></param>
		///// <returns></returns>
		//internal static string GetDateString(TriadicDate date, string format, string gedcomCalendarName)
		//{
		//	switch (format.ToUpper())
		//	{
		//		case "DD.MM.YYYY":
		//			return $"{(int)date.Day:00}.{date.Month}.{date.Year}";

		//		case "DD.MMMM.YYYY":
		//			return $"{(int)date.Day:00}.{GregorianDate.MONTHS[date.Month - 1]}.{date.Year}";

		//		case "MM/DD/YYYY":
		//			return $"{date.Month}/{(int)date.Day:00}/{date.Year}";

		//		case "GED":
		//			return $"{(int)date.Day:00} {GregorianDate.MONTHS_GEDCOM[date.Month - 1]} {date.Year}";

		//		case "GEDF":
		//			return $"{gedcomCalendarName} {(int)date.Day:00} {GregorianDate.MONTHS_GEDCOM[date.Month - 1]} {date.Year}";

		//		case "RD":
		//			return $"RD:{date.RataDie}";

		//		case "JD":
		//			return $"ID:{date.JulianDays}";

		//		default:
		//			return $"{date.Year}-{date.Month:00}-{(int)date.Day:00}";
		//	}
		//}

		public override string ToString()
		{
			return this.ToString("dddd-mm-dd");
		}

		public static GregorianDate Parse(string source)
		{
			if (source.ToUpper().StartsWith("RD"))
			{
				try
				{
					double t = Double.Parse(source.Substring(2));
					GregorianDate gregorian = new GregorianDate();
					gregorian.FromMoment(t);

					return gregorian;
				}
				catch (ArgumentException)
				{
					throw;
				}
			}

			// Try to parse as JD
			if (source.ToUpper().StartsWith("JD"))
			{
				try
				{
					double t = Double.Parse(source.Substring(2));
					t += ChronoTools.JULIAN_DAY_EPOCH;

					GregorianDate gregorian = new GregorianDate();
					gregorian.FromMoment(t);

					return gregorian;
				}
				catch (ArgumentException)
				{
					throw;
				}
			}

			foreach (Regex regex in _rxsDate)
			{
				if (!regex.IsMatch(source))
				{
					continue;
				}

				string yearString = regex.Match(source).Groups["year"].Value;
				string monthString = regex.Match(source).Groups["month"].Value;
				string dayString = regex.Match(source).Groups["day"].Value;

				int year = Int32.Parse(yearString);
				int day = Int32.Parse(dayString);
				int month = 0;

				if (regex == _rx_dd_MM_yyyy)
				{
					string[] months = MonthNames.Names[CalendarSystem.Gregorian];
					var ii = months.Select((m, index) => new { Item = m, Index = index }).Where(pair => (pair.Item.ToUpper() == monthString.ToUpper())).Select(result => result.Index);					
					if (ii.Count() > 0)
					{
						month = ii.First() + 1;
					}
				}
				else
				{
					month = Int32.Parse(monthString);
				}

				return new GregorianDate(year, month, day);
			}

			return null;
		}

		public static bool TryParse(string source, out GregorianDate date)
		{
			try
			{
				date = Parse(source);
				return true;
			}
			catch (Exception)
			{
				date = null;
				return false;
			}
		}
		#endregion
	}
}
