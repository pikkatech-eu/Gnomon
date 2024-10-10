/***********************************************************************************
* File:         IDate.cs                                                           *
* Contents:     Interface IDate                                                    *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-10-20 1424                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnomon.Library
{
	/// <summary>
	/// Upper-level abstraction of a time moment (calendar date).
	/// </summary>
	public interface IDate
	{
		#region Properties
		/// <summary>
		/// Tzhe value of Rata Die (Reingold & Dershowitz).
		/// </summary>
		double RataDie	{get;}

		/// <summary>
		/// The value in Julian days.
		/// </summary>
		double JulianDays	{get;}

		/// <summary>
		/// The value in modofoed Julian days.
		/// </summary>
		double ModifiedJulianDays {get;}
		#endregion

		#region
		/// <summary>
		/// Validation concept: only those dates are valid where Rata Die >= 1.
		/// </summary>
		/// <returns>True, if the instance is valid.</returns>
		bool IsValid();
		#endregion

		/// <summary>
		/// Calculates the value of RataDie (Reingold & Dershowitz).
		/// </summary>
		/// <returns>The value of RataDie for a derived calendar system, days.</returns>
		double ToMoment();

		/// <summary>
		/// Creates an instance of a derived calendar system from a RataDie value.
		/// </summary>
		/// <param name="t">The value of RataDie.</param>
		void FromMoment(double t);

		/// <summary>
		/// String representation in a given format.
		/// </summary>
		/// <param name="format">The format to represent in.</param>
		/// <returns>The string representation.</returns>
		string ToString(string format);
	}
}
