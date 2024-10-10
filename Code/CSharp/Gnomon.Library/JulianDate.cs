/***********************************************************************************
* File:         JulianDate.cs                                                      *
* Contents:     Class JulianDate                                                   *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-10 20:16                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using Gnomon.Library.Tools;

namespace Gnomon.Library
{
	public class JulianDate : TriadicDate
	{
		#region Construction
		public JulianDate(int year, int month, double day): base(year, month, day)	{}

		public JulianDate(JulianDate date): base(date.Year, date.Month, date.Day)	{}
		public JulianDate(): base()	{}
		#endregion

		public override double ToMoment()
		{
			int y = this.Year < 0 ? this.Year + 1 : this.Year;

			double result = ChronoTools.JULIAN_EPOCH - 1 + 365 * (y - 1) + Math.Floor((y - 1) / 4d) + Math.Floor((367 * this.Month - 362) / 12d);

			if (this.Month > 2)
			{
				if (ChronoTools.IsJulianLeapYear(this.Year))
				{
					result -= 1;
				}
				else
				{
					result -= 2;
				}
			}

			result += this.Day;

			this._rataDie = result;

			return this._rataDie;
		}

		public override void FromMoment(double t)
		{
			this._rataDie = t;

			double approx		= Math.Floor((4 * (t - ChronoTools.JULIAN_EPOCH) + 1464) / 1461d);
			int year			= approx <= 0 ? (int)(approx - 1) : (int)approx;

			double priorDays	= t - new JulianDate(year, 1, 1).ToMoment();

			double correction	= 0;

			if (t >= new JulianDate(year, 3, 1).ToMoment())
			{
				if (ChronoTools.IsJulianLeapYear(year))
				{
					correction = 1;
				}
				else
				{
					correction = 2;
				}
			}

			int month			= (int)Math.Floor((12 * (priorDays + correction) + 373) / 367d);

			int day				= (int)(t - new JulianDate(year, month, 1).ToMoment() + 1);

			this.Year			= year;
			this.Month			= month;
			this.Day			= day;
		}


		public override string ToString(string format)
		{
			if (!this.IsValid())
			{
				return null;
			}

			GregorianDate fakeGregorian = new GregorianDate();
			fakeGregorian.Year			= this.Year;
			fakeGregorian.Month			= this.Month;
			fakeGregorian.Day			= this.Day;

			return GregorianDate.GetDateString(fakeGregorian, format);
		}

		public override string ToString()
		{
			return this.ToString("yyyy-mm-dd");
		}
	}
}
