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
    public partial class NewDay : Form
    {
        public NewDay()
        {
            InitializeComponent();
        }

        private void NewDay_Load(object sender, EventArgs e)
        {
            fileNameInfoLabel.Text = "Adding data to " + this.Tag;
            populateComboBox();
        }

        private void populateComboBox()
        {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("menus.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = loadList.SelectSingleNode("//a:menus", mgr);
            XmlNodeList menus = loadList.SelectNodes("//a:menus/menu", mgr);
            foreach (XmlNode menu in menus)
            {
                menuComboBox.Items.Add(menu.Attributes["id"].Value + ": " + menu.Attributes["name"].Value);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void menuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = getMenuId();
            populateMenuMeals(id.ToString());
            //MessageBox.Show("ID: " + id.ToString());

        }

        private int getMenuId()
        {
            char[] delimiters = {':', ' ' };
            String[] split = menuComboBox.Text.Split(delimiters);
            int id = Int32.Parse(split[0]);
            return id;
        }
        private void populateMenuMeals(String id)
        {
            mealsListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("menus.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNodeList mealIds = loadList.SelectNodes("//a:menus/menu[@id='" + id + "']/meals/meal", mgr);

            foreach (XmlNode mealId in mealIds)
            {
                addMealToMenuList(mealId.Attributes["id"].Value); //id as text of the item
            }
        }
        private void addMealToMenuList(String id)
        {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("meals.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode meal = loadList.SelectSingleNode("//a:meals/meal[@id='" + id + "']", mgr);

            ListViewItem lvItem = new ListViewItem();

            lvItem.Text = id;
            lvItem.SubItems.Add(meal.Attributes["name"].Value);
            lvItem.SubItems.Add(meal.Attributes["type"].Value);

            mealsListView.Items.Add(lvItem);
        }

        private void mealsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mealsListView.SelectedItems.Count > 0)
            {
                populateMealItems(mealsListView.SelectedItems[0].Text);
            }
        }
        private void populateMealItems(String id)
        {
            menuItemsListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("meals.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNodeList itemIds = loadList.SelectNodes("//a:meals/meal[@id='" + id + "']/menuItems/menuItem", mgr);

            foreach (XmlNode itemId in itemIds)
            {
                addMealItemToList(itemId.Attributes["id"].Value); //id as text of the item
            }

        }
        private void addMealItemToList(String id)
        {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("menuItems.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode item = loadList.SelectSingleNode("//a:menuItems/menuItem[@id='" + id + "']", mgr);

            ListViewItem lvItem = new ListViewItem();

            lvItem.Text = id;
            lvItem.SubItems.Add(item.Attributes["name"].Value);
            lvItem.SubItems.Add(item.ChildNodes[1].InnerText);
            lvItem.SubItems.Add(item.ChildNodes[1].Attributes["units"].Value);

            menuItemsListView.Items.Add(lvItem);
        }

        private void addDayButton_Click(object sender, EventArgs e)
        {
            //lots of input validation needed here
            XmlDocument editDoc = new XmlDocument();
            editDoc.Load("Monthly Counts/" + this.Tag);


            var mgr = new XmlNamespaceManager(editDoc.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = editDoc.SelectSingleNode("//a:month", mgr);

            XmlNode day = editDoc.CreateElement("day");

            XmlAttribute attribute = editDoc.CreateAttribute("date");
            attribute.Value = currentDateTimePicker.Value.ToString("MM/dd/yyyy");
            day.Attributes.Append(attribute);

            attribute = editDoc.CreateAttribute("menuID");
            attribute.Value = getMenuId().ToString();
            day.Attributes.Append(attribute);

            XmlNode meal = editDoc.CreateElement("breakfast");

            attribute = editDoc.CreateAttribute("free");
            attribute.Value = breakfastFreeTextBox.Text;
            meal.Attributes.Append(attribute);

            attribute = editDoc.CreateAttribute("reduced");
            attribute.Value = breakfastReducedTextBox.Text;
            meal.Attributes.Append(attribute);

            attribute = editDoc.CreateAttribute("paid");
            attribute.Value = breakfastPaidTextBox.Text;
            meal.Attributes.Append(attribute);

            attribute = editDoc.CreateAttribute("nonReimburseable");
            attribute.Value = breakfastNonReimburseableTextBox.Text;
            meal.Attributes.Append(attribute);

            day.AppendChild(meal);

            meal = editDoc.CreateElement("lunch");

            attribute = editDoc.CreateAttribute("free");
            attribute.Value = lunchFreeTextBox.Text;
            meal.Attributes.Append(attribute);

            attribute = editDoc.CreateAttribute("reduced");
            attribute.Value = lunchReducedTextBox.Text;
            meal.Attributes.Append(attribute);

            attribute = editDoc.CreateAttribute("paid");
            attribute.Value = lunchPaidTextBox.Text;
            meal.Attributes.Append(attribute);

            attribute = editDoc.CreateAttribute("nonReimburseable");
            attribute.Value = lunchNonReimburseableTextBox.Text;
            meal.Attributes.Append(attribute);

            day.AppendChild(meal);

            meal = editDoc.CreateElement("snack");

            attribute = editDoc.CreateAttribute("free");
            attribute.Value = snackFreeTextBox.Text;
            meal.Attributes.Append(attribute);

            attribute = editDoc.CreateAttribute("reduced");
            attribute.Value = snackReducedTextBox.Text;
            meal.Attributes.Append(attribute);

            attribute = editDoc.CreateAttribute("paid");
            attribute.Value = snackPaidTextBox.Text;
            meal.Attributes.Append(attribute);

            attribute = editDoc.CreateAttribute("nonReimburseable");
            attribute.Value = snackNonReimburseableTextBox.Text;
            meal.Attributes.Append(attribute);

            day.AppendChild(meal);

            root.AppendChild(day);
            editDoc.Save("Monthly Counts/" + this.Tag);

            this.Close();

        }
    }
}
