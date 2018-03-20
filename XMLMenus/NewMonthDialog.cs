using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XMLMenus
{
    public partial class NewMonthDialog : Form
    {
        public NewMonthDialog()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int year;
            if ((monthComboBox.Text.Length == 0) || (yearTextBox.Text.Length == 0))
                MessageBox.Show("Please choose a month and enter a year");
            else if (!Int32.TryParse(yearTextBox.Text, out year))
                MessageBox.Show("Please enter a valid year");
            else
            {
                String filename = "Monthly Counts/" + monthComboBox.Text + yearTextBox.Text + "MealCount.xml";
                if(!File.Exists(filename)) {
                createFile(monthComboBox.Text, year);
                this.Close();
                }
                else MessageBox.Show(filename + " already exists.");
            }

        }
        private void createFile(String month, int year)
        {
            //MessageBox.Show(month + " " + year.ToString());
            XmlWriter writer = XmlWriter.Create("Monthly Counts/" + month + year.ToString() + "MealCount.xml");
            writer.WriteStartDocument();

            writer.WriteStartElement("month");
            writer.WriteAttributeString("month", month);
            writer.WriteAttributeString("year", year.ToString());
            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
