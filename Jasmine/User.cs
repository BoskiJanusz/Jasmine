using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Jasmine
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {

            this.Hide();
            Start window = new Start();
            window.Closed += (s, args) => this.Close();
            window.Show();
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Application.StartupPath, @"XMLFILE1.XML");
            try
            {

            var dc = XDocument.Load(path);
            var specificUser = dc
              .Element("Users")
              .Elements("User")
              .Where(k => k.Element("IdPackage").Value == text_find.Text)
              .Single();


            lab_find_name.Text = specificUser.Element("Name").Value;
            lab_find_lastname.Text = specificUser.Element("LastName").Value;
            lab_find_status.Text = specificUser.Element("Status").Value;
            lab_find_date.Text = specificUser.Element("PackageDate").Value;
            lab_find_street.Text = specificUser.Element("Street").Value;

            }
            catch (Exception)
            {
                MessageBox.Show("Wrong!");
            }



        }
    }
}
