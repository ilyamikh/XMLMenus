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
    public partial class ModifyMenu : Form
    {
        public ModifyMenu()
        {
            InitializeComponent();
        }

        private void setDetailsView()
        {
            mealListView.View = View.Details;
            itemListView.View = View.Details;
            mealContribsListView.View = View.Details;

            mealsInMenuListView.View = View.Details;
            itemsInMenuListView.View = View.Details;
            menuContribsListView.View = View.Details;
        }
        private void populateMeals()
        {
            mealListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("meals.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = loadList.SelectSingleNode("//a:meals", mgr);
            mealCountTextBox.Text = root.Attributes["count"].Value;

            XmlNodeList meals = loadList.SelectNodes("//a:meals/meal", mgr);
            foreach (XmlNode meal in meals)
            {
                //String itemInfo = ingredient.Attributes["id"].Value + ": " + ingredient.Attributes["name"].Value;
                //ingredientListBox.Items.Add(itemInfo);

                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = meal.Attributes["id"].Value; //id as text of the item
                lvItem.SubItems.Add(meal.Attributes["name"].Value); //name as first subitem
                lvItem.SubItems.Add(meal.Attributes["type"].Value); //description

                String idList = meal.ChildNodes[0].Attributes["count"].Value + " total: ";
                //hooray for nested loops
                XmlNodeList items = loadList.SelectNodes("//a:meals/meal[@id='" + meal.Attributes["id"].Value + "']/menuItems/menuItem", mgr);
                foreach (XmlNode item in items)
                {
                    idList += item.Attributes["id"].Value;
                    idList += " ";
                }
                lvItem.SubItems.Add(idList);

                mealListView.Items.Add(lvItem);
            }
        }
        private void updateCounts()
        {
            mealsInMenuTextBox.Text = mealsInMenuListView.Items.Count.ToString();
            mealCountTextBox.Text = mealListView.Items.Count.ToString();
            menuIdTextBox.Text = this.Tag.ToString();
        }
        private void populateMenuMeals()
        {
            mealsInMenuListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("menus.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNodeList mealIds = loadList.SelectNodes("//a:menus/menu[@id='" + this.Tag.ToString() + "']/meals/meal", mgr);
            
            XmlNode menu = loadList.SelectSingleNode("//a:menus/menu[@id='" + this.Tag.ToString() + "']", mgr);
            menuNameTextBox.Text = menu.Attributes["name"].Value;
            menuDayTextBox.Text = menu.Attributes["day"].Value;

            foreach (XmlNode mealId in mealIds)
            {
                addMealToList(mealId.Attributes["id"].Value); //id as text of the item
            }
        }
        private void addMealToList(String id)
        {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("meals.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode meal = loadList.SelectSingleNode("//a:meals/meal[@id='" + id + "']", mgr);

            ListViewItem lvItem = new ListViewItem();

            lvItem.Text = id;
            lvItem.Text = meal.Attributes["id"].Value; //id as text of the item
            lvItem.SubItems.Add(meal.Attributes["name"].Value); //name as first subitem
            lvItem.SubItems.Add(meal.Attributes["type"].Value);
            String idList = meal.ChildNodes[0].Attributes["count"].Value + " total: ";
            //hooray for nested loops
            XmlNodeList items = loadList.SelectNodes("//a:meals/meal[@id='" + meal.Attributes["id"].Value + "']/menuItems/menuItem", mgr);
            foreach (XmlNode item in items)
            {
                idList += item.Attributes["id"].Value;
                idList += " ";
            }
            lvItem.SubItems.Add(idList);



            mealsInMenuListView.Items.Add(lvItem);
        }
        private void updateMenuContribs()
        {
            float[] runningTotals = new float[10];
            for (int i = 0; i < 10; i++)
            {
                runningTotals[i] = 0;
            }

            menuContribsListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("meals.xml");
            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlDocument loadItems = new XmlDocument();
            loadItems.Load("menuItems.xml");
            var itemMgr = new XmlNamespaceManager(loadItems.NameTable);
            itemMgr.AddNamespace("a", "");
            int itemCount = 0;

            for (int i = 0; i < mealsInMenuListView.Items.Count; i++)
            {
                String id = mealsInMenuListView.Items[i].Text;

                XmlNodeList itemIds = loadList.SelectNodes("//a:meals/meal[@id='" + id + "']/menuItems/menuItem", mgr);
                XmlNode meal = loadList.SelectSingleNode("//a:meals/meal[@id='" + id + "']/menuItems", mgr);
                itemCount += Int32.Parse(meal.Attributes["count"].Value);


                foreach (XmlNode itemId in itemIds)
                {
                    XmlNode menuItem = loadItems.SelectSingleNode("//a:menuItems/menuItem[@id='" + itemId.Attributes["id"].Value + "']", mgr);
                    for (int j = 0; j < 10; j++)
                    {
                        runningTotals[j] += float.Parse(menuItem.ChildNodes[3].ChildNodes[j].InnerText);
                    }

                }

            }

            ListViewItem contribs = new ListViewItem();


            contribs.Text = itemCount.ToString();
            for (int h = 0; h < 10; h++)
            {
                contribs.SubItems.Add(runningTotals[h].ToString());
            }


            menuContribsListView.Items.Add(contribs);

        }

        private void ModifyMenu_Load(object sender, EventArgs e)
        {
            setDetailsView();
            populateMeals();
            populateMenuMeals();
            updateCounts();
            updateMenuContribs();
        }

        private void mealListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mealListView.SelectedItems.Count > 0)
            {
                populateMealContribs(mealListView.SelectedItems[0].Text);
                populateMealItems(mealListView.SelectedItems[0].Text);
            }
        }
        private void populateMealContribs(String id)
        {
            float[] runningTotals = new float[10];
            for (int i = 0; i < 10; i++)
            {
                runningTotals[i] = 0;
            }

            mealContribsListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("meals.xml");
            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlDocument loadItems = new XmlDocument();
            loadItems.Load("menuItems.xml");
            var itemMgr = new XmlNamespaceManager(loadItems.NameTable);
            itemMgr.AddNamespace("a", "");

            XmlNodeList itemIds = loadList.SelectNodes("//a:meals/meal[@id='" + id + "']/menuItems/menuItem", mgr);

            ListViewItem contribs = new ListViewItem();

            foreach (XmlNode itemId in itemIds)
            {
                XmlNode menuItem = loadItems.SelectSingleNode("//a:menuItems/menuItem[@id='" + itemId.Attributes["id"].Value + "']", mgr);
                for (int j = 0; j < 10; j++)
                {
                    runningTotals[j] += float.Parse(menuItem.ChildNodes[3].ChildNodes[j].InnerText);
                }

            }

            XmlNode meal = loadList.SelectSingleNode("//a:meals/meal[@id='" + id + "']/menuItems", mgr);
            contribs.Text = meal.Attributes["count"].Value;
            for (int h = 0; h < 10; h++)
            {
                contribs.SubItems.Add(runningTotals[h].ToString());
            }

            mealContribsListView.Items.Add(contribs);

        }
        private void populateMealItems(String id)
        {
            itemListView.Items.Clear();

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

            itemListView.Items.Add(lvItem);
        }

        private void mealsInMenuListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mealsInMenuListView.SelectedItems.Count > 0)
            {
                populateMenuMealItems(mealsInMenuListView.SelectedItems[0].Text);
            }
        }
        private void populateMenuMealItems(String id)
        {
            itemsInMenuListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("meals.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNodeList itemIds = loadList.SelectNodes("//a:meals/meal[@id='" + id + "']/menuItems/menuItem", mgr);

            foreach (XmlNode itemId in itemIds)
            {
                addMealItemToMenuList(itemId.Attributes["id"].Value); //id as text of the item
            }

        }
        private void addMealItemToMenuList(String id)
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

            itemsInMenuListView.Items.Add(lvItem);
        }

        private void addToMenuButton_Click(object sender, EventArgs e)
        {
            if (mealListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a meal from the meal list.");
            }
            else
            {
                ListViewItem moving = new ListViewItem();
                moving = mealListView.SelectedItems[0];
                mealListView.Items.Remove(mealListView.SelectedItems[0]);
                mealsInMenuListView.Items.Add(moving);
                updateCounts();
                updateMenuContribs();
            }

        }

        private void removeFromMenuButton_Click(object sender, EventArgs e)
        {
            if (mealsInMenuListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a meal from the meal list.");
            }
            else
            {
                ListViewItem moving = new ListViewItem();
                moving = mealsInMenuListView.SelectedItems[0];
                mealsInMenuListView.Items.Remove(mealsInMenuListView.SelectedItems[0]);
                mealListView.Items.Add(moving);
                updateCounts();
                updateMenuContribs();
            }
        }

        private void modifyMenuButton_Click(object sender, EventArgs e)
        {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("menus.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode currentMenu = loadList.SelectSingleNode("//a:menus/menu[@id='" + this.Tag.ToString() + "']", mgr);
            currentMenu.Attributes["name"].Value = menuNameTextBox.Text;
            currentMenu.Attributes["day"].Value = menuDayTextBox.Text;

            XmlNodeList mealList = loadList.SelectNodes("//a:menus/menu[@id='" + this.Tag.ToString() + "']/meals/meal", mgr);
            //clear all items
            foreach (XmlNode meal in mealList)
            {
                currentMenu.ChildNodes[0].RemoveChild(meal);
            }

            //and then write the new ones
            for (int i = 0; i < mealsInMenuListView.Items.Count; i++)
            {
                XmlNode meal = loadList.CreateElement("meal");
                XmlAttribute attribute = loadList.CreateAttribute("id");
                attribute.Value = mealsInMenuListView.Items[i].Text;
                meal.Attributes.Append(attribute);
                currentMenu.ChildNodes[0].AppendChild(meal);
            }

            currentMenu.ChildNodes[0].Attributes["count"].Value = mealsInMenuListView.Items.Count.ToString();

            loadList.Save("menus.xml");

            //MessageBox.Show("Successfully added new ingredient"); //somewhat optimistic
            this.Close();
        }

    }
}
