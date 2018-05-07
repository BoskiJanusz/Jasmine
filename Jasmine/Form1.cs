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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            populateData();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Add_Or_Edit window = new Add_Or_Edit();
            window.Show();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

            string name = Convert.ToString(selectedRow.Cells["Name"].Value);
            string lastName = Convert.ToString(selectedRow.Cells["LastName"].Value);
            string street = Convert.ToString(selectedRow.Cells["Street"].Value);

           
            string path = System.IO.Path.Combine(Application.StartupPath, @"XMLFILE1.XML");
            XDocument doc = XDocument.Load(path);
            var specificUser = doc
                  .Element("Users")
                  .Elements("User")
                  .Where(k => k.Element("Name").Value == name && k.Element("LastName").Value == lastName && k.Element("Street").Value == street)
                  .Single();
            //foreach (XmlNode child in node.ChildNodes)
            //{
            //    node.ParentNode.AppendChild(child);
            //}
            specificUser.Remove();
            //specificUser.ParentNode.RemoveChild(specificUser);
            doc.Save(path);

            populateData();

            //XmlDocument doc = new XmlDocument();
            //doc.Load(@"C:\Users\Boski_Janusz\source\repos\Jasmine\Jasmine\XMLFILE1.XML");

            //XmlElement el = (XmlElement)doc.SelectSingleNode("/Users/User[Name="+ dataGridView1.CurrentCell.Value.ToString() + "]");
            //if (el != null) { el.ParentNode.RemoveChild(el); }

            //foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            //{
            //    dataGridView1.Rows.RemoveAt(item.Index);
            //}
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
                        
                    };
            dataGridView1.DataSource = q.ToList();
        }

        private void Edit_baton_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[currentRow];
             string name = Convert.ToString(selectedRow.Cells["Name"].Value);
            string lastname = Convert.ToString(selectedRow.Cells["LastName"].Value);
            string street = Convert.ToString(selectedRow.Cells["Street"].Value);

            Add_Or_Edit window = new Add_Or_Edit(name, lastname, street);
            window.Show();
            populateData();

           

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            populateData();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login window = new Login();
            window.Closed += (s, args) => this.Close();
            window.Show();
        }
    }
    }
