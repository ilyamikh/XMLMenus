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
using System.Xml.Serialization;

namespace XMLMenus
{
    public partial class NewWeek : Form
    {
        public List<ClassMealCount> classroomList = new List<ClassMealCount>();

        public NewWeek()
        {
            InitializeComponent();
        }

        private void NewWeek_Load(object sender, EventArgs e)
        {
            filenameInfoLabel.Text = "Adding weekly meal count data to " + this.Tag;
            
            populateComboBoxes();
        }
        private void populateComboBoxes() {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("menus.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = loadList.SelectSingleNode("//a:menus", mgr);
            XmlNodeList menus = loadList.SelectNodes("//a:menus/menu", mgr);
            foreach (XmlNode menu in menus)
            {
                mondayMenuComboBox.Items.Add(menu.Attributes["name"].Value + ", " + menu.Attributes["id"].Value);
                tuesdayMenuComboBox.Items.Add(menu.Attributes["name"].Value + ", " + menu.Attributes["id"].Value);
                wednesdayMenuComboBox.Items.Add(menu.Attributes["name"].Value + ", " + menu.Attributes["id"].Value);
                thursdayMenuComboBox.Items.Add(menu.Attributes["name"].Value + ", " + menu.Attributes["id"].Value);
                fridayMenuComboBox.Items.Add(menu.Attributes["name"].Value + ", " + menu.Attributes["id"].Value);
            }
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            //add input validation to this function
            //it must check that all dates and menus were picked
            AddGroup newGroup = new AddGroup();
            newGroup.ShowDialog();
        }
    }
}
