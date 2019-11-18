using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWalkingManTaishaun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GeneratePictureBoxes()
        {
            // generate each of the picture boxes on the form 
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(464, 358);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // reveal the instructions
            this.lblInstructions.Show();

            // generate the picture boxes with their event listeners.
            GeneratePicturesBoxes();
        }
            
        private void GeneratePictureBox(int x, int y)
        {
            // dynamically generate a new picture box and a new point at the given location (x,y)
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            // 
        }
    }
}
