using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertToFarenTaishaunJohnson
{
    public partial class ConvertToFarenForm : Form
    {
        public ConvertToFarenForm()
        {
            InitializeComponent();
        }

        public void ConvertToFar(double celcius)
        {
            // declare the variables
            double Farenheit;

            // Convert the celcius to farenheit 
            Farenheit = celcius * (double)9 / (double)5 + 32;

            // Display a message box with celcius converted to Farenheit
            MessageBox.Show( "The degrees celcius is: " + celcius +  " Which means the Farenheit is: " + Farenheit + " degrees Farenheit ");
        }

        private void BtnConvertToFar_Click(object sender, EventArgs e)
        {
            // declare the variables 
            double userCelcius;

            // convert the input celcius from a text to a double 
            userCelcius = Convert.ToDouble(this.txtDegreesC.Text);

            // Call the function to convert from celcis to farenheit
            this.ConvertToFar(userCelcius);
        }
    }
}
