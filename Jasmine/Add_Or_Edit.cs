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
    public partial class Add_Or_Edit : Form
    {
        public Add_Or_Edit()
        {
            InitializeComponent();
            add = true;
        }

        bool add;
        string previousName;
        string previousLastName;
        string previousSteet;

        public Add_Or_Edit(string name, string lastName, string street)
        {
            InitializeComponent();
            text_name.Text = name;
            text_lastname.Text = lastName;
            text_street.Text = street;
            
            previousLastName = lastName;
            previousName = name;
            previousSteet = street;

            add = false;
        }

        private void Add_edited_baton_Click(object sender, EventArgs e)
        {
            if(add)
            {
                if (text_name.Text != "" && text_lastname.Text != "" && text_street.Text != "")
                {
                    string path = System.IO.Path.Combine(Application.StartupPath, @"XMLFILE1.XML");
                    XmlDocument doc = new XmlDocument();
                    doc.Load(path);
                    XmlNode User = doc.CreateElement("User");                    
                    XmlNode name = doc.CreateElement("Name");
                    name.InnerText = text_name.Text;
                    User.AppendChild(name);
                    XmlNode lastname = doc.CreateElement("LastName");
                    lastname.InnerText = text_lastname.Text;
                    User.AppendChild(lastname);
                    XmlNode street = doc.CreateElement("Street");
                    street.InnerText = text_street.Text;
                    User.AppendChild(street);
                    /////PACKAGE
                    
                    XmlNode status = doc.CreateElement("Status");
                    status.InnerText = "0";
                    User.AppendChild(status);
                    XmlNode id_package = doc.CreateElement("IdPackage");
                    id_package.InnerText = "0";
                    User.AppendChild(id_package);
                    XmlNode date = doc.CreateElement("PackageDate");
                    date.InnerText = "0";
                    User.AppendChild(date);

                    doc.DocumentElement.AppendChild(User);
                    doc.Save(path);
                }
                else MessageBox.Show("WRONG!");
                text_name.Text = "";
                text_lastname.Text = "";
                text_street.Text = "";
            }
            else
            {
                string path = System.IO.Path.Combine(Application.StartupPath, @"XMLFILE1.XML");
               
                var dc = XDocument.Load(path);
                var specificUser = dc
                  .Element("Users")
                  .Elements("User")
                  .Where(k => k.Element("Name").Value == previousName && k.Element("LastName").Value == previousLastName && k.Element("Street").Value == previousSteet)
                  .Single();

                specificUser.Element("Name").Value = text_name.Text;
                specificUser.Element("LastName").Value = text_lastname.Text;
                specificUser.Element("Street").Value = text_street.Text;

                dc.Save(path);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

