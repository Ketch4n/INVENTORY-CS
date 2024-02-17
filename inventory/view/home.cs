using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory.view
{
    public partial class home : Form
    {

        login login = new login();
        public home()
        {
            InitializeComponent();
            tab.ItemSize = new Size(0, 1); // Hide the tab names
            tab.SizeMode = TabSizeMode.Fixed; // Prevent dynamic resizing
            this.FormClosing += homeClosing;

        }
  
        private void homeClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
               
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else {
                    login.Show();
                    this.Hide();
                }
            }
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tab.SelectedIndex = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tab.SelectedIndex = 1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tab.SelectedIndex = 2;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
