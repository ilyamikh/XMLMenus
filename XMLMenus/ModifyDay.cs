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
    public partial class ModifyDay : Form
    {
        public ModifyDay()
        {
            InitializeComponent();
        }

        private void ModifyDay_Load(object sender, EventArgs e)
        {
            String passedInfo = Tag.ToString();
            String[] dayInfo = passedInfo.Split(',');
            
            String filenameText = dayInfo[0];
            DateTime date = DateTime.Parse(dayInfo[1]);

            fileNameInfoLabel.Text = "Modifying data in " + filenameText;
            currentDateTimePicker.Value = date;

            //populateComboBox();
            populateData(filenameText, dayInfo[1]);

        }

        private void populateData(String filename, String rawDate)
        {
            XmlDocument loadFile = new XmlDocument();
            loadFile.Load("Monthly Counts/" + filename);

            var mgr = new XmlNamespaceManager(loadFile.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode day = loadFile.SelectSingleNode("//a:month/day[@date='" + rawDate+ "']", mgr);

            menuComboBox.Text = populateComboBox(day.Attributes["menuID"].Value);
            loadCountData(rawDate, filename);

            int id = getMenuId();
            populateMenuMeals(id.ToString());


        }

        private String populateComboBox(String picked)
        {
            String menuName = picked + ": ";

            XmlDocument loadList = new XmlDocument();
            loadList.Load("menus.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = loadList.SelectSingleNode("//a:menus", mgr);
            XmlNodeList menus = loadList.SelectNodes("//a:menus/menu", mgr);
            foreach (XmlNode menu in menus)
            {
                menuComboBox.Items.Add(menu.Attributes["id"].Value + ": " + menu.Attributes["name"].Value);
                if (Int32.Parse(menu.Attributes["id"].Value) == Int32.Parse(picked))
                {
                    menuName += menu.Attributes["name"].Value;
                }
            }

            return menuName;
        }

        private void loadCountData(String date, String file)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Monthly Counts/" + file);

            var mgr = new XmlNamespaceManager(doc.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode current = doc.SelectSingleNode("//a:month/day[@date='" + date + "']", mgr);

            //breakfast first child, lunch second, and snack third
            breakfastFreeTextBox.Text = current.ChildNodes[0].Attributes["free"].Value;
            breakfastReducedTextBox.Text = current.ChildNodes[0].Attributes["reduced"].Value;
            breakfastPaidTextBox.Text = current.ChildNodes[0].Attributes["paid"].Value;
            breakfastNonReimburseableTextBox.Text = current.ChildNodes[0].Attributes["nonReimburseable"].Value;

            lunchFreeTextBox.Text = current.ChildNodes[1].Attributes["free"].Value;
            lunchReducedTextBox.Text = current.ChildNodes[1].Attributes["reduced"].Value;
            lunchPaidTextBox.Text = current.ChildNodes[1].Attributes["paid"].Value;
            lunchNonReimburseableTextBox.Text = current.ChildNodes[1].Attributes["nonReimburseable"].Value;

            snackFreeTextBox.Text = current.ChildNodes[2].Attributes["free"].Value;
            snackReducedTextBox.Text = current.ChildNodes[2].Attributes["reduced"].Value;
            snackPaidTextBox.Text = current.ChildNodes[2].Attributes["paid"].Value;
            snackNonReimburseableTextBox.Text = current.ChildNodes[2].Attributes["nonReimburseable"].Value;

        }

        private void menuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = getMenuId();
            populateMenuMeals(id.ToString());

        }

        private int getMenuId()
        {
            char[] delimiters = { ':', ' ' };
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

        private void confirmChangesButton_Click(object sender, EventArgs e)
        {
            //from load function
            String passedInfo = Tag.ToString();
            String[] dayInfo = passedInfo.Split(',');

            String filenameText = dayInfo[0];
            String date = dayInfo[1];

            //loadCountData in reverse!
            XmlDocument doc = new XmlDocument();
            doc.Load("Monthly Counts/" + filenameText);

            var mgr = new XmlNamespaceManager(doc.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode current = doc.SelectSingleNode("//a:month/day[@date='" + date + "']", mgr);

            //breakfast first child, lunch second, and snack third
            current.ChildNodes[0].Attributes["free"].Value = breakfastFreeTextBox.Text;
            current.ChildNodes[0].Attributes["reduced"].Value = breakfastReducedTextBox.Text;
            current.ChildNodes[0].Attributes["paid"].Value = breakfastPaidTextBox.Text;
            current.ChildNodes[0].Attributes["nonReimburseable"].Value = breakfastNonReimburseableTextBox.Text;

            current.ChildNodes[1].Attributes["free"].Value = lunchFreeTextBox.Text;
            current.ChildNodes[1].Attributes["reduced"].Value = lunchReducedTextBox.Text;
            current.ChildNodes[1].Attributes["paid"].Value = lunchPaidTextBox.Text;
            current.ChildNodes[1].Attributes["nonReimburseable"].Value = lunchNonReimburseableTextBox.Text;

            current.ChildNodes[2].Attributes["free"].Value = snackFreeTextBox.Text;
            current.ChildNodes[2].Attributes["reduced"].Value = snackReducedTextBox.Text;
            current.ChildNodes[2].Attributes["paid"].Value = snackPaidTextBox.Text;
            current.ChildNodes[2].Attributes["nonReimburseable"].Value = snackNonReimburseableTextBox.Text;

            current.Attributes["menuID"].Value = getMenuId().ToString();

            doc.Save("Monthly Counts/" + filenameText);
            this.Close();
            //ta daaa

        }
    }
}
