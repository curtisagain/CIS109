﻿namespace ScreenSaver
{
	partial class FormScreenSaver
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
			this.ScreenSaverTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// ScreenSaverTimer
			// 
			this.ScreenSaverTimer.Enabled = true;
			this.ScreenSaverTimer.Interval = 12000;
			this.ScreenSaverTimer.Tick += new System.EventHandler(this.ScreenSaverTimer_Tick);
			// 
			// FormScreenSaver
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormScreenSaver";
			this.ShowInTaskbar = false;
			this.Text = "My Screen";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormScreenSaver_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormScreenSaver_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormScreenSaver_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer ScreenSaverTimer;
	}
}

