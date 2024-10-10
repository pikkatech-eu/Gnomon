namespace Bonsai.Chronology.Gui.Controls
{
	partial class TriadicDateControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._tlpTriadicDate = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._txYear = new System.Windows.Forms.TextBox();
			this._cxMonth = new System.Windows.Forms.ComboBox();
			this._cxDay = new System.Windows.Forms.ComboBox();
			this._epTriadicDate = new System.Windows.Forms.ErrorProvider(this.components);
			this._tlpTriadicDate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._epTriadicDate)).BeginInit();
			this.SuspendLayout();
			// 
			// _tlpTriadicDate
			// 
			this._tlpTriadicDate.ColumnCount = 6;
			this._tlpTriadicDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._tlpTriadicDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this._tlpTriadicDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._tlpTriadicDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this._tlpTriadicDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._tlpTriadicDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this._tlpTriadicDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._tlpTriadicDate.Controls.Add(this.label3, 4, 0);
			this._tlpTriadicDate.Controls.Add(this.label2, 2, 0);
			this._tlpTriadicDate.Controls.Add(this.label1, 0, 0);
			this._tlpTriadicDate.Controls.Add(this._txYear, 1, 0);
			this._tlpTriadicDate.Controls.Add(this._cxMonth, 3, 0);
			this._tlpTriadicDate.Controls.Add(this._cxDay, 5, 0);
			this._tlpTriadicDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tlpTriadicDate.Location = new System.Drawing.Point(0, 0);
			this._tlpTriadicDate.Name = "_tlpTriadicDate";
			this._tlpTriadicDate.RowCount = 1;
			this._tlpTriadicDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpTriadicDate.Size = new System.Drawing.Size(467, 30);
			this._tlpTriadicDate.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(313, 3);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "D";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(158, 3);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "M";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Y";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _txYear
			// 
			this._txYear.Dock = System.Windows.Forms.DockStyle.Top;
			this._txYear.Location = new System.Drawing.Point(23, 3);
			this._txYear.Name = "_txYear";
			this._txYear.Size = new System.Drawing.Size(129, 23);
			this._txYear.TabIndex = 5;
			this._txYear.TextChanged += new System.EventHandler(this.OnYearTextChanged);
			// 
			// _cxMonth
			// 
			this._cxMonth.Dock = System.Windows.Forms.DockStyle.Top;
			this._cxMonth.FormattingEnabled = true;
			this._cxMonth.Location = new System.Drawing.Point(178, 3);
			this._cxMonth.Name = "_cxMonth";
			this._cxMonth.Size = new System.Drawing.Size(129, 23);
			this._cxMonth.TabIndex = 6;
			// 
			// _cxDay
			// 
			this._cxDay.Dock = System.Windows.Forms.DockStyle.Top;
			this._cxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cxDay.FormattingEnabled = true;
			this._cxDay.Location = new System.Drawing.Point(333, 3);
			this._cxDay.Name = "_cxDay";
			this._cxDay.Size = new System.Drawing.Size(131, 23);
			this._cxDay.TabIndex = 7;
			// 
			// _epTriadicDate
			// 
			this._epTriadicDate.ContainerControl = this;
			// 
			// TriadicDateControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._tlpTriadicDate);
			this.Font = new System.Drawing.Font("Consolas", 10F);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "TriadicDateControl";
			this.Size = new System.Drawing.Size(467, 30);
			this._tlpTriadicDate.ResumeLayout(false);
			this._tlpTriadicDate.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._epTriadicDate)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _tlpTriadicDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _txYear;
		private System.Windows.Forms.ComboBox _cxMonth;
		private System.Windows.Forms.ComboBox _cxDay;
		private System.Windows.Forms.ErrorProvider _epTriadicDate;
	}
}
