/***********************************************************************************
* File:         TriadicDateControl.cs                                              *
* Contents:     Class TriadicDateControl                                           *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-01 22:21                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Diebus.Gui.Interfaces;
using Gnomon.Library;

namespace Bonsai.Chronology.Gui.Controls
{
	public partial class TriadicDateControl : UserControl, ITriadicDateControl
	{
		private static readonly Dictionary<int, string[]> MONTH_NAMES = new Dictionary<int, string[]>()
		{
			{0, new string[] {	// Gregorian
			"Unknown", 
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
			"December" }},

			{1, new string[] {	// Julian
			"Unknown", 
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
			"December" }},

			{2, new string[] {	// Hebrew
				"Unknown",
				"Tishri",
				"Cheshvan",
				"Kislev",
				"Tevet",
				"Shevat",
				"Adar",
				"Adar Sheni",
				"Nisan",
				"Iyar",
				"Sivan",
				"Tammuz",
				"Av",
				"Elul"
			}},

			{3, new string[] {	// French
				"Unknown",
				"Vendemiaire",
				"Brumaire",
				"Frimaire",
				"Nivose",
				"Pluviose",
				"Ventose",
				"Germinal",
				"Floreal",
				"Prairial",
				"Messidor",
				"Thermidor",
				"Fructidor",
				"J.C."
			}},

			{4, new string[] {	// Islamic
				"Unknown",
				"Muharram",
				"Safar",
				"Rabi I",
				"Rabi II",
				"Jumada I",
				"Jumada II",
				"Rajab",
				"Sha`ban",
				"Ramadan",
				"Shawwal",
				"Dhu al-Qa`da",
				"Dhu al-Hijja"
			}},

			{5, new string[] {	// Western Bahai
				"unknown",
				"Ayyám-i-Há",	// month # 0
				"Bahá",			// month # 1
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
			}}
		};

		private static readonly Regex RX_YEAR = new Regex(@"^-?\d{1,4}$");

		public TriadicDateControl()
		{
			InitializeComponent();

			//this._cxCalendarSystem.DataSource = Enum.GetValues(typeof(CalendarSystem.Kind));
			//this._cxCalendarSystem.SelectedItem = CalendarSystem.Kind.Gregorian;

			// No validation here so far, even for Gregorian dates
			this._cxDay.Items.Clear();
			this._cxDay.Items.Add("Unknown");

			for (int i = 1; i <= 31; i++)
			{
				this._cxDay.Items.Add(i);
			}

			this._cxDay.SelectedIndex = 0;
		}

		public TriadicDate TriadicDate 
		{ 
			get
			{
				try
				{
					TriadicDate date	= new TriadicDate();
					//date.IsExact		= this._cbIsExact.Checked;
					//date.CalendarKind	= (CalendarSystem.Kind)this._cxCalendarSystem.SelectedItem;
					date.Year			= Int32.Parse(this._txYear.Text);
					date.Month			= this._cxMonth.SelectedIndex;
					date.Day			= this._cxDay.SelectedIndex;

					return date;
				}
				catch (Exception)
				{
					return null;
				}
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		private void OnSelectedCalendarChanged(object sender, EventArgs e)
		{
			if (this._cxCalendarSystem.SelectedIndex >= 0 && this._cxCalendarSystem.SelectedIndex <= 5)
			{
				this._cxMonth.DataSource = MONTH_NAMES[this._cxCalendarSystem.SelectedIndex].ToArray();
				this._cxMonth.SelectedIndex = 0;
			}
			else
			{
				this._cxMonth.Items.Clear();
			}
		}

		private void OnYearTextChanged(object sender, EventArgs e)
		{
			if (!RX_YEAR.IsMatch(this._txYear.Text))
			{
				this._epTriadicDate.SetError(this._txYear, "The string is not valid year.");
			}
			else
			{
				this._epTriadicDate.Clear();
			}
		}
	}
}
