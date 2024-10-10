/***********************************************************************************
* File:         CalendarSystem.cs                                                  *
* Contents:     Enum CalendarSystem                                                *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-09-10 12:50                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using GD = Bonsai.Chronology.GregorianDate;

namespace Bonsai.Chronology.Enumerations
{
	/// <summary>
	/// Contains enum and methods to handle calendar system kind string export and import.
	/// </summary>
	public class CalendarSystem
	{
		/// <summary>
		/// Supported calendar systems (triadic calendars).
		/// </summary>
		public enum Kind
		{
			Gregorian = 0,
			Julian = 1,
			Hebrew = 2,
			French = 3,
			Islamic = 4,
			WesternBahai = 5,
			Unknown = -1
		}

		public static string[] SupportedCodes = {"GR", "JU", "HE", "FR", "IS", "WB"};
		public static string[] SupportedGedcomCalendars = {"GREGORIAN", "JULIAN", "HEBREW", "FRENCH"};

		public static string ToCode(Kind t)
		{
			switch (t)
			{
				case Kind.Gregorian:
					return "GR";

				case Kind.Julian:
					return "JU";

				case Kind.Hebrew:
					return "HE";

				case Kind.French:
					return "FR";

				case Kind.Islamic:
					return "IS";

				case Kind.WesternBahai:
					return "WB";

				case Kind.Unknown:
				default:
					return null;
			}
		}

		public static Kind FromCode(string code)
		{
			switch (code.ToUpper())
			{
				case "GR":
					return Kind.Gregorian;

				case "JU":
					return Kind.Julian;

				case "HE":
					return Kind.Hebrew;

				case "FR":
					return Kind.French;

				case "IS":
					return Kind.Islamic;

				case "WB":
					return Kind.WesternBahai;

				default:
					return Kind.Unknown;
			}
		}

		public static string ToGedcom(Kind t)
		{
			switch (t)
			{
				case Kind.Gregorian:
					return "GREGORIAN";

				case Kind.Julian:
					return "JULIAN";

				case Kind.Hebrew:
					return "HEBREW";

				case Kind.French:
					return "FRENCH";

				case Kind.Islamic:
				case Kind.WesternBahai:
				case Kind.Unknown:
				default:
					return null;
			}
		}

		public static Kind FromGedcom(string gedcom)
		{
			switch (gedcom.ToUpper())
			{
				case "GREGORIAN":
					return Kind.Gregorian;

				case "JULIAN":
					return Kind.Julian;

				case "HEBREW":
					return Kind.Hebrew;

				case "FRENCH":
					return Kind.French;

				case "IS":
				case "WB":
				default:
					return Kind.Unknown;
			}
		}

		/// <summary>
		/// Gets the number of a month by its name and calendar system.
		/// </summary>
		/// <param name="monthName">The name of the month to number.</param>
		/// <param name="kind">The kind of calendar system.</param>
		/// <returns>The number of the month (1-based).</returns>
		/// <exception cref="ArgumentException">Thrown if the calendar system is not yet supported.</exception>
		public static int GetMonthNumber(string monthName, Kind kind)
		{
			switch (kind)
			{
				case Kind.Gregorian:
					return GD.GedcomMonthDictionary[monthName] + 1;

				case Kind.Julian:
				case Kind.Hebrew:
				case Kind.French:
				case Kind.Islamic:
				case Kind.WesternBahai:
				case Kind.Unknown:
				default:
					throw new ArgumentException($"Calendar system {kind} not (yet) supported.");
			}
		}
	}
}
