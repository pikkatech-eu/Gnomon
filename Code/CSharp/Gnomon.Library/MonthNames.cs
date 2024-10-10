/***********************************************************************************
* File:         MonthNames.cs                                                      *
* Contents:     Class MonthNames                                                   *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-10 17:40                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Collections.Generic;
using Gnomon.Library.Enumerations;

namespace Gnomon.Library
{
	public static class MonthNames
	{
		public static readonly Dictionary<CalendarSystem, string[]> Names = new Dictionary<CalendarSystem, string[]>()
		{
			{CalendarSystem.Gregorian, new string[]		{
															"January",  
															"February",  
															"March",  
															"April",  
															"May",  
															"June",  
															"July",  
															"August",  
															"September",  
															"October",  
															"November",  
															"December"}},

			{CalendarSystem.Julian, new string[]		{
															"January",  
															"February",  
															"March",  
															"April",  
															"May",  
															"June",  
															"July",  
															"August",  
															"September",  
															"October",  
															"November",  
															"December"}},

			{CalendarSystem.WesternBahai, new string[]	{
															"Ayyám-i-Há",	// m_nMonth == 0
															"Bahá",			// m_nMonth == 1
															"Jalál",
															"Jamál",  
															"`Azamat",		
															"Núr",  
															"Rahmat",	  
															"Kalimát",	    
															"Kamál",	
															"Asmá",
															"`Izzat", 
															"Mashíyyat",   
															"`Ilm", 
															"Qudrat",	  
															"Qawl",			
															"Masá'il",
															"Sharaf", 
															"Sultán",		
															"Mulk",  
															"`Alá"
														}},

			{CalendarSystem.Islamic, new string[]	{
															"Muharram", 
															"Safar", 
															"Rabı‘ I", 
															"Rabı‘ II", 
															"Jumada I", 
															"Jumada II", 
															"Rajab", 
															"Sha‘ban", 
															"Ramadan", 
															"Shawwal", 
															"Dhu al-Qa‘da", 
															"Dhu al-Hijja"

													}},

			{CalendarSystem.Hebrew, new string[]	{
															"Nisan", 
															"Iyyar", 
															"Sivan", 
															"Tammuz", 
															"Av", 
															"Elul", 
															"Tishri", 
															"Marheshvan", 
															"Kislev", 
															"Tevet", 
															"Shevat", 
															"Adar I", 
															"Adar II"
													}},

			{CalendarSystem.Coptic, new string[]	{ 
															"Thout",
															"Paopi",
															"Hathor",
															"Koiak",
															"Tobi",
															"Meshir",
															"Paremhat",
															"Parmouti",
															"Pashons",
															"Paoni",
															"Epip",
															"Mesori",
															"Pi Kogi Enavot"
													}},

			{CalendarSystem.Ethiopic, new string[]	{
															"Maskaram",
															"Teqemt",
															"̱Hedār",
															"Tākhśāś",
															"̣Ter",
															"Yakātit",
															"Magābit",
															"Miyāzyā",
															"Genbot",
															"Sanē",
															"̣Hamlē",
															"Nạhasē",
															"Pāguemēn"
													}},

			{CalendarSystem.Persian, new string[]	{ 
															"Farvardīn",
															"Ordībehesht",
															"Xordād",
															"Tīr",
															"Mordād",
															"Shahrīvar",
															"Mehr",
															"Ābān",
															"Azar",
															"Dey",
															"Bahman",
															"Esfand",
													}},

			{CalendarSystem.French, new string[]	{
															"Vendémiaire",
															"Brumaire",
															"Frimaire",
															"Nivôse",
															"Pluviôse",
															"Ventôse",
															"Germinal",
															"Floréal",
															"Prairial",
															"Messidor",
															"Thermidor",
															"Fructidor",
													}}
		};
	}
}
