/*Curtis Aloia
 * Reno Technology Academmy
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
			"C", "C", "zoop", "zoop", "waffle", "waffle", "Curtis", "Curtis",
			"plate", "plate", "cutlery", "cutlery", "q", "q", "krab", "krab",
		};
		public FormMatchingPairsGame()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
