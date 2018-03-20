using System;
using System.IO;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addNewIngredientBtn_Click(object sender, EventArgs e)
        {
            AddIngredientDialog addIngredient = new AddIngredientDialog();
            addIngredient.ShowDialog();
            RefreshIngredientList();
        }

        private void RefreshMenuItemsList()
        {
            menuItemsListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("menuItems.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = loadList.SelectSingleNode("//a:menuItems", mgr);
            menuItemCountTextBox.Text = root.Attributes["count"].Value;

            XmlNodeList items = loadList.SelectNodes("//a:menuItems/menuItem", mgr);
            foreach (XmlNode item in items)
            {
                //String itemInfo = ingredient.Attributes["id"].Value + ": " + ingredient.Attributes["name"].Value;
                //ingredientListBox.Items.Add(itemInfo);

                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = item.Attributes["id"].Value; //id as text of the item
                lvItem.SubItems.Add(item.Attributes["name"].Value); //name as first subitem
                lvItem.SubItems.Add(item.ChildNodes[0].InnerText); //description
                lvItem.SubItems.Add(item.ChildNodes[1].InnerText); //serving size
                lvItem.SubItems.Add(item.ChildNodes[1].Attributes["units"].Value); //serving units
                String idList = item.ChildNodes[2].Attributes["count"].Value + " total: ";
                //hooray for nested loops
                XmlNodeList ingredients = loadList.SelectNodes("//a:menuItems/menuItem[@id='" + item.Attributes["id"].Value + "']/ingredients/ingredient", mgr);
                foreach (XmlNode ingredient in ingredients)
                {
                    idList += ingredient.Attributes["id"].Value;
                    idList += " ";
                }
                lvItem.SubItems.Add(idList);
                menuItemsListView.Items.Add(lvItem);
            }
        }
        private void RefreshIngredientList()
        {
            //ingredientListBox.Items.Clear();
            ingredientListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("ingredients.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = loadList.SelectSingleNode("//a:ingredients", mgr);
            ingredientCountTextBox.Text = root.Attributes["count"].Value;
            XmlNodeList ingredients = loadList.SelectNodes("//a:ingredients/ingredient", mgr);
            foreach (XmlNode ingredient in ingredients)
            {
                //String itemInfo = ingredient.Attributes["id"].Value + ": " + ingredient.Attributes["name"].Value;
                //ingredientListBox.Items.Add(itemInfo);

                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = ingredient.Attributes["id"].Value; //id as text of the item
                lvItem.SubItems.Add(ingredient.Attributes["name"].Value); //name as first subitem
                lvItem.SubItems.Add(ingredient.ChildNodes[0].InnerText); //serving size
                lvItem.SubItems.Add(ingredient.ChildNodes[0].Attributes["units"].Value); //serving unit
                lvItem.SubItems.Add(ingredient.ChildNodes[1].InnerText); //food description
                lvItem.SubItems.Add(ingredient.ChildNodes[2].InnerText); //package size
                lvItem.SubItems.Add(ingredient.ChildNodes[2].Attributes["units"].Value); //package unit
                lvItem.SubItems.Add(ingredient.ChildNodes[3].InnerText); //package description

                ingredientListView.Items.Add(lvItem);

            }
        }
        private void refreshMealList()
        {
            mealsListView.Items.Clear();

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
                lvItem.SubItems.Add(meal.Attributes["type"].Value); //meal type

                String idList = meal.ChildNodes[0].Attributes["count"].Value + " total: ";
                //hooray for nested loops
                XmlNodeList items = loadList.SelectNodes("//a:meals/meal[@id='" + meal.Attributes["id"].Value + "']/menuItems/menuItem", mgr);
                foreach (XmlNode item in items)
                {
                    idList += item.Attributes["id"].Value;
                    idList += " ";
                }
                lvItem.SubItems.Add(idList);
                mealsListView.Items.Add(lvItem);
            }

        }
        private void refreshMenuList()
        {
            menusListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("menus.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = loadList.SelectSingleNode("//a:menus", mgr);
            menuCountTextBox.Text = root.Attributes["count"].Value;
            XmlNodeList menus = loadList.SelectNodes("//a:menus/menu", mgr);
            foreach (XmlNode menu in menus)
            {
                //String itemInfo = ingredient.Attributes["id"].Value + ": " + ingredient.Attributes["name"].Value;
                //ingredientListBox.Items.Add(itemInfo);

                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = menu.Attributes["id"].Value; //id as text of the item
                lvItem.SubItems.Add(menu.Attributes["name"].Value); //name as first subitem
                lvItem.SubItems.Add(menu.Attributes["day"].Value); //meal type

                String idList = menu.ChildNodes[0].Attributes["count"].Value + " total: ";
                //hooray for nested loops
                XmlNodeList items = loadList.SelectNodes("//a:menus/menu[@id='" + menu.Attributes["id"].Value + "']/meals/meal", mgr);
                foreach (XmlNode item in items)
                {
                    idList += item.Attributes["id"].Value;
                    idList += " ";
                }
                lvItem.SubItems.Add(idList);
                menusListView.Items.Add(lvItem);
            }
        }

        private String ingredientsFileCheck()
        {
            String result = "File ingredients.xml";
            //code to check for existance of XML files at start
            if (!File.Exists("ingredients.xml"))//that was easier than expected
            {
                XmlWriter writer = XmlWriter.Create("ingredients.xml");
                writer.WriteStartDocument();
                
                writer.WriteStartElement("ingredients");
                writer.WriteAttributeString("count", "0");
                writer.WriteAttributeString("nextId", "1");
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();
                result += " - created new file. ";
            }//code to create the files if they do not exist (does the structure go here too?
            else result += " - found existing file. ";


            return result;
        }
        private String menuItemsFileCheck()
        {
            String result = "File menuItems.xml";
            //code to check for existance of XML files at start
            if (!File.Exists("menuItems.xml"))//that was easier than expected
            {
                XmlWriter writer = XmlWriter.Create("menuItems.xml");
                writer.WriteStartDocument();

                writer.WriteStartElement("menuItems");
                writer.WriteAttributeString("count", "0");
                writer.WriteAttributeString("nextId", "1");
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();
                result += " - created new file. ";
            }//code to create the files if they do not exist (does the structure go here too?
            else result += " - found existing file. ";


            return result;

        }
        private String mealsFileCheck()
        {
            String result = "File meals.xml";
            //code to check for existance of XML files at start
            if (!File.Exists("meals.xml"))//that was easier than expected
            {
                XmlWriter writer = XmlWriter.Create("meals.xml");
                writer.WriteStartDocument();

                writer.WriteStartElement("meals");
                writer.WriteAttributeString("count", "0");
                writer.WriteAttributeString("nextId", "1");
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();
                result += " - created new file. ";
            }//code to create the files if they do not exist (does the structure go here too?
            else result += " - found existing file. ";
            return result;
        }
        private String menusFileCheck()
        {
            String result = "File menus.xml";
            //code to check for existance of XML files at start
            if (!File.Exists("menus.xml"))//that was easier than expected
            {
                XmlWriter writer = XmlWriter.Create("menus.xml");
                writer.WriteStartDocument();

                writer.WriteStartElement("menus");
                writer.WriteAttributeString("count", "0");
                writer.WriteAttributeString("nextId", "1");
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();
                result += " - created new file. ";
            }//code to create the files if they do not exist (does the structure go here too?
            else result += " - found existing file. ";
            return result;
        }

        private void setDetailViews()
        {
            ingredientListView.View = View.Details;
            menuItemsListView.View = View.Details;
            menuItemsListView.FullRowSelect = true;
            itemContributionsListView.View = View.Details;
            itemContributionsListView.FullRowSelect = true;
            itemIngredientsListView.View = View.Details;
            itemIngredientsListView.FullRowSelect = true;
            mealsListView.View = View.Details;
            mealsListView.FullRowSelect = true;
            mealItemsListView.View = View.Details;
            mealItemsListView.FullRowSelect = true;
            mealContribTotalsListView.View = View.Details;
            menusListView.View = View.Details;
            mealsInMenuListView.View = View.Details;
            menuContribsListView.View = View.Details;
            monthsListView.View = View.Details;
            //and then I saw the view property in the properties window...
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            String message = "File status:\n";
            message += ingredientsFileCheck();
            message += menuItemsFileCheck();
            message += mealsFileCheck();
            message += menusFileCheck();

            filesStatusLabel.Text = message;

            setDetailViews();

            RefreshIngredientList();
            RefreshMenuItemsList();
            refreshMealList();
            refreshMenuList();
            refreshMonthsList();
            Directory.CreateDirectory("Monthly Counts");
        }

        private void refreshMonthsList()
        {
            monthsListView.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo("Monthly Counts");
            FileInfo[] XmlFiles = directory.GetFiles("*.xml");
            foreach (FileInfo file in XmlFiles) {
                ListViewItem item = new ListViewItem();
                item.Text = file.Name;
                item.SubItems.Add(file.FullName);
                monthsListView.Items.Add(item);
            }

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshIngredientList();
            RefreshMenuItemsList();
            refreshMealList();
            refreshMenuList();
        }

        private void deleteSelectedIngredientButton_Click(object sender, EventArgs e)
        {
            if (ingredientListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select an ingredient to delete.");
            }
            else
            {
                String selecetedIngredeint = ingredientListView.SelectedItems[0].Text;
                //var split = selecetedIngredeint.Split(':');
                int ingredientId = Int32.Parse(selecetedIngredeint);
                deleteSelectedIngredient(ingredientId);
            }

        }
        //all these methods need to go in their own classes to clean this file up
        private void deleteSelectedIngredient(int id)
        {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("ingredients.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode root = loadList.SelectSingleNode("//a:ingredients", mgr);
            int count = Int32.Parse(root.Attributes["count"].Value); //almost forgot about this

            XmlNode deleteMe = loadList.SelectSingleNode("//a:ingredients/ingredient[@id='" + id + "']", mgr);
            deleteMe.ParentNode.RemoveChild(deleteMe); //it should find it since the selection is in the list box, right?
            
            count--;
            root.Attributes["count"].Value = count.ToString();

            loadList.Save("ingredients.xml");
            RefreshIngredientList();
        }
        private void deleteSelectedItem(int id)
        {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("menuItems.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode root = loadList.SelectSingleNode("//a:menuItems", mgr);
            int count = Int32.Parse(root.Attributes["count"].Value); //almost forgot about this

            XmlNode deleteMe = loadList.SelectSingleNode("//a:menuItems/menuItem[@id='" + id + "']", mgr);
            deleteMe.ParentNode.RemoveChild(deleteMe); //it should find it since the selection is in the list box, right?

            count--;
            root.Attributes["count"].Value = count.ToString();

            loadList.Save("menuItems.xml");
            RefreshMenuItemsList();
        }
        private void deleteSelectedMeal(int id)
        {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("meals.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode root = loadList.SelectSingleNode("//a:meals", mgr);
            int count = Int32.Parse(root.Attributes["count"].Value); //almost forgot about this

            XmlNode deleteMe = loadList.SelectSingleNode("//a:meals/meal[@id='" + id + "']", mgr);
            deleteMe.ParentNode.RemoveChild(deleteMe); //it should find it since the selection is in the list box, right?

            count--;
            root.Attributes["count"].Value = count.ToString();

            loadList.Save("meals.xml");
            refreshMealList();

        }
        private void modifySelectedIngredientButton_Click(object sender, EventArgs e)
        {
            if (ingredientListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select an ingredient to modify.");
            }
            else
            {
                ModifyIngredientDialog modifyIngredient = new ModifyIngredientDialog();
                modifyIngredient.Tag = ingredientListView.SelectedItems[0].Text;
                modifyIngredient.ShowDialog();
                RefreshIngredientList();
            }
        }

        private void addMenuItemButton_Click(object sender, EventArgs e)
        {
            AddMenuItem addItem = new AddMenuItem();
            addItem.ShowDialog();
            RefreshMenuItemsList();
        }

        private void deleteMenuItemButton_Click(object sender, EventArgs e)
        {
            if (menuItemsListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a menu item to delete.");
            }
            else
            {
                String selectedItem = menuItemsListView.SelectedItems[0].Text;
                //var split = selecetedIngredeint.Split(':');
                int itemId = Int32.Parse(selectedItem);
                deleteSelectedItem(itemId);
            }

        }

        private void modifyMenuItemButton_Click(object sender, EventArgs e)
        {
            if (menuItemsListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select an item to modify.");
            }
            else
            {
                ModifyMenuItem modifyItem = new ModifyMenuItem();
                modifyItem.Tag = menuItemsListView.SelectedItems[0].Text;
                modifyItem.ShowDialog();
                RefreshMenuItemsList();
            }

        }

        private void menuItemsListView_ItemActivate(object sender, EventArgs e)
        {

        }

        private void menuItemsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuItemsListView.SelectedItems.Count > 0)
            {
                populateItemContribs(menuItemsListView.SelectedItems[0].Text);
                populateItemIngredients(menuItemsListView.SelectedItems[0].Text);
            }
        }

        private void populateItemContribs(String id)
        {
            itemContributionsListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("menuItems.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode item = loadList.SelectSingleNode("//a:menuItems/menuItem[@id='" + id + "']", mgr);

            ListViewItem contribs = new ListViewItem();
            contribs.Text = item.Attributes["id"].Value;
            contribs.SubItems.Add(item.ChildNodes[3].ChildNodes[0].InnerText);
            contribs.SubItems.Add(item.ChildNodes[3].ChildNodes[1].InnerText);
            contribs.SubItems.Add(item.ChildNodes[3].ChildNodes[2].InnerText);
            contribs.SubItems.Add(item.ChildNodes[3].ChildNodes[3].InnerText);
            contribs.SubItems.Add(item.ChildNodes[3].ChildNodes[4].InnerText);
            contribs.SubItems.Add(item.ChildNodes[3].ChildNodes[5].InnerText);
            contribs.SubItems.Add(item.ChildNodes[3].ChildNodes[6].InnerText);
            contribs.SubItems.Add(item.ChildNodes[3].ChildNodes[7].InnerText);
            contribs.SubItems.Add(item.ChildNodes[3].ChildNodes[8].InnerText);
            contribs.SubItems.Add(item.ChildNodes[3].ChildNodes[9].InnerText);

            itemContributionsListView.Items.Add(contribs);
        }
        private void populateItemIngredients(String id)
        {
            itemIngredientsListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("menuItems.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNodeList ingredientIds = loadList.SelectNodes("//a:menuItems/menuItem[@id='" + id + "']/ingredients/ingredient", mgr);

            foreach (XmlNode ingredientId in ingredientIds) {
                addMenuItemIngredient(ingredientId.Attributes["id"].Value); //id as text of the item
            }

        }
        private void addMenuItemIngredient(String id)
        {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("ingredients.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode ingredient = loadList.SelectSingleNode("//a:ingredients/ingredient[@id='" + id + "']", mgr);

            //String itemInfo = ingredient.Attributes["id"].Value + ": " + ingredient.Attributes["name"].Value;
            //ingredientListBox.Items.Add(itemInfo);

            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = ingredient.Attributes["id"].Value; //id as text of the item
            lvItem.SubItems.Add(ingredient.Attributes["name"].Value); //name as first subitem
            lvItem.SubItems.Add(ingredient.ChildNodes[0].InnerText); //serving size
            lvItem.SubItems.Add(ingredient.ChildNodes[0].Attributes["units"].Value); //serving unit
            lvItem.SubItems.Add(ingredient.ChildNodes[1].InnerText); //food description
            lvItem.SubItems.Add(ingredient.ChildNodes[2].InnerText); //package size
            lvItem.SubItems.Add(ingredient.ChildNodes[2].Attributes["units"].Value); //package unit
            lvItem.SubItems.Add(ingredient.ChildNodes[3].InnerText); //package description

            itemIngredientsListView.Items.Add(lvItem);
        }

        private void addMealButton_Click(object sender, EventArgs e)
        {
            AddMeal addMeal = new AddMeal();
            addMeal.ShowDialog();
            refreshMealList();
        }

        private void mealsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mealsListView.SelectedItems.Count > 0)
            {
                populateMealContribs(mealsListView.SelectedItems[0].Text);
                populateMealItems(mealsListView.SelectedItems[0].Text);
            }

        }
        private void populateMealContribs(String id)
        {
            float[] runningTotals = new float[10];
            for (int i = 0; i < 10; i++)
            {
                runningTotals[i] = 0;
            }

            mealContribTotalsListView.Items.Clear();

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

            mealContribTotalsListView.Items.Add(contribs);

        }
        private void populateMealItems(String id)
        {
            mealItemsListView.Items.Clear();

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

            mealItemsListView.Items.Add(lvItem);
        }

        private void deleteMealButton_Click(object sender, EventArgs e)
        {
            if (mealsListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a meal to delete.");
            }
            else
            {
                String selecetedMeal = mealsListView.SelectedItems[0].Text;
                //var split = selecetedIngredeint.Split(':');
                int mealId = Int32.Parse(selecetedMeal);
                deleteSelectedMeal(mealId);
            }

        }

        private void modifyMealButton_Click(object sender, EventArgs e)
        {
            if (mealsListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a meal to modify.");
            }
            else
            {
                ModifyMeal modifyMeal = new ModifyMeal();
                modifyMeal.Tag = mealsListView.SelectedItems[0].Text;
                modifyMeal.ShowDialog();
                refreshMealList();
            }
        }

        private void addMenuButton_Click(object sender, EventArgs e)
        {
            AddMenu addMenu = new AddMenu();
            addMenu.ShowDialog();
            refreshMenuList();
        }

        private void menusListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menusListView.SelectedItems.Count > 0)
            {                
                populateMenuMeals(menusListView.SelectedItems[0].Text);
                populateMenuContribs(menusListView.SelectedItems[0].Text);
            }
        }
        private void populateMenuContribs(String id)
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
                String mealId = mealsInMenuListView.Items[i].Text;

                XmlNodeList itemIds = loadList.SelectNodes("//a:meals/meal[@id='" + mealId + "']/menuItems/menuItem", mgr);
                XmlNode meal = loadList.SelectSingleNode("//a:meals/meal[@id='" + mealId + "']/menuItems", mgr);
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
        private void populateMenuMeals(String id)
        {
            mealsInMenuListView.Items.Clear();

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

            mealsInMenuListView.Items.Add(lvItem);
        }

        private void modifyMenuButton_Click(object sender, EventArgs e)
        {
            if (menusListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a menu to modify.");
            }
            else
            {
                ModifyMenu modifyMenu = new ModifyMenu();
                modifyMenu.Tag = menusListView.SelectedItems[0].Text;
                modifyMenu.ShowDialog();
                refreshMenuList();
            }

        }

        private void deleteMenuButton_Click(object sender, EventArgs e)
        {
            if (menusListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a menu to delete.");
            }
            else
            {
                String selecetedMenu = menusListView.SelectedItems[0].Text;
                //var split = selecetedIngredeint.Split(':');
                int menuId = Int32.Parse(selecetedMenu);
                deleteSelectedMenu(menuId);
            }
        }

        private void deleteSelectedMenu(int id)
        {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("menus.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode root = loadList.SelectSingleNode("//a:menus", mgr);
            int count = Int32.Parse(root.Attributes["count"].Value); //almost forgot about this

            XmlNode deleteMe = loadList.SelectSingleNode("//a:menus/menu[@id='" + id + "']", mgr);
            deleteMe.ParentNode.RemoveChild(deleteMe); //it should find it since the selection is in the list box, right?

            count--;
            root.Attributes["count"].Value = count.ToString();

            loadList.Save("menus.xml");
            refreshMenuList();
        }

        private void newMonthButton_Click(object sender, EventArgs e)
        {
            NewMonthDialog newMonth = new NewMonthDialog();
            newMonth.ShowDialog();
            refreshMonthsList();
        }

        private void monthsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthsListView.SelectedItems.Count > 0)
            {
                currentMonthTextBox.Text = monthsListView.SelectedItems[0].Text;
                populateDays(monthsListView.SelectedItems[0].Text);
            }
        }
        private void populateDays(String filename)
        {
            daysListView.Items.Clear();
            XmlDocument loadList = new XmlDocument();
            loadList.Load("Monthly Counts/" + filename);

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNodeList days = loadList.SelectNodes("//a:month/day", mgr);

            foreach (XmlNode day in days)
            {
                ListViewItem newDay = new ListViewItem();
                newDay.Text = day.Attributes["date"].Value;
                newDay.SubItems.Add(day.Attributes["menuID"].Value);
                daysListView.Items.Add(newDay);
            }
        }

        private void addDayButton_Click(object sender, EventArgs e)
        {
            if (monthsListView.SelectedItems.Count > 0)
            {
                NewDay addDay = new NewDay();
                addDay.Tag = monthsListView.SelectedItems[0].Text;
                addDay.ShowDialog();
                populateDays(currentMonthTextBox.Text);
            }
            else MessageBox.Show("Please select a month file.");

        }

        private void daysListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (daysListView.SelectedItems.Count > 0)
            {
                populateDayData(daysListView.SelectedItems[0].Text);
            }
        }

        private void populateDayData(String date)
        {
            dayDetailsListView.Items.Clear();
            XmlDocument loadList = new XmlDocument();
            loadList.Load("Monthly Counts/" + currentMonthTextBox.Text);

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode day = loadList.SelectSingleNode("//a:month/day[@date='" + date + "']", mgr);

            foreach (XmlNode meal in day.ChildNodes)
            {
                ListViewItem newMeal = new ListViewItem();
                newMeal.Text = meal.Name;
                newMeal.SubItems.Add(meal.Attributes["free"].Value);
                newMeal.SubItems.Add(meal.Attributes["reduced"].Value);
                newMeal.SubItems.Add(meal.Attributes["paid"].Value);
                newMeal.SubItems.Add(meal.Attributes["nonReimburseable"].Value);
                dayDetailsListView.Items.Add(newMeal);
            }
        }

        private void modifyDayButton_Click(object sender, EventArgs e)
        {
            if (daysListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a day to modify.");
            }
            else
            {
                ModifyDay modifyDay = new ModifyDay();
                String date = daysListView.SelectedItems[0].Text;
                modifyDay.Tag = currentMonthTextBox.Text + "," + date;
                modifyDay.ShowDialog();
                populateDays(currentMonthTextBox.Text);
                populateDayData(date);
            }
        }

        private void deleteDayButton_Click(object sender, EventArgs e)
        {
            if (daysListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a day to delete.");
            }
            else
            {
                String selectedDate = daysListView.SelectedItems[0].Text;
                deleteSelectedDay(selectedDate);
            }
        }

        private void deleteSelectedDay(String date)
        {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("Monthly Counts/" + currentMonthTextBox.Text); 
            //potential error here? probably not since day selection refreshes when month selection changes

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode deleteMe = loadList.SelectSingleNode("//a:month/day[@date='" + date + "']", mgr);

            deleteMe.ParentNode.RemoveChild(deleteMe); //it should find it since the selection is in the list box, right?

            loadList.Save("Monthly Counts/" + currentMonthTextBox.Text);
            populateDays(currentMonthTextBox.Text);
        }

        private void productionReportButton_Click(object sender, EventArgs e)
        {
            if (daysListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a day to report.");
            }
            else
            {
                String dayInfo = daysListView.SelectedItems[0].Text + ':' + currentMonthTextBox.Text;
                productionReportLauncher(dayInfo);
            }
        }

        private void productionReportLauncher(String rawDate)
        {
            ReportGenerator report = new ReportGenerator();
            report.Tag = rawDate;
            report.ShowDialog();
        }
    }
}
