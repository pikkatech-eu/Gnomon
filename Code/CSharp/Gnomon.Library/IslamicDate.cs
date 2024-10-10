/***********************************************************************************
* File:         IslamicDate.cs                                                     *
* Contents:     Class IslamicDate                                                  *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-10 20:28                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using Gnomon.Library.Tools;

namespace Gnomon.Library
{
	public class IslamicDate : TriadicDate
	{
		#region Construction
		public IslamicDate(int year, int month, double day): base(year, month, day)	{}
		public IslamicDate(IslamicDate date): base(date.Year, date.Month, date.Day)	{}
		public IslamicDate(): base()	{}
		#endregion

		public override double ToMoment()
		{
			this._rataDie = this.Day + 29 * (this.Month - 1) + Math.Floor((6 * this.Month - 1) / 11d) + (this.Year - 1) * 354 + 
							Math.Floor((3 + 11 * this.Year) / 30d) + ChronoTools.ISLAMIC_EPOCH - 1;

			return this._rataDie;
		}

		public override void FromMoment(double t)
		{
			this._rataDie = t;

			int year = (int)Math.Floor((30 * (t - ChronoTools.ISLAMIC_EPOCH) + 10646) / 10631d);

			double priorDays = t - new IslamicDate(year, 1, 1).ToMoment();

			int month = (int)Math.Floor((11 * priorDays + 330) / 325d);

			int day = (int)(t - new IslamicDate(year, month, 1).ToMoment() + 1);
				
			this.Year	= year;
			this.Month	= month;
			this.Day	= day;
		}

		/// <summary>
		/// Supported Formats:
		///		"dd mm yyyy":	"05 10 1416"
		///		"dd mmmm yyyy":	"05 Shawwal 1416"
		/// </summary>
		/// <param name="format"></param>
		/// <returns></returns>
		public override string ToString(string format)
		{
			switch (format.ToUpper())
			{
				case "dd mm yyyy":
					return $"{(int)this.Day:00} {MonthNames.Names[Enumerations.CalendarSystem.Islamic][this.Month - 1]} {this.Year}";

				case "dd mmmm yyyy":
					return $"{(int)this.Day:00} {MonthNames.Names[Enumerations.CalendarSystem.Islamic][this.Month - 1]} {this.Year}";

				default:
					return null;
			}
		}

		public override bool IsValid()
		{
			return base.IsValid() && this.Month > 0 && this.Day > 0;
		}

	}
}
