using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_Picker
{
	public partial class Form1 : Form
	{
		// Random numGen = new Random();
		static Random rand = new Random();
		int one, two, three, four, five, six;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnRandom_Click(object sender, EventArgs e)
		{
			int one = rand.Next(1,45);
			int two = rand.Next(1,45);
			int three = rand.Next(1,45);
			int four = rand.Next(1,45);
			int five = rand.Next(1,45);
			int six = rand.Next(1,45);


			lblOne.Text = one.ToString();
			lblTwo.Text = two.ToString();
			lblThree.Text = three.ToString();
			lblFour.Text = four.ToString();
			lblFive.Text = five.ToString();
			lblSix.Text = six.ToString();
		}
	}
}
