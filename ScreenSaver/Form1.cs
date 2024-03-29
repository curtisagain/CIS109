﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{
	public partial class FormScreenSaver : Form
	{
		List<Image> BGImages = new List<Image>();
		List<BritPic> BritPics = new List<BritPic>();
		Random rand = new Random();

		class BritPic
		{
			public int Picnum;
			public float X;
			public float Y;
			public float Speed;
		}

		public FormScreenSaver()
		{
			InitializeComponent();
		}

		private void FormScreenSaver_KeyDown(object sender, KeyEventArgs e)
		{
			Close();
		}

		private void FormScreenSaver_Load(object sender, EventArgs e)
		{
			string[] images = System.IO.Directory.GetFiles("pics");

			foreach (string image in images)
			{
				BGImages.Add(new Bitmap(image));
			}

			for (int i = 0; i < 3; ++i)
			{
				BritPic mp = new BritPic();
				mp.Picnum = i % BGImages.Count;
				mp.X = rand.Next(0, Width);
				mp.X = rand.Next(0, Height);
				BritPics.Add(mp);
			}
		}

		private void ScreenSaverTimer_Tick(object sender, EventArgs e)
		{
			Refresh();
		}

		private void FormScreenSaver_Paint(object sender, PaintEventArgs e)
		{
			foreach (BritPic bp in BritPics)
			{
				e.Graphics.DrawImage(BGImages[bp.Picnum], bp.X, bp.Y);
				bp.X -= 2;

				if (bp.X < -250)
				{
					bp.X = Width + rand.Next(20, 100);
				}
			}
		}
	}
}
