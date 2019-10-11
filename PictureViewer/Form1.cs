using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
	public partial class FormPictureViewer : Form
	{
		public FormPictureViewer()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			// Closes window
			this.Close();
		}

		private void BackgroundButton_Click(object sender, EventArgs e)
		{
			// Changes background color
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.BackColor = colorDialog1.Color;
			}
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			// Clears Picture
			pictureBox1.Image = null;
		}

		private void ShowButton_Click(object sender, EventArgs e)
		{
			// Loads picture from openfile dialog
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Load(openFileDialog1.FileName);
			}
		}

		private void StretchBox_CheckedChanged(object sender, EventArgs e)
		{
			// Changes the size of the image to the size of the picture windo
			if (StretchBox.Checked)
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			else
				pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
		}
	}
}
