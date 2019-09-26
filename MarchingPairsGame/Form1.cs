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
			"w", "w", "o", "o", "affle", "affle", "Curtis", "Curtis",
			"plate", "plate", "cutlery", "cutlery", "q", "q", "krab", "krab",
		};
		Label firstClicked, secondClicked;
		public FormMatchingPairsGame()
		{
			InitializeComponent();
			AssignIconsToSquares();
		}
		private void label_Click(object sender, EventArgs e)
		{
			if (firstClicked != null && secondClicked != null)
				return;

			Label clickedLabel = sender as Label;

			if (clickedLabel == null)
				return;
			if (clickedLabel.ForeColor == Color.Black)
				return;

			if (firstClicked == null)
			{
				firstClicked = clickedLabel;
				firstClicked.ForeColor = Color.Black;
				return;
			}

			secondClicked = clickedLabel;
			secondClicked.ForeColor = Color.Black;
			CheckForWinner();

			if (firstClicked.Text == secondClicked.Text)
			{
				firstClicked = null;
				secondClicked = null;
			}
			else
				timer1.Start();
		}

		private void CheckForWinner()
		{
			Label label;
			for (int i = 0; i < TableLayoutPanel.Controls.Count; i++)
			{
				label = TableLayoutPanel.Controls[i] as Label;

				if (label != null && label.ForeColor == label.BackColor)
					return;
			}

			MessageBox.Show("You beat my matching puzzle!");
			Close();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Stop();

			firstClicked.ForeColor = firstClicked.BackColor;
			secondClicked.ForeColor = secondClicked.BackColor;

			firstClicked = null;
			secondClicked = null;

		}

		

		private void AssignIconsToSquares()
		{

	
			Label iconLabel;
			int randomNumber;

			for (int i = 0; i < TableLayoutPanel.Controls.Count; i++)
				{
				if (TableLayoutPanel.Controls[i] is Label)
					iconLabel = (Label)TableLayoutPanel.Controls[i];
				else
					continue;


				randomNumber = random.Next(0, icons.Count);
				iconLabel.Text = icons[randomNumber];
				icons.RemoveAt(randomNumber);

			}
				
				
					
				
			
		}
	
	}
}
