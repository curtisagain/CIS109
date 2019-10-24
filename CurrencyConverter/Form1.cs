using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
	public partial class currencyForm : Form
	{
		public currencyForm()
		{
			InitializeComponent();
		}

		private void ButtonConverter_Click(object sender, EventArgs e)
		{
			//API is down for google converter
			webBrowser1.Navigate("https://www.google.co.uk/finance/converter");

		}
	}
}
