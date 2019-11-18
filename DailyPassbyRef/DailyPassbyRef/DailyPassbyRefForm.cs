using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyPassbyRef
{
    public partial class frmDailyPassbyRef : Form
    {
        public frmDailyPassbyRef()
        {
            InitializeComponent();
        }

        private void ChangeCard(ref PictureBox aPictureBox, int cardNumber )
        {
            if (cardNumber == 1)
            {
                aPictureBox.Image = Properties.Resources.Front;
            }
            else if (cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources.JC;
            }
            else if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources.JD; 
            }
        }

        private void PicCard_Click(object sender, EventArgs e)
        {
            // declare local constants and variables
            const int MAX_NUM_CARDS = 13;
            int aRandomNumber;

            // get a random number between 1 and the maximum 
            aRandomNumber = randNumberGenerator.Next(1, MAX_NUM_CARDS + 1);

            // get the card depending on the random selection 
            ChangeCard(ref this.picCard, aRandomNumber); 
        }
    }
}
