using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailPractice
{
    public partial class Practice : Form
    {
        ArrayList nameList = new ArrayList();
        private int lastNumber, sum;
        public Practice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameList.Add(nameTextBox.Text);
            nameTextBox.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            allNameListBox.Items.Clear();
            foreach (var names in nameList)
            {
                allNameListBox.Items.Add(names);

            }
            
            
            totalTextBox.Text = Convert.ToString(nameList.Count);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            lastNumber = Convert.ToInt32(numberTextBox.Text);
            numberTextBox.Text = String.Empty;
        }

        private void showAllNumberButton_Click(object sender, EventArgs e)
        {
            numberListBox.Items.Clear();
            for (int i = 1; i <= lastNumber; i++)
            {
                numberListBox.Items.Add(i);
                sum += i;
            }
            sumTextBox.Text = sum.ToString();
        }
    }
}
