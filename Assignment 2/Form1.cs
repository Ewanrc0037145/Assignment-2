using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //declare resistor values
            double resistor1, resistor2;

            //read values from textboxes


            //for next lesson add pass code from forces 1 to use tex box
            try
            {
                resistor1 = 
                resistor2 = ;
            }
            catch
            {
                //show message when nothing is typed into the texboxes
                MessageBox.Show("type a number in both resistor boxes!");
                resistor1 = 0.0;
                resistor2 = 0.0;
            }  

            //calculate the total reistance
            double resistance = resistor1 + resistor2;

            //display total resitance
            label1.Text = " total resistance = " + resistance + "ohms";

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //declare resistor values
            double resistor3, resistor4;

            //read each textbox value
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
