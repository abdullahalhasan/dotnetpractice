using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private String name, contact, address;
        public Form1()
        {
            InitializeComponent();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            name = FullNameTextBox.Text;
            contact = ContactTextBox.Text;
            address = AddressTextBox.Text;

            FullNameTextBox.Text = String.Empty;
            ContactTextBox.Text = String.Empty;
            AddressTextBox.Text = String.Empty;
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Text = name;
            FullNameTextBox.Show();

            ContactTextBox.Text = String.Empty;
            AddressTextBox.Text = String.Empty;
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            ContactTextBox.Text = contact;
            ContactTextBox.Show();

            FullNameTextBox.Text = String.Empty;
            AddressTextBox.Text = String.Empty;
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            AddressTextBox.Text = address;
            AddressTextBox.Show();

            FullNameTextBox.Text = String.Empty;
            ContactTextBox.Text = String.Empty;
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Text = name;
            ContactTextBox.Text = contact;
            AddressTextBox.Text = address;

            FullNameTextBox.Show();
            ContactTextBox.Show();
            AddressTextBox.Show();
        }
    }
}
