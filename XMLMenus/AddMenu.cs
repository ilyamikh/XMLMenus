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
    public partial class AddMenu : Form
    {
        public AddMenu()
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
        }

        private void AddMenu_Load(object sender, EventArgs e)
        {
            setDetailsView();
            populateMeals();
            updateCounts();
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

        private void mealsInMenuListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mealsInMenuListView.SelectedItems.Count > 0)
            {
                populateMenuMealItems(mealsInMenuListView.SelectedItems[0].Text);
            }

        }

        private void addMenuButton_Click(object sender, EventArgs e)
        {
            XmlDocument editDoc = new XmlDocument();
            editDoc.Load("menus.xml");

            var mgr = new XmlNamespaceManager(editDoc.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = editDoc.SelectSingleNode("//a:menus", mgr);
            //parse the counting attributes of the xml
            int newId = Int32.Parse(root.Attributes["nextId"].Value);
            int count = Int32.Parse(root.Attributes["count"].Value);

            //terrifying no input validation to follow. Beware!

            XmlNode menu = editDoc.CreateElement("menu");
            //append id and name
            XmlAttribute attribute = editDoc.CreateAttribute("id");
            attribute.Value = newId.ToString(); //good thing I changed it here, probably will use for every single refresh later event
            menu.Attributes.Append(attribute);
            attribute = editDoc.CreateAttribute("name");
            attribute.Value = menuNameTextBox.Text; //had to go back and rewrite intredient with setters and getters here
            menu.Attributes.Append(attribute);
            attribute = editDoc.CreateAttribute("day");
            attribute.Value = menuDayTextBox.Text;
            menu.Attributes.Append(attribute);

            XmlNode mealList = editDoc.CreateElement("meals");
            attribute = editDoc.CreateAttribute("count");
            attribute.Value = mealsInMenuListView.Items.Count.ToString();
            mealList.Attributes.Append(attribute);

            for (int i = 0; i < mealsInMenuListView.Items.Count; i++)
            {
                XmlNode item = editDoc.CreateElement("meal");
                attribute = editDoc.CreateAttribute("id");
                attribute.Value = mealsInMenuListView.Items[i].Text;
                item.Attributes.Append(attribute);
                mealList.AppendChild(item);
            }

            menu.AppendChild(mealList);
            root.AppendChild(menu);

            //increment these attributes before writing new element
            count++; newId++;
            root.Attributes["nextId"].Value = newId.ToString();
            root.Attributes["count"].Value = count.ToString();
            editDoc.Save("menus.xml");

            //MessageBox.Show("Successfully added new ingredient"); //somewhat optimistic
            this.Close();
        }
    }
}
