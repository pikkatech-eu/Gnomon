/***********************************************************************************
* File:         TriadicDate.cs                                                     *
* Contents:     Class TriadicDate                                                  *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-10-20 1454                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace Gnomon.Library
{
	/// <summary>
	/// TriadicDate is a date (or calendar system) that uses the year, month, day hierarchy for the representation of time.
	/// </summary>
	public class TriadicDate: AbstractDate
	{
		#region Properties
		public int		Year {get;internal set;} = 0;
		public int		Month {get;internal set;} = 0;
		public double	Day {get;internal set;} = 0;
		#endregion

		#region Construction
		public TriadicDate(int year, int month, double day)
		{
			this.Year	= year;
			this.Month	= month;
			this.Day	= day;
		}

		public TriadicDate(TriadicDate date): this(date.Year, date.Month, date.Day)	{}
		public TriadicDate()	{}
		#endregion

		#region Validation
		public override bool IsValid()
		{
			return base.IsValid() && this.Month > 0 && this.Day > 0;
		}
		#endregion
	}
}
