/***********************************************************************************
* File:         ChronoBase.cs                                                      *
* Contents:     Class ChronoBase                                                   *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-10-20 1432                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Gnomon.Library.Tools;

namespace Gnomon.Library
{
	public class AbstractDate: IDate
	{
		#region Protected members
		protected double	_rataDie = 0;
		#endregion

		#region Properties
		/// <summary>
		/// Tzhe value of Rata Die (Reingold & Dershowitz).
		/// </summary>
		public double RataDie	
		{
			get {return this._rataDie;}
		}

		public double ModifiedJulianDays 
		{
			get {return this._rataDie - ChronoTools.MJD_EPOCH;}
		}

		/// <summary>
		/// The value of Julian days.
		/// </summary>
		public double JulianDays	
		{
			get	{return this._rataDie - ChronoTools.JULIAN_DAY_EPOCH;}
		}
		#endregion

		#region Construction
		internal AbstractDate(double t)
		{
			this._rataDie = t;
		}

		internal AbstractDate(AbstractDate chrono): this(chrono.RataDie)	{}

		internal AbstractDate(): this(double.NegativeInfinity)				{}

		public static implicit operator AbstractDate(double t) => new AbstractDate(t);
		public static implicit operator double(AbstractDate chronoBase) => chronoBase.RataDie;
		#endregion

		#region
		/// <summary>
		/// Validation concept: only those dates are valid where Rata Die >= 1.
		/// </summary>
		/// <returns>True, if the instance is valid.</returns>
		public virtual bool IsValid()
		{
			return this._rataDie > 0;
		}
		#endregion

		#region Abstract Methods
		/// <summary>
		/// Calculates the value of RataDie (Reingold & Dershowitz).
		/// </summary>
		/// <returns>The value of RataDie for a derived calendar system, days.</returns>
		public virtual double ToMoment()
		{
			return this._rataDie;
		}

		/// <summary>
		/// Creates an instance of a derived calendar system from a RataDie value.
		/// </summary>
		/// <param name="t">The value of RataDie.</param>
		public virtual void FromMoment(double t)
		{
			this._rataDie = t;
		}

		/// <summary>
		/// String representation in a given format.
		/// </summary>
		/// <param name="format">The format to represent in.</param>
		/// <returns>The string representation.</returns>
		public virtual string ToString(string format)
		{
			return $"RD: {this._rataDie}";
		}
		#endregion
	}
}
