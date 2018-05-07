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
    public partial class Add_Or_Edit_Package : Form
    {
        string previousStatus;
        string previousId;
        string previousData;

        public Add_Or_Edit_Package(string Status, string Id, string Data)
        {
            InitializeComponent();
            text_status.Text = Status;
            text_id.Text = Id;
            text_data.Text = Data;

            previousStatus = Status;
            previousId = Id;
            previousData = Data;
          
        }

        private void Add_or_edit_package_baton_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Application.StartupPath, @"XMLFILE1.XML");
            var dc = XDocument.Load(path);
            var specificUser = dc
              .Element("Users")
              .Elements("User")
              .Where(k => k.Element("Status").Value == previousStatus && k.Element("IdPackage").Value == previousId && k.Element("PackageDate").Value == previousData)
              .Single();

            specificUser.Element("Status").Value = text_status.Text;
            specificUser.Element("IdPackage").Value = text_id.Text;
            specificUser.Element("PackageDate").Value = text_data.Text;

            dc.Save(path);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
