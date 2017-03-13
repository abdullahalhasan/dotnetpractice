using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class Form1 : Form
    {
        private int firstNumber, SecondNumber, result;
        double divResult;
        public Form1()
        {
            InitializeComponent();
            resultLebel.Text = String.Empty;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            SecondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            result = firstNumber + SecondNumber;

            resultLebel.Text = Convert.ToString(result);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            SecondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            if (SecondNumber > firstNumber)
            {
                result =  SecondNumber - firstNumber ;
            }
            else
            {
                result = firstNumber - SecondNumber;    
            }


            resultLebel.Text = Convert.ToString(result);
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            SecondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            result = firstNumber * SecondNumber;

            resultLebel.Text = Convert.ToString(result);
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            
            firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            SecondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            divResult =(double) firstNumber / SecondNumber;

            resultLebel.Text = Convert.ToString(divResult);
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void resultLebel_Click(object sender, EventArgs e)
        {

        }
    }
}
