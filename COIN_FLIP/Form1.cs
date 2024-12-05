using COIN_FLIP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COIN_FLIP
{
    public partial class Form1 : Form
    {
        int heads = 0;
        int tails = 0;
        public Form1()
        {
            InitializeComponent();
        }

		private void CoinFlipButton_1_Click_1(object sender, EventArgs e)
		{
			Random coinFlip = new Random();
			int result = coinFlip.Next(1, 3);


			if (result == 1)
			{

				CoinImage_1.Image = Resources.Heads;
				CoinImage_1.SizeMode = PictureBoxSizeMode.StretchImage;
				heads++;
				HeadsLabel.Text = "Heads: " + heads.ToString();
			}

			else
			{

				CoinImage_1.Image = Resources.tail;
				CoinImage_1.SizeMode = PictureBoxSizeMode.StretchImage;
				tails++;
				TailsLabel.Text = "Tails: " + tails.ToString();
			}
		}
	}
}
