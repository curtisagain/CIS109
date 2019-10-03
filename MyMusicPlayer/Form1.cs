using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMusicPlayer
{
	public partial class MyMusicPlayer : Form
	{
		public MyMusicPlayer()
		{
			InitializeComponent();
		}

		private void ButtonBrowse_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog()==DialogResult.OK)
			{
				textBox1.Text = openFileDialog1.FileName;
			}

			Player.URL = textBox1.Text;
		}

		private void ButtonPlay_Click(object sender, EventArgs e)
		{
			Player.Ctlcontrols.play();
		}

		private void ButtonPause_Click(object sender, EventArgs e)
		{
			Player.Ctlcontrols.pause();
		}

		private void ButtonStop_Click(object sender, EventArgs e)
		{
			Player.Ctlcontrols.stop();
		}

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
