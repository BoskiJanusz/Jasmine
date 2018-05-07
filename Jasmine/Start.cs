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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login window = new Login();
            window.Closed += (s, args) => this.Close();
            window.Show();
        }

        private void button_courier_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kurier window = new Kurier();
            window.Closed += (s, args) => this.Close();
            window.Show();
        }

        private void button_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            User window = new User();
            window.Closed += (s, args) => this.Close();
            window.Show();
        }
    }
}
