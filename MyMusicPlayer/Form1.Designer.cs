namespace MyMusicPlayer
{
	partial class MyMusicPlayer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMusicPlayer));
			this.Player = new AxWMPLib.AxWindowsMediaPlayer();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.buttonPlay = new System.Windows.Forms.Button();
			this.buttonPause = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
			this.SuspendLayout();
			// 
			// Player
			// 
			this.Player.Enabled = true;
			this.Player.Location = new System.Drawing.Point(0, 0);
			this.Player.Name = "Player";
			this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
			this.Player.Size = new System.Drawing.Size(1061, 296);
			this.Player.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(0, 327);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(143, 35);
			this.textBox1.TabIndex = 1;
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.BackColor = System.Drawing.Color.Coral;
			this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonBrowse.Location = new System.Drawing.Point(70, 435);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(157, 46);
			this.buttonBrowse.TabIndex = 2;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = false;
			this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
			// 
			// buttonPlay
			// 
			this.buttonPlay.BackColor = System.Drawing.Color.Green;
			this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonPlay.Location = new System.Drawing.Point(251, 435);
			this.buttonPlay.Name = "buttonPlay";
			this.buttonPlay.Size = new System.Drawing.Size(157, 46);
			this.buttonPlay.TabIndex = 3;
			this.buttonPlay.Text = "Play";
			this.buttonPlay.UseVisualStyleBackColor = false;
			this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
			// 
			// buttonPause
			// 
			this.buttonPause.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonPause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonPause.Location = new System.Drawing.Point(436, 435);
			this.buttonPause.Name = "buttonPause";
			this.buttonPause.Size = new System.Drawing.Size(157, 46);
			this.buttonPause.TabIndex = 4;
			this.buttonPause.Text = "Pause";
			this.buttonPause.UseVisualStyleBackColor = false;
			this.buttonPause.Click += new System.EventHandler(this.ButtonPause_Click);
			// 
			// buttonStop
			// 
			this.buttonStop.BackColor = System.Drawing.Color.Red;
			this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonStop.Location = new System.Drawing.Point(617, 435);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(157, 46);
			this.buttonStop.TabIndex = 5;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = false;
			this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.DimGray;
			this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonExit.Location = new System.Drawing.Point(802, 435);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(157, 46);
			this.buttonExit.TabIndex = 6;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Multiselect = true;
			// 
			// MyMusicPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(1062, 524);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonPause);
			this.Controls.Add(this.buttonPlay);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Player);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MyMusicPlayer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer Player;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.Button buttonPlay;
		private System.Windows.Forms.Button buttonPause;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

