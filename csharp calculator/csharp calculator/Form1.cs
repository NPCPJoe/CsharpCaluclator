 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_calculator
{
    public partial class calculator : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false; 
        public calculator()
        {
            InitializeComponent();
        }
        // controls the button
        private void button_Click(object sender, EventArgs e)
        {
            if ((result2.Text == "0") ||(operation_pressed))
                result2.Clear();
            Button b = (Button)sender;
            result2.Text = result2.Text + b.Text;
        }
        //clears the calculator
        private void button34_Click(object sender, EventArgs e)
        {
            result2.Text = "0";
        }
        // detrrmines the operators used.
        private void operatorclick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result2.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operation_pressed = false;
            equation.Text = " ";
            switch (operation)
            {
                case "+":
                    result2.Text = (value + Double.Parse(result2.Text)).ToString();
                    break;
                case "-":
                    result2.Text = (value - Double.Parse(result2.Text)).ToString();
                    break;
                case "*":
                    result2.Text = (value * Double.Parse(result2.Text)).ToString();
                    break;
                case "/":
                    result2.Text = (value / Double.Parse(result2.Text)).ToString();
                    break;
                default:
                    break;
            }// end switch
            operation_pressed = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            result2.Clear();
            value = 0;

        }
    }
}
