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
    public partial class Add_Package : Form
    {
        public Add_Package()
        {
            InitializeComponent();
            populateData();
        }

        private void Add_Package_button_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Application.StartupPath, @"XMLFILE1.XML");
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[currentRow];
            string Status = Convert.ToString(selectedRow.Cells["Status"].Value);

            var dc = XDocument.Load(path);
            var specificUser = dc
              .Element("Users")
              .Elements("User")
              .Where(k => k.Element("Name").Value == Convert.ToString(selectedRow.Cells["Name"].Value)
                && k.Element("LastName").Value == Convert.ToString(selectedRow.Cells["LastName"].Value)
                && k.Element("Status").Value == Convert.ToString(selectedRow.Cells["Status"].Value)
                && k.Element("IdPackage").Value == Convert.ToString(selectedRow.Cells["Id"].Value)
                && k.Element("PackageDate").Value == Convert.ToString(selectedRow.Cells["Data_dostarczenia"].Value))
              .Single();

            if (Status == "0")
            {
                Random rnd = new Random();
                int pacdat = rnd.Next(1, 10000);
                specificUser.Element("Status").Value = "Zamówienie złożone";
                specificUser.Element("IdPackage").Value = Convert.ToString(pacdat);
                specificUser.Element("PackageDate").Value = "03.03.2018";
                dc.Save(path);
                populateData();
            }
            else MessageBox.Show("Wrong!");

        }

        private void button_edit_package_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Package window = new Edit_Package();
            window.Closed += (s, args) => this.Close();
            window.Show();
        }

        private void button_delete_package_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Application.StartupPath, @"XMLFILE1.XML");
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[currentRow];
            string Status = Convert.ToString(selectedRow.Cells["Status"].Value);

            var dc = XDocument.Load(path);
            var specificUser = dc
              .Element("Users")
              .Elements("User")
              .Where(k => k.Element("Name").Value == Convert.ToString(selectedRow.Cells["Name"].Value)
                && k.Element("LastName").Value == Convert.ToString(selectedRow.Cells["LastName"].Value)
                && k.Element("Status").Value == Convert.ToString(selectedRow.Cells["Status"].Value)
                && k.Element("IdPackage").Value == Convert.ToString(selectedRow.Cells["Id"].Value)
                && k.Element("PackageDate").Value == Convert.ToString(selectedRow.Cells["Data_dostarczenia"].Value))
              .Single();
            specificUser.Element("Status").Value = "0";
            specificUser.Element("IdPackage").Value = "0";
            specificUser.Element("PackageDate").Value = "0";
            dc.Save(path);
            populateData();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;

            if (text_search_lastname.Text == "" && text_search_name.Text == "") MessageBox.Show("WRONG!");
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {


                    if (row.Cells[0].Value.ToString().Equals(text_search_name.Text) || row.Cells[1].Value.ToString().Equals(text_search_lastname.Text))
                    {
                        rowIndex = row.Index;
                        dataGridView1.Rows[rowIndex].Selected = true;
                        break;
                        
                    }

                }
            }
        }
        private void populateData()
        {

            string path = System.IO.Path.Combine(Application.StartupPath, @"XMLFILE1.XML");
            XDocument xmlDoc = XDocument.Load(path);
            var q = from c in xmlDoc.Root.Descendants("User")
                    
                    
                    select new
                    {
                        Name = c.Element("Name").Value,
                        LastName = c.Element("LastName").Value,
                        Street = c.Element("Street").Value,
                        Status = c.Element("Status").Value,
                        Id = c.Element("IdPackage").Value,
                        Data_dostarczenia = c.Element("PackageDate").Value

                    };
            dataGridView1.DataSource = q.ToList();
           

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kurier window = new Kurier();
            window.Closed += (s, args) => this.Close();
            window.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
