using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class FormCalculator : Form
	{
		Double resultValue = 0;
		string operatorClicked = "";
		bool isOperatorClicked = false;
		public FormCalculator()
		{
			InitializeComponent();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (ResultBox.Text == "0")
				ResultBox.Clear();
			ResultBox.Text = ResultBox.Text + "7";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (ResultBox.Text == "0")
				ResultBox.Clear();
			ResultBox.Text = ResultBox.Text + "9";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (ResultBox.Text == "0")
				ResultBox.Clear();
			ResultBox.Text = ResultBox.Text + "8";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (ResultBox.Text == "0")
				ResultBox.Clear();
			ResultBox.Text = ResultBox.Text + "4";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (ResultBox.Text == "0")
				ResultBox.Clear();
			ResultBox.Text = ResultBox.Text + "5";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (ResultBox.Text == "0")
				ResultBox.Clear();
			ResultBox.Text = ResultBox.Text + "6";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ResultBox.Text == "0")
				ResultBox.Clear();
			ResultBox.Text = ResultBox.Text + "1";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (ResultBox.Text == "0")
				ResultBox.Clear();
			ResultBox.Text = ResultBox.Text + "2";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (ResultBox.Text == "0")
				ResultBox.Clear();
			ResultBox.Text = ResultBox.Text + "3";
		}

		private void button0_Click(object sender, EventArgs e)
		{
			ResultBox.Text = ResultBox.Text + "0";
		}

		private void operator_click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			if (resultValue != 0)
			{
				buttonEqual.PerformClick();
				operatorClicked = button.Text;
				isOperatorClicked = true;
			}
			else
			{
				operatorClicked = button.Text;
				resultValue = Double.Parse(ResultBox.Text);
				isOperatorClicked = true;

			}
			operatorClicked = button.Text;
			resultValue = Double.Parse(ResultBox.Text);
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			ResultBox.Text = "0";
			resultValue = 0;
		}

		private void buttonEqual_Click(object sender, EventArgs e)
		{
			switch (operatorClicked)
			{
				case "+":
					ResultBox.Text = (resultValue + Double.Parse(ResultBox.Text)).ToString();
					break;
				case "-":
					ResultBox.Text = (resultValue - Double.Parse(ResultBox.Text)).ToString();
					break;
				case "/":
					ResultBox.Text = (resultValue / Double.Parse(ResultBox.Text)).ToString();
					break;
				case "*":
					ResultBox.Text = (resultValue * Double.Parse(ResultBox.Text)).ToString();
					break;


			}
		}
	}
}
