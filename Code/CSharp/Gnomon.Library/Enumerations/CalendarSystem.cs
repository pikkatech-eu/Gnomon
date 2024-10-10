/***********************************************************************************
* File:         CalendarSystem.cs                                                  *
* Contents:     Enum CalendarSystem                                                *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-09-10 12:50                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
// using GD = Bonsai.Chronology.GregorianDate;

namespace Gnomon.Library.Enumerations
{
	/// <summary>
	/// S	upported calendar systems (triadic calendars).
	/// </summary>
	public enum CalendarSystem
	{
		Gregorian = 0,
		Julian = 1,
		Hebrew = 2,
		French = 3,
		Islamic = 4,
		WesternBahai = 5,
		Persian = 6,
		Coptic = 7,
		Ethiopic = 8,
		Unknown = -1
	}
}
