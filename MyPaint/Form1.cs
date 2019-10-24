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
	}
}
