namespace Gnomon.Demo
{
	partial class GnomonDemoForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._tlpGnomon = new System.Windows.Forms.TableLayoutPanel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this._lblRataDie = new System.Windows.Forms.Label();
			this._lblModifiedJulianDays = new System.Windows.Forms.Label();
			this._btManageLocality = new System.Windows.Forms.Button();
			this._btRecalculate = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._btLockUnlock = new System.Windows.Forms.Button();
			this._panLocalityControl = new System.Windows.Forms.Panel();
			this._lblJulianDays = new System.Windows.Forms.Label();
			this._timerSecond = new System.Windows.Forms.Timer(this.components);
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this._lblLocalTime = new System.Windows.Forms.Label();
			this._lblUTCTime = new System.Windows.Forms.Label();
			this._ctrlJulian = new Bonsai.Chronology.Gui.Controls.TriadicDateControl();
			this._ctrlGregorian = new Bonsai.Chronology.Gui.Controls.TriadicDateControl();
			this._ctrlIslamic = new Bonsai.Chronology.Gui.Controls.TriadicDateControl();
			this._tlpGnomon.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tlpGnomon
			// 
			this._tlpGnomon.ColumnCount = 4;
			this._tlpGnomon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
			this._tlpGnomon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tlpGnomon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tlpGnomon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
			this._tlpGnomon.Controls.Add(this._ctrlIslamic, 1, 9);
			this._tlpGnomon.Controls.Add(this._ctrlJulian, 1, 8);
			this._tlpGnomon.Controls.Add(this._lblUTCTime, 1, 5);
			this._tlpGnomon.Controls.Add(this._lblLocalTime, 1, 4);
			this._tlpGnomon.Controls.Add(this.label13, 0, 5);
			this._tlpGnomon.Controls.Add(this.label12, 0, 4);
			this._tlpGnomon.Controls.Add(this.panel7, 1, 13);
			this._tlpGnomon.Controls.Add(this.panel6, 1, 12);
			this._tlpGnomon.Controls.Add(this.panel5, 1, 11);
			this._tlpGnomon.Controls.Add(this.panel4, 1, 10);
			this._tlpGnomon.Controls.Add(this.label11, 0, 13);
			this._tlpGnomon.Controls.Add(this.label10, 0, 12);
			this._tlpGnomon.Controls.Add(this.label9, 0, 11);
			this._tlpGnomon.Controls.Add(this.label8, 0, 10);
			this._tlpGnomon.Controls.Add(this.label7, 0, 9);
			this._tlpGnomon.Controls.Add(this.label6, 0, 8);
			this._tlpGnomon.Controls.Add(this.label5, 0, 7);
			this._tlpGnomon.Controls.Add(this._lblRataDie, 1, 3);
			this._tlpGnomon.Controls.Add(this._lblModifiedJulianDays, 1, 2);
			this._tlpGnomon.Controls.Add(this._btManageLocality, 3, 0);
			this._tlpGnomon.Controls.Add(this._btRecalculate, 2, 6);
			this._tlpGnomon.Controls.Add(this.label4, 0, 3);
			this._tlpGnomon.Controls.Add(this.label3, 0, 2);
			this._tlpGnomon.Controls.Add(this.label2, 0, 1);
			this._tlpGnomon.Controls.Add(this.label1, 0, 0);
			this._tlpGnomon.Controls.Add(this._btLockUnlock, 1, 6);
			this._tlpGnomon.Controls.Add(this._panLocalityControl, 1, 0);
			this._tlpGnomon.Controls.Add(this._lblJulianDays, 1, 1);
			this._tlpGnomon.Controls.Add(this._ctrlGregorian, 1, 7);
			this._tlpGnomon.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tlpGnomon.Location = new System.Drawing.Point(0, 0);
			this._tlpGnomon.Name = "_tlpGnomon";
			this._tlpGnomon.RowCount = 15;
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this._tlpGnomon.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpGnomon.Size = new System.Drawing.Size(951, 687);
			this._tlpGnomon.TabIndex = 0;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(18)))));
			this._tlpGnomon.SetColumnSpan(this.panel7, 2);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(205, 411);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(662, 22);
			this.panel7.TabIndex = 24;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(18)))));
			this._tlpGnomon.SetColumnSpan(this.panel6, 2);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(205, 383);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(662, 22);
			this.panel6.TabIndex = 23;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(18)))));
			this._tlpGnomon.SetColumnSpan(this.panel5, 2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(205, 355);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(662, 22);
			this.panel5.TabIndex = 22;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(18)))));
			this._tlpGnomon.SetColumnSpan(this.panel4, 2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(205, 327);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(662, 22);
			this.panel4.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label11.Font = new System.Drawing.Font("Consolas", 12F);
			this.label11.Location = new System.Drawing.Point(3, 408);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(196, 28);
			this.label11.TabIndex = 17;
			this.label11.Text = "Coptic";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.Font = new System.Drawing.Font("Consolas", 12F);
			this.label10.Location = new System.Drawing.Point(3, 380);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(196, 28);
			this.label10.TabIndex = 16;
			this.label10.Text = "Western Bahai";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Font = new System.Drawing.Font("Consolas", 12F);
			this.label9.Location = new System.Drawing.Point(3, 352);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(196, 28);
			this.label9.TabIndex = 15;
			this.label9.Text = "Persian";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Font = new System.Drawing.Font("Consolas", 12F);
			this.label8.Location = new System.Drawing.Point(3, 324);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(196, 28);
			this.label8.TabIndex = 14;
			this.label8.Text = "Hebrew";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Consolas", 12F);
			this.label7.Location = new System.Drawing.Point(3, 296);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(196, 28);
			this.label7.TabIndex = 13;
			this.label7.Text = "Islamic";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Consolas", 12F);
			this.label6.Location = new System.Drawing.Point(3, 268);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(196, 28);
			this.label6.TabIndex = 12;
			this.label6.Text = "Julian";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Consolas", 12F);
			this.label5.Location = new System.Drawing.Point(3, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(196, 28);
			this.label5.TabIndex = 11;
			this.label5.Text = "Gregorian";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _lblRataDie
			// 
			this._lblRataDie.AutoSize = true;
			this._tlpGnomon.SetColumnSpan(this._lblRataDie, 2);
			this._lblRataDie.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblRataDie.Location = new System.Drawing.Point(205, 104);
			this._lblRataDie.Name = "_lblRataDie";
			this._lblRataDie.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this._lblRataDie.Size = new System.Drawing.Size(662, 32);
			this._lblRataDie.TabIndex = 10;
			this._lblRataDie.Text = "...";
			this._lblRataDie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _lblModifiedJulianDays
			// 
			this._lblModifiedJulianDays.AutoSize = true;
			this._tlpGnomon.SetColumnSpan(this._lblModifiedJulianDays, 2);
			this._lblModifiedJulianDays.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblModifiedJulianDays.Location = new System.Drawing.Point(205, 72);
			this._lblModifiedJulianDays.Name = "_lblModifiedJulianDays";
			this._lblModifiedJulianDays.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this._lblModifiedJulianDays.Size = new System.Drawing.Size(662, 32);
			this._lblModifiedJulianDays.TabIndex = 9;
			this._lblModifiedJulianDays.Text = "...";
			this._lblModifiedJulianDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _btManageLocality
			// 
			this._btManageLocality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this._btManageLocality.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btManageLocality.Location = new System.Drawing.Point(873, 3);
			this._btManageLocality.Name = "_btManageLocality";
			this._btManageLocality.Size = new System.Drawing.Size(75, 34);
			this._btManageLocality.TabIndex = 7;
			this._btManageLocality.Text = "Manage";
			this._btManageLocality.UseVisualStyleBackColor = false;
			// 
			// _btRecalculate
			// 
			this._btRecalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this._btRecalculate.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btRecalculate.Location = new System.Drawing.Point(539, 203);
			this._btRecalculate.Name = "_btRecalculate";
			this._btRecalculate.Size = new System.Drawing.Size(328, 34);
			this._btRecalculate.TabIndex = 5;
			this._btRecalculate.Text = "Recalculate";
			this._btRecalculate.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Consolas", 12F);
			this.label4.Location = new System.Drawing.Point(3, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(196, 32);
			this.label4.TabIndex = 3;
			this.label4.Text = "Rata Die (RD)";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Consolas", 12F);
			this.label3.Location = new System.Drawing.Point(3, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(196, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Modified Julian days";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Consolas", 12F);
			this.label2.Location = new System.Drawing.Point(3, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Julian days";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Consolas", 12F);
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Locality";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _btLockUnlock
			// 
			this._btLockUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this._btLockUnlock.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btLockUnlock.Location = new System.Drawing.Point(205, 203);
			this._btLockUnlock.Name = "_btLockUnlock";
			this._btLockUnlock.Size = new System.Drawing.Size(328, 34);
			this._btLockUnlock.TabIndex = 4;
			this._btLockUnlock.Text = "Lock/Unlock Controls";
			this._btLockUnlock.UseVisualStyleBackColor = false;
			// 
			// _panLocalityControl
			// 
			this._panLocalityControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(18)))));
			this._tlpGnomon.SetColumnSpan(this._panLocalityControl, 2);
			this._panLocalityControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._panLocalityControl.Location = new System.Drawing.Point(205, 3);
			this._panLocalityControl.Name = "_panLocalityControl";
			this._panLocalityControl.Size = new System.Drawing.Size(662, 34);
			this._panLocalityControl.TabIndex = 6;
			// 
			// _lblJulianDays
			// 
			this._lblJulianDays.AutoSize = true;
			this._tlpGnomon.SetColumnSpan(this._lblJulianDays, 2);
			this._lblJulianDays.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblJulianDays.Location = new System.Drawing.Point(205, 40);
			this._lblJulianDays.Name = "_lblJulianDays";
			this._lblJulianDays.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this._lblJulianDays.Size = new System.Drawing.Size(662, 32);
			this._lblJulianDays.TabIndex = 8;
			this._lblJulianDays.Text = "...";
			this._lblJulianDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label12.Font = new System.Drawing.Font("Consolas", 12F);
			this.label12.Location = new System.Drawing.Point(3, 136);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(196, 32);
			this.label12.TabIndex = 26;
			this.label12.Text = "Local time";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label13.Font = new System.Drawing.Font("Consolas", 12F);
			this.label13.Location = new System.Drawing.Point(3, 168);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(196, 32);
			this.label13.TabIndex = 27;
			this.label13.Text = "UTC time";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _lblLocalTime
			// 
			this._lblLocalTime.AutoSize = true;
			this._tlpGnomon.SetColumnSpan(this._lblLocalTime, 2);
			this._lblLocalTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblLocalTime.Location = new System.Drawing.Point(205, 136);
			this._lblLocalTime.Name = "_lblLocalTime";
			this._lblLocalTime.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this._lblLocalTime.Size = new System.Drawing.Size(662, 32);
			this._lblLocalTime.TabIndex = 28;
			this._lblLocalTime.Text = "...";
			this._lblLocalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _lblUTCTime
			// 
			this._lblUTCTime.AutoSize = true;
			this._tlpGnomon.SetColumnSpan(this._lblUTCTime, 2);
			this._lblUTCTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblUTCTime.Location = new System.Drawing.Point(205, 168);
			this._lblUTCTime.Name = "_lblUTCTime";
			this._lblUTCTime.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this._lblUTCTime.Size = new System.Drawing.Size(662, 32);
			this._lblUTCTime.TabIndex = 29;
			this._lblUTCTime.Text = "...";
			this._lblUTCTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _ctrlJulian
			// 
			this._tlpGnomon.SetColumnSpan(this._ctrlJulian, 2);
			this._ctrlJulian.Days = new string[] {
        "Unknown",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12",
        "13",
        "14",
        "15",
        "16",
        "17",
        "18",
        "19",
        "20",
        "21",
        "22",
        "23",
        "24",
        "25",
        "26",
        "27",
        "28",
        "29",
        "30",
        "31"};
			this._ctrlJulian.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ctrlJulian.Font = new System.Drawing.Font("Consolas", 10F);
			this._ctrlJulian.Location = new System.Drawing.Point(202, 268);
			this._ctrlJulian.Margin = new System.Windows.Forms.Padding(0);
			this._ctrlJulian.Months = new string[0];
			this._ctrlJulian.Name = "_ctrlJulian";
			this._ctrlJulian.Size = new System.Drawing.Size(668, 28);
			this._ctrlJulian.TabIndex = 30;
			this._ctrlJulian.TriadicDate = null;
			// 
			// _ctrlGregorian
			// 
			this._tlpGnomon.SetColumnSpan(this._ctrlGregorian, 2);
			this._ctrlGregorian.Days = new string[] {
        "Unknown",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12",
        "13",
        "14",
        "15",
        "16",
        "17",
        "18",
        "19",
        "20",
        "21",
        "22",
        "23",
        "24",
        "25",
        "26",
        "27",
        "28",
        "29",
        "30",
        "31"};
			this._ctrlGregorian.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ctrlGregorian.Font = new System.Drawing.Font("Consolas", 10F);
			this._ctrlGregorian.Location = new System.Drawing.Point(202, 240);
			this._ctrlGregorian.Margin = new System.Windows.Forms.Padding(0);
			this._ctrlGregorian.Months = new string[0];
			this._ctrlGregorian.Name = "_ctrlGregorian";
			this._ctrlGregorian.Size = new System.Drawing.Size(668, 28);
			this._ctrlGregorian.TabIndex = 25;
			this._ctrlGregorian.TriadicDate = null;
			// 
			// _ctrlIslamic
			// 
			this._tlpGnomon.SetColumnSpan(this._ctrlIslamic, 2);
			this._ctrlIslamic.Days = new string[] {
        "Unknown",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12",
        "13",
        "14",
        "15",
        "16",
        "17",
        "18",
        "19",
        "20",
        "21",
        "22",
        "23",
        "24",
        "25",
        "26",
        "27",
        "28",
        "29",
        "30",
        "31"};
			this._ctrlIslamic.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ctrlIslamic.Font = new System.Drawing.Font("Consolas", 10F);
			this._ctrlIslamic.Location = new System.Drawing.Point(202, 296);
			this._ctrlIslamic.Margin = new System.Windows.Forms.Padding(0);
			this._ctrlIslamic.Months = new string[0];
			this._ctrlIslamic.Name = "_ctrlIslamic";
			this._ctrlIslamic.Size = new System.Drawing.Size(668, 28);
			this._ctrlIslamic.TabIndex = 31;
			this._ctrlIslamic.TriadicDate = null;
			// 
			// GnomonDemoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.ClientSize = new System.Drawing.Size(951, 687);
			this.Controls.Add(this._tlpGnomon);
			this.Font = new System.Drawing.Font("Consolas", 10F);
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "GnomonDemoForm";
			this.Text = "Gnomon Demo 1.0";
			this._tlpGnomon.ResumeLayout(false);
			this._tlpGnomon.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _tlpGnomon;
		private System.Windows.Forms.Button _btRecalculate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _btLockUnlock;
		private System.Windows.Forms.Panel _panLocalityControl;
		private System.Windows.Forms.Label _lblRataDie;
		private System.Windows.Forms.Label _lblModifiedJulianDays;
		private System.Windows.Forms.Button _btManageLocality;
		private System.Windows.Forms.Label _lblJulianDays;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Timer _timerSecond;
		private Bonsai.Chronology.Gui.Controls.TriadicDateControl _ctrlGregorian;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label _lblUTCTime;
		private System.Windows.Forms.Label _lblLocalTime;
		private Bonsai.Chronology.Gui.Controls.TriadicDateControl _ctrlJulian;
		private Bonsai.Chronology.Gui.Controls.TriadicDateControl _ctrlIslamic;
	}
}

