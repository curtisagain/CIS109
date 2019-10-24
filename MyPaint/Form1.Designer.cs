namespace MyPaint
{
	partial class myPaintForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myPaintForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.RedButton = new System.Windows.Forms.ToolStripButton();
			this.BlueButton = new System.Windows.Forms.ToolStripButton();
			this.GreenButton = new System.Windows.Forms.ToolStripButton();
			this.PurpleButton = new System.Windows.Forms.ToolStripButton();
			this.LimeButton = new System.Windows.Forms.ToolStripButton();
			this.myPaintPictureBox = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.myPaintPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.saveImageAsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.saveAsToolStripMenuItem.Text = "Save As";
			// 
			// saveImageAsToolStripMenuItem
			// 
			this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
			this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.saveImageAsToolStripMenuItem.Text = "Save Image As";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RedButton,
            this.BlueButton,
            this.GreenButton,
            this.PurpleButton,
            this.LimeButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// RedButton
			// 
			this.RedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.RedButton.ForeColor = System.Drawing.Color.Red;
			this.RedButton.Image = ((System.Drawing.Image)(resources.GetObject("RedButton.Image")));
			this.RedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RedButton.Name = "RedButton";
			this.RedButton.Size = new System.Drawing.Size(31, 22);
			this.RedButton.Text = "Red";
			this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
			// 
			// BlueButton
			// 
			this.BlueButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.BlueButton.ForeColor = System.Drawing.Color.Blue;
			this.BlueButton.Image = ((System.Drawing.Image)(resources.GetObject("BlueButton.Image")));
			this.BlueButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BlueButton.Name = "BlueButton";
			this.BlueButton.Size = new System.Drawing.Size(34, 22);
			this.BlueButton.Text = "Blue";
			this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
			// 
			// GreenButton
			// 
			this.GreenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.GreenButton.ForeColor = System.Drawing.Color.Green;
			this.GreenButton.Image = ((System.Drawing.Image)(resources.GetObject("GreenButton.Image")));
			this.GreenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.GreenButton.Name = "GreenButton";
			this.GreenButton.Size = new System.Drawing.Size(42, 22);
			this.GreenButton.Text = "Green";
			this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
			// 
			// PurpleButton
			// 
			this.PurpleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.PurpleButton.ForeColor = System.Drawing.Color.Purple;
			this.PurpleButton.Image = ((System.Drawing.Image)(resources.GetObject("PurpleButton.Image")));
			this.PurpleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PurpleButton.Name = "PurpleButton";
			this.PurpleButton.Size = new System.Drawing.Size(45, 22);
			this.PurpleButton.Text = "Purple";
			this.PurpleButton.Click += new System.EventHandler(this.PurpleButton_Click);
			// 
			// LimeButton
			// 
			this.LimeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.LimeButton.ForeColor = System.Drawing.Color.Lime;
			this.LimeButton.Image = ((System.Drawing.Image)(resources.GetObject("LimeButton.Image")));
			this.LimeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.LimeButton.Name = "LimeButton";
			this.LimeButton.Size = new System.Drawing.Size(37, 22);
			this.LimeButton.Text = "Lime";
			this.LimeButton.Click += new System.EventHandler(this.LimeButton_Click);
			// 
			// myPaintPictureBox
			// 
			this.myPaintPictureBox.BackColor = System.Drawing.Color.Black;
			this.myPaintPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myPaintPictureBox.Location = new System.Drawing.Point(0, 49);
			this.myPaintPictureBox.Name = "myPaintPictureBox";
			this.myPaintPictureBox.Size = new System.Drawing.Size(800, 401);
			this.myPaintPictureBox.TabIndex = 2;
			this.myPaintPictureBox.TabStop = false;
			this.myPaintPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyPaintPictureBox_MouseMove);
			// 
			// myPaintForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.myPaintPictureBox);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "myPaintForm";
			this.Text = "My Paint";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyPaintForm_MouseClick);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MyPaintForm_MouseClick);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.myPaintPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton RedButton;
		private System.Windows.Forms.ToolStripButton BlueButton;
		private System.Windows.Forms.ToolStripButton GreenButton;
		private System.Windows.Forms.ToolStripButton PurpleButton;
		private System.Windows.Forms.ToolStripButton LimeButton;
		private System.Windows.Forms.PictureBox myPaintPictureBox;
	}
}

