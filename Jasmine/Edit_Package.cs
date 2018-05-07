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
    public partial class Edit_Package : Form
    {

        public Edit_Package()
        {
            InitializeComponent();
            populateData();
        }


        private void button1_Click(object sender, EventArgs e)
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
        private void populateData()
        {
            string path = System.IO.Path.Combine(Application.StartupPath, @"XMLFILE1.XML");
            XDocument xmlDoc = XDocument.Load(path);
            var q = from c in xmlDoc.Root.Descendants("User")
                    select new 
                    {
                        Status = c.Element("Status").Value,
                        Id = c.Element("IdPackage").Value,
                        Data = c.Element("PackageDate").Value

                    };
            dataGridView1.DataSource = q.ToList();
            
            
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[currentRow];
            string Status = Convert.ToString(selectedRow.Cells["Status"].Value);
            string Id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string Data = Convert.ToString(selectedRow.Cells["Data"].Value);
            
            
            Add_Or_Edit_Package window = new Add_Or_Edit_Package(Status, Id, Data);
            window.Show();
            populateData();
        }

        private void Edit_Package_Activated(object sender, EventArgs e)
        {
            populateData();
        }
    }
}         
