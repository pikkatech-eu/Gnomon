/***********************************************************************************
* File:         WesternBahaiDate.cs                                                *
* Contents:     Class WesternBahaiDate                                             *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-10 20:43                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gnomon.Library.Tools;

namespace Gnomon.Library
{
	public class WesternBahaiDate : TriadicDate
	{
		#region Construction
		public WesternBahaiDate(int year, int month, double day): base(year, month, day)	{}
		public WesternBahaiDate(WesternBahaiDate date): base(date.Year, date.Month, date.Day)	{}
		public WesternBahaiDate(): base()	{}
		#endregion

		public override double ToMoment()
		{
			// count cycle and major:
			int m_nCycle = this.Year / 19  + 1;
			int m_nMajor = this.Year / 361 + 1;

			GregorianDate gregorianBahaiEpoch = new GregorianDate();
			gregorianBahaiEpoch.FromMoment(ChronoTools.BAHAI_EPOCH);

			int gregorianYear = this.Year - 1 + gregorianBahaiEpoch.Year;

			this._rataDie = new GregorianDate(gregorianYear, 3, 20).ToMoment();

			if (this.Month == 0)
			{
				this._rataDie += 342.0;
			}
			else if (this.Month == 19)
			{
				if (ChronoTools.IsGregorianLeapYear(gregorianYear + 1))
				{
					this._rataDie += 347.0;
				}
				else
				{
					this._rataDie += 346.0;
				}
			}
			else
			{
				this._rataDie += 19 * (this.Month - 1);
			}

			this._rataDie += this.Day;

			return this._rataDie;
		}

		public override void FromMoment(double t)
		{
			this._rataDie = t;

			GregorianDate gregorianDate = new GregorianDate();
			gregorianDate.FromMoment(t);

			int gregorianYear =gregorianDate.Year;

			GregorianDate gregorianBahaiEpoch = new GregorianDate();
			gregorianBahaiEpoch.FromMoment(ChronoTools.BAHAI_EPOCH);

			int startYear = gregorianBahaiEpoch.Year;

			int years = gregorianYear - startYear;

			if (this._rataDie <= new GregorianDate(gregorianYear, 3, 20).ToMoment())
			{
				years--;
			}

			this.Year = years + 1;

			double days = this._rataDie - new WesternBahaiDate(this.Year, 1, 1).ToMoment();

			if (this._rataDie >= new WesternBahaiDate(this.Year, 19, 1).ToMoment())
			{
				this.Month = 19;
			}
			else if (this._rataDie >= new WesternBahaiDate(this.Year, 0, 1).ToMoment())
			{
				this.Month = 0;
			}
			else
			{
				this.Month = (int)Math.Floor(days / 19) + 1;
			}

			this.Day = (int)(this._rataDie + 1 - new WesternBahaiDate(this.Year, this.Month, 1).ToMoment());
		}

		/// <summary>
		/// Supported Formats:
		///		"dd mm yyyy":	"05 06 125"
		///		"dd mmmm yyyy":	"05 Rahmat 125"
		/// </summary>
		/// <param name="format"></param>
		/// <returns></returns>
		public override string ToString(string format)
		{
			switch (format.ToUpper())
			{
				case "dd mm yyyy":
					return $"{(int)this.Day:00} {MonthNames.Names[Enumerations.CalendarSystem.WesternBahai][this.Month - 1]} {this.Year}";

				case "Dd mmmm yyyy":
					return $"{(int)this.Day:00} {MonthNames.Names[Enumerations.CalendarSystem.WesternBahai][this.Month - 1]} {this.Year}";

				default:
					return null;
			}
		}

	}
}
