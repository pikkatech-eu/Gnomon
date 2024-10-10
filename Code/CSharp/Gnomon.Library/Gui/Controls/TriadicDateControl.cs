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
		private static readonly Regex RX_YEAR = new Regex(@"^-?\d{1,4}$");

		public string[] Months
		{
			get
			{
				List<string> result = new List<string>();

				foreach (var item in this._cxMonth.Items)
				{
					result.Add(item.ToString());
				}

				return result.ToArray();
			}

			set
			{
				this._cxMonth.Items.Clear();
				this._cxMonth.Items.AddRange(value);
			}
		}

		public string[] Days
		{
			get
			{
				List<string> result = new List<string>();

				foreach (var item in this._cxDay.Items)
				{
					result.Add(item.ToString());
				}

				return result.ToArray();
			}

			set
			{
				this._cxDay.Items.Clear();
				this._cxDay.Items.AddRange(value);
			}
		}

		public TriadicDateControl()
		{
			InitializeComponent();

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
					date.Year			= Int32.Parse(this._txYear.Text);
					date.Month			= this._cxMonth.SelectedIndex + 1;
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
				if (value != null)
				{
					this._txYear.Text			= value.Year.ToString();
					this._cxMonth.SelectedIndex	= value.Month - 1;
					this._cxDay.SelectedIndex	= (int)value.Day;
				}
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
