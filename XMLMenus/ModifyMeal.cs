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
    public partial class ModifyMeal : Form
    {
        public ModifyMeal()
        {
            InitializeComponent();
        }

        private void setDetailsView()
        {
            itemListView.View = View.Details;
            itemContribsListView.View = View.Details;
            itemsInMealListView.View = View.Details;
            mealContribsListView.View = View.Details;
        }
        private void populateItems()
        {
            itemListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("menuItems.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = loadList.SelectSingleNode("//a:menuItems", mgr);
            itemCountTextBox.Text = root.Attributes["count"].Value;

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
                itemListView.Items.Add(lvItem);
            }
        }
        private void updateCounts()
        {
            itemsInMealTextBox.Text = itemsInMealListView.Items.Count.ToString();
            itemCountTextBox.Text = itemListView.Items.Count.ToString();
        }
        private void populateMealItems()
        {
            itemsInMealListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("meals.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNodeList itemIds = loadList.SelectNodes("//a:meals/meal[@id='" + this.Tag.ToString() + "']/menuItems/menuItem", mgr);

            foreach (XmlNode itemId in itemIds)
            {
                addMealItemToList(itemId.Attributes["id"].Value); //id as text of the item
            }

        }
        private void addMealItemToList(String id) {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("menuItems.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode item = loadList.SelectSingleNode("//a:menuItems/menuItem[@id='" + id + "']", mgr);

            ListViewItem lvItem = new ListViewItem();

            lvItem.Text = id;
            lvItem.Text = item.Attributes["id"].Value; //id as text of the item
            lvItem.SubItems.Add(item.Attributes["name"].Value); //name as first subitem
            lvItem.SubItems.Add(item.ChildNodes[0].InnerText); //description
            lvItem.SubItems.Add(item.ChildNodes[1].InnerText); //serving size
            lvItem.SubItems.Add(item.ChildNodes[1].Attributes["units"].Value); //serving units

            itemsInMealListView.Items.Add(lvItem);

        }

        private void setTextBoxes()
        {

            XmlDocument loadList = new XmlDocument();
            loadList.Load("meals.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode currentMeal = loadList.SelectSingleNode("//a:meals/meal[@id='" + this.Tag.ToString() + "']", mgr);

            mealNameTextBox.Text = currentMeal.Attributes["name"].Value;
            mealTypeTextBox.Text = currentMeal.Attributes["type"].Value;


        }

        private void ModifyMeal_Load(object sender, EventArgs e)
        {
            mealIdTextBox.Text = this.Tag.ToString();
            setDetailsView();
            populateItems();
            populateMealItems();
            updateContribTotals();
            updateCounts();
            setTextBoxes();
        }

        private void addToMealButton_Click(object sender, EventArgs e)
        {
            if (itemListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select an item from the item list.");
            }
            else
            {
                ListViewItem moving = new ListViewItem();
                moving = itemListView.SelectedItems[0];
                itemListView.Items.Remove(itemListView.SelectedItems[0]);
                itemsInMealListView.Items.Add(moving);
                updateCounts();
                updateContribTotals();
            }

        }

        private void removeFromMealButton_Click(object sender, EventArgs e)
        {
            if (itemsInMealListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select an item from the meal items list.");
            }
            else
            {
                ListViewItem moving = new ListViewItem();
                moving = itemsInMealListView.SelectedItems[0];
                itemsInMealListView.Items.Remove(itemsInMealListView.SelectedItems[0]);
                itemListView.Items.Add(moving);
                updateCounts();
                updateContribTotals();
            }

        }
        private void updateContribTotals()
        {

            float[] runningTotals = new float[10];
            for (int i = 0; i < 10; i++)
            {
                runningTotals[i] = 0;
            }

            mealContribsListView.Items.Clear();

            XmlDocument loadList = new XmlDocument();
            loadList.Load("menuItems.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            ListViewItem contribs = new ListViewItem();

            for (int j = 0; j < itemsInMealListView.Items.Count; j++)
            {
                XmlNode item = loadList.SelectSingleNode("//a:menuItems/menuItem[@id='" + itemsInMealListView.Items[j].Text + "']", mgr);

                for (int k = 0; k < 10; k++)
                {
                    runningTotals[k] += float.Parse(item.ChildNodes[3].ChildNodes[k].InnerText);
                }

            }

            contribs.Text = itemsInMealListView.Items.Count.ToString();
            for (int h = 0; h < 10; h++)
            {
                contribs.SubItems.Add(runningTotals[h].ToString());
            }

            mealContribsListView.Items.Add(contribs);
        }

        private void modifyMealButton_Click(object sender, EventArgs e)
        {
            XmlDocument loadList = new XmlDocument();
            loadList.Load("meals.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode currentMeal = loadList.SelectSingleNode("//a:meals/meal[@id='" + this.Tag.ToString() + "']", mgr);
            currentMeal.Attributes["name"].Value = mealNameTextBox.Text;
            currentMeal.Attributes["type"].Value = mealTypeTextBox.Text;

            XmlNodeList itemList = loadList.SelectNodes("//a:meals/meal[@id='" + this.Tag.ToString() + "']/menuItems/menuItem", mgr);
            //clear all items
            foreach (XmlNode item in itemList)
            {
                currentMeal.ChildNodes[0].RemoveChild(item);
            }

            //and then write the new ones
            for (int i = 0; i < itemsInMealListView.Items.Count; i++)
            {
                XmlNode item = loadList.CreateElement("menuItem");
                XmlAttribute attribute = loadList.CreateAttribute("id");
                attribute.Value = itemsInMealListView.Items[i].Text;
                item.Attributes.Append(attribute);
                currentMeal.ChildNodes[0].AppendChild(item);
            }

            currentMeal.ChildNodes[0].Attributes["count"].Value = itemsInMealListView.Items.Count.ToString();

            loadList.Save("meals.xml");

            //MessageBox.Show("Successfully added new ingredient"); //somewhat optimistic
            this.Close();

        }

        private void itemListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemListView.SelectedItems.Count > 0)
            {
                populateItemContribs(itemListView.SelectedItems[0].Text);
            }

        }
        private void populateItemContribs(String id)
        {
            itemContribsListView.Items.Clear();

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

            itemContribsListView.Items.Add(contribs);
        }

    }
}
