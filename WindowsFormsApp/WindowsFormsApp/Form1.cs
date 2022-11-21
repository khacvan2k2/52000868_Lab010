using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String user = txtUser.Text;
            String pass = txtPass.Text;

            if (user == "")
            {
                MessageBox.Show("Please enter your username");
                txtUser.Focus();
            }
            else if (pass == "")
            {
                MessageBox.Show("Please enter your password");
                txtPass.Focus();
            }
            else
            {
                MessageBox.Show("Welcome");
            }

            // TODO: kiem tra va lam tuong tu cho textbox password
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // TODO: clear all textboxes
            // and focus on the username textbox
            txtUser.Text = "";
            txtPass.Text = "";
        }

        
    }
}
