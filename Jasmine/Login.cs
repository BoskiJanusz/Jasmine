using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jasmine
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_baton_Click(object sender, EventArgs e)
        {

            
            if (text_login.Text == "admin" && text_password.Text == "admin")
            {
                
                this.Hide();
                Form1 window = new Form1();
                window.Closed += (s, args) => this.Close();
                window.Show();       
            }
            else MessageBox.Show("Wrong!");
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {
            text_password.PasswordChar = '*';
            
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start window = new Start();
            window.Closed += (s, args) => this.Close();
            window.Show();
        }
    }
}
