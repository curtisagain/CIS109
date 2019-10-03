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
			this.Browse = new System.Windows.Forms.Button();
			this.Play = new System.Windows.Forms.Button();
			this.Pause = new System.Windows.Forms.Button();
			this.Stop = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.Button();
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
			this.textBox1.Location = new System.Drawing.Point(0, 264);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(109, 32);
			this.textBox1.TabIndex = 1;
			// 
			// Browse
			// 
			this.Browse.BackColor = System.Drawing.Color.Coral;
			this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Browse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Browse.Location = new System.Drawing.Point(57, 315);
			this.Browse.Name = "Browse";
			this.Browse.Size = new System.Drawing.Size(157, 46);
			this.Browse.TabIndex = 2;
			this.Browse.Text = "Browse";
			this.Browse.UseVisualStyleBackColor = false;
			// 
			// Play
			// 
			this.Play.BackColor = System.Drawing.Color.Green;
			this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Play.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Play.Location = new System.Drawing.Point(252, 315);
			this.Play.Name = "Play";
			this.Play.Size = new System.Drawing.Size(157, 46);
			this.Play.TabIndex = 3;
			this.Play.Text = "Play";
			this.Play.UseVisualStyleBackColor = false;
			// 
			// Pause
			// 
			this.Pause.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Pause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Pause.Location = new System.Drawing.Point(442, 315);
			this.Pause.Name = "Pause";
			this.Pause.Size = new System.Drawing.Size(157, 46);
			this.Pause.TabIndex = 4;
			this.Pause.Text = "Pause";
			this.Pause.UseVisualStyleBackColor = false;
			// 
			// Stop
			// 
			this.Stop.BackColor = System.Drawing.Color.Red;
			this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Stop.Location = new System.Drawing.Point(628, 315);
			this.Stop.Name = "Stop";
			this.Stop.Size = new System.Drawing.Size(157, 46);
			this.Stop.TabIndex = 5;
			this.Stop.Text = "Stop";
			this.Stop.UseVisualStyleBackColor = false;
			this.Stop.Click += new System.EventHandler(this.Button3_Click);
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.DimGray;
			this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Exit.Location = new System.Drawing.Point(824, 315);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(157, 46);
			this.Exit.TabIndex = 6;
			this.Exit.Text = "Exit";
			this.Exit.UseVisualStyleBackColor = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MyMusicPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(1062, 373);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.Stop);
			this.Controls.Add(this.Pause);
			this.Controls.Add(this.Play);
			this.Controls.Add(this.Browse);
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
		private System.Windows.Forms.Button Browse;
		private System.Windows.Forms.Button Play;
		private System.Windows.Forms.Button Pause;
		private System.Windows.Forms.Button Stop;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

