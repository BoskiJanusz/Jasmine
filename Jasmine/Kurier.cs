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
    public partial class Kurier : Form
    {
        public Kurier()
        {
            InitializeComponent();
        }

        private void button_add_new_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Package window = new Add_Package();
            window.Closed += (s, args) => this.Close();
            window.Show();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Package window = new Edit_Package();
            window.Closed += (s, args) => this.Close();
            window.Show();
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
            
