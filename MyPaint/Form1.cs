﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
	public partial class myPaintForm : Form
	{
		Bitmap bmp = new Bitmap(1024, 768);
		Pen p = new Pen(Color.Black, 5);
		bool drawing = false;

		public myPaintForm()
		{
			InitializeComponent();
		}

		private void MyPaintForm_MouseClick(object sender, MouseEventArgs e)
		{
			if (drawing)
				drawing = false;
			else
				drawing = true;
		}

		private void MyPaintPictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (drawing)
			{
				Graphics g = Graphics.FromImage(bmp);
				g.DrawEllipse(p, e.X, e.Y, 3, 1);
				myPaintPictureBox.Image = bmp;
			}
		}

		private void RedButton_Click(object sender, EventArgs e)
		{
			p.Color = Color.Red;
		}

		private void BlueButton_Click(object sender, EventArgs e)
		{
			p.Color = Color.Blue;
		}

		private void GreenButton_Click(object sender, EventArgs e)
		{
			p.Color = Color.Green;
		}

		private void PurpleButton_Click(object sender, EventArgs e)
		{
			p.Color = Color.Purple;
		}

		private void LimeButton_Click(object sender, EventArgs e)
		{
			p.Color = Color.Lime;
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "JPeg Image| *.jpg|Bitmap Image *.bmp";
			saveFileDialog1.Title = "Save an Image File";
			saveFileDialog1.ShowDialog();

			if (saveFileDialog1.FileName != "")
			{
				System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
				switch (saveFileDialog1.FilterIndex)
				{
					case 1:
						this.myPaintPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
						break;
					case 2:
						this.myPaintPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
						break;
				}
			}
		}
	}
}
