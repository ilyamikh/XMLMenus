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
    public partial class AddMeal : Form
    {
        public AddMeal()
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

        private void AddMeal_Load(object sender, EventArgs e)
        {
            setDetailsView();
            populateItems();
            updateCounts();
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
        private void updateContribTotals()
        {

            float[] runningTotals = new float[10];
            for (int i = 0; i < 10; i++ )
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

        private void addMealButton_Click(object sender, EventArgs e)
        {
            XmlDocument editDoc = new XmlDocument();
            editDoc.Load("meals.xml");

            var mgr = new XmlNamespaceManager(editDoc.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = editDoc.SelectSingleNode("//a:meals", mgr);
            //parse the counting attributes of the xml
            int newId = Int32.Parse(root.Attributes["nextId"].Value);
            int count = Int32.Parse(root.Attributes["count"].Value);

            //terrifying no input validation to follow. Beware!

            XmlNode meal = editDoc.CreateElement("meal");
            //append id and name
            XmlAttribute attribute = editDoc.CreateAttribute("id");
            attribute.Value = newId.ToString(); //good thing I changed it here, probably will use for every single refresh later event
            meal.Attributes.Append(attribute);
            attribute = editDoc.CreateAttribute("name");
            attribute.Value = mealNameTextBox.Text; //had to go back and rewrite intredient with setters and getters here
            meal.Attributes.Append(attribute);
            attribute = editDoc.CreateAttribute("type");
            attribute.Value = mealTypeTextBox.Text;
            meal.Attributes.Append(attribute);

            XmlNode itemList = editDoc.CreateElement("menuItems");
            attribute = editDoc.CreateAttribute("count");
            attribute.Value = itemsInMealListView.Items.Count.ToString();
            itemList.Attributes.Append(attribute);

            for (int i = 0; i < itemsInMealListView.Items.Count; i++)
            {
                XmlNode item = editDoc.CreateElement("menuItem");
                attribute = editDoc.CreateAttribute("id");
                attribute.Value = itemsInMealListView.Items[i].Text;
                item.Attributes.Append(attribute);
                itemList.AppendChild(item);
            }

            meal.AppendChild(itemList);
            root.AppendChild(meal);

            //increment these attributes before writing new element
            count++; newId++;
            root.Attributes["nextId"].Value = newId.ToString();
            root.Attributes["count"].Value = count.ToString();
            editDoc.Save("meals.xml");

            //MessageBox.Show("Successfully added new ingredient"); //somewhat optimistic
            this.Close();

        }
    }
}
