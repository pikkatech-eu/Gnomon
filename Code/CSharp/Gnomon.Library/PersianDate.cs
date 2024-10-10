/***********************************************************************************
* File:         PersianDate.cs                                                     *
* Contents:     Class PersianDate                                                  *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-10 20:52                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gnomon.Library.Tools;

namespace Gnomon.Library
{
	/// <summary>
	/// Implements arithmetic Persian calendar.
	/// TODO: implement all the astronomical routines from 
	/// F:\Archive\Backup 2024-05-21\pikkatech.eu\Projects\Eski TapuTapu\Diebus\code\Python\times.py and 
	/// F:\Archive\Backup 2024-05-21\pikkatech.eu\Projects\Eski TapuTapu\Diebus\code\Python\tools.py .
	/// </summary>
	public class PersianDate : TriadicDate
	{
		#region Construction
		public PersianDate(int year, int month, double day): base(year, month, day)	{}
		public PersianDate(PersianDate date): base(date.Year, date.Month, date.Day)	{}
		public PersianDate(): base()	{}
		#endregion

		public override double ToMoment()
		{
			int y = this.Year - 473;

			if (this.Year > 0)
			{
				y -= 1;
			}

			this.Year = (int)ChronoTools.Fmod(y, 2820) + 474;

			double result = ChronoTools.PERSIAN_EPOCH - 1 + 1029983 * Math.Floor((double)y / 2820) + 365 * (this.Year - 1);
        
			result += Math.Floor((double)(682 * this.Year - 110) / 2816);

			if (this.Month <= 7)
			{
				result += 31 * (this.Month - 1);
			}
			else
			{
				result += 30 * (this.Month - 1) + 6;
			}

			result += this.Day;

			return result;
		}

		public override void FromMoment(double t)
		{
			int new_year = this._new_year_on_or_before(t);

			double y = 1 + Math.Round((new_year - ChronoTools.PERSIAN_EPOCH) / ChronoTools.MEAN_TROPICAL_YEAR);

			this.Year = y > 0 ? (int)y : (int)y  - 1;

			double day_of_year = 1 + t - new PersianDate(this.Year, 1, 1).ToMoment();

			if (day_of_year < 186)
			{
				this.Month = (int)(Math.Ceiling(day_of_year / 31));
			}
			else
			{
				this.Month = (int)(Math.Ceiling((day_of_year - 6) / 30));
			}
				

			this.Day = (int)(t - new PersianDate(this.Year, this.Month, 1).ToMoment());
		}

		private int _new_year_on_or_before(double t)
		{
			throw new NotImplementedException();
		}
	}
}
