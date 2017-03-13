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

namespace WindowsFormsApp
{
    public partial class customUI : Form
    {
        private string name;
        ArrayList nameList = new ArrayList();
        List<String> names = new List<string>(); 
        public customUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            name = NameTextBox.Text;
            NameTextBox.Text = String.Empty;
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = String.Empty;
            foreach (var list in nameList)
            {
                allNameTextBox.Text = Convert.ToString(nameList);    
            }
            

            totalTextBox.Text = Convert.ToString(nameList.Count);
        }
    }
}
