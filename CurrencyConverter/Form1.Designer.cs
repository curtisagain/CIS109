namespace CurrencyConverter
{
	partial class currencyForm
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
			this.buttonConverter = new System.Windows.Forms.Button();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// buttonConverter
			// 
			this.buttonConverter.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonConverter.Location = new System.Drawing.Point(-2, 13);
			this.buttonConverter.Name = "buttonConverter";
			this.buttonConverter.Size = new System.Drawing.Size(804, 37);
			this.buttonConverter.TabIndex = 0;
			this.buttonConverter.Text = "Currency Converter";
			this.buttonConverter.UseVisualStyleBackColor = false;
			this.buttonConverter.Click += new System.EventHandler(this.ButtonConverter_Click);
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(-2, 56);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(790, 382);
			this.webBrowser1.TabIndex = 1;
			// 
			// currencyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.buttonConverter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "currencyForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "World Currency Converter";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonConverter;
		private System.Windows.Forms.WebBrowser webBrowser1;
	}
}

