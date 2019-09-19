/*Curtis Aloia
 * Reno Technology Academmy
 * CIS109: Coding in C# for Imbedded Systems
 * Udemy: 17 Beginner C# Walkthrough Projects Step By Step
 * Project 1 : Create a Matching Pairs Icon Image Game
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarchingPairsGame
{
	public partial class FormMatchingPairsGame : Form
	{
		Random random = new Random();
		List<string> icons = new List<string>()
		{
			"w", "w", "zoop", "zoop", "affle", "affle", "Curtis", "Curtis",
			"plate", "plate", "cutlery", "cutlery", "q", "q", "krab", "krab",
		};
		public FormMatchingPairsGame()
		{
			InitializeComponent();
			AssignIconsToSquares();
		}
		private void AssignIconsToSquares()
		{

			foreach (Control control in TableLayoutPanel.Controls)
			{ 
				Label iconLabel = control as Label;

				if (iconLabel != null)
				{
					int randomNumber = random.Next(icons.Count);
					iconLabel.Text = icons[randomNumber];
					iconLabel.ForeColor = iconLabel.BackColor;
					icons.RemoveAt(randomNumber);
				}
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
