/***********************************************************************************
* File:         GnomonDemoForm.cs                                                  *
* Contents:     Class Form1                                                        *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-10 15:19                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gnomon.Library;

namespace Gnomon.Demo
{
	public partial class GnomonDemoForm : Form
	{
		public GnomonDemoForm()
		{
			InitializeComponent();

			this._ctrlGregorian.Months	= MonthNames.Names[Library.Enumerations.CalendarSystem.Gregorian];
			this._ctrlJulian.Months		= MonthNames.Names[Library.Enumerations.CalendarSystem.Julian];
			this._ctrlIslamic.Months	= MonthNames.Names[Library.Enumerations.CalendarSystem.Islamic];

			this._timerSecond.Interval	= 1000;
			this._timerSecond.Tick		+= this.OnSecondTick;
			this._timerSecond.Start();
		}

		private void OnSecondTick(object sender, EventArgs e)
		{
			DateTime dateTimeNow				= DateTime.Now;
			GregorianDate gregorian				= new GregorianDate(dateTimeNow);
			double rataDie						= gregorian.ToMoment();

			this._lblRataDie.Text				= rataDie.ToString();

			double julianDays					= gregorian.JulianDays;

			this._lblJulianDays.Text			= julianDays.ToString();

			double modifiedJulianDays			= gregorian.ModifiedJulianDays;

			this._lblModifiedJulianDays.Text	= modifiedJulianDays.ToString();

			this._lblLocalTime.Text				= DateTime.Now.ToString("HH:mm:ss");
			this._lblUTCTime.Text				= DateTime.UtcNow.ToString("HH:mm:ss");

			this._ctrlGregorian.TriadicDate		= gregorian;

			JulianDate julian					= new JulianDate();
			julian.FromMoment(rataDie);

			this._ctrlJulian.TriadicDate		= julian;

			IslamicDate islamic					= new IslamicDate();
			islamic.FromMoment(rataDie);
			this._ctrlIslamic.TriadicDate		= islamic;
		}
	}
}
