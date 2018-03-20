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
    public partial class ModifyMenuItem : Form
    {
        public ModifyMenuItem()
        {
            InitializeComponent();
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
        private void ModifyMenuItem_Load(object sender, EventArgs e)
        {
            ingredientListView.View = View.Details;
            itemIngredientsListView.View = View.Details;
            RefreshIngredientList();
            populateInfo();
            updateCounts();
            runningVegTotal();
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

        private void populateInfo()
        {                
            XmlDocument loadList = new XmlDocument();
            loadList.Load("menuItems.xml");

            var mgr = new XmlNamespaceManager(loadList.NameTable);
            mgr.AddNamespace("a", "");

            XmlNodeList ingredientIds = loadList.SelectNodes("//a:menuItems/menuItem[@id='" + this.Tag.ToString() + "']/ingredients/ingredient", mgr);
            foreach (XmlNode ingredientId in ingredientIds)
            {
                addMenuItemIngredient(ingredientId.Attributes["id"].Value); //id as text of the item
            }

            XmlNode item = loadList.SelectSingleNode("//a:menuItems/menuItem[@id='" + this.Tag.ToString() + "']", mgr);

            itemIdTextBox.Text = item.Attributes["id"].Value;
            itemNameTextBox.Text = item.Attributes["name"].Value;
            descriptionTextBox.Text = item.ChildNodes[0].InnerText;
            servingSizeTextBox.Text = item.ChildNodes[1].InnerText;
            servingUnitTextBox.Text = item.ChildNodes[1].Attributes["units"].Value;

            meatTextBox.Text = item.ChildNodes[3].ChildNodes[0].InnerText;
            grainsTextBox.Text = item.ChildNodes[3].ChildNodes[1].InnerText;
            fruitTextBox.Text = item.ChildNodes[3].ChildNodes[2].InnerText;
            dkGreenVegTextBox.Text = item.ChildNodes[3].ChildNodes[3].InnerText;
            roVegTextBox.Text = item.ChildNodes[3].ChildNodes[4].InnerText;
            legumesTextBox.Text = item.ChildNodes[3].ChildNodes[5].InnerText;
            starchyVegTextBox.Text = item.ChildNodes[3].ChildNodes[6].InnerText;
            otherVegTextBox.Text = item.ChildNodes[3].ChildNodes[7].InnerText;
            addVegTextBox.Text = item.ChildNodes[3].ChildNodes[8].InnerText;
        }

        private void updateCounts()
        {
            itemIngredientCountTextBox.Text = itemIngredientsListView.Items.Count.ToString();
            ingredientCountTextBox.Text = ingredientListView.Items.Count.ToString();

        }
        private void addToItemButton_Click(object sender, EventArgs e)
        {
            if (ingredientListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select an ingredient from the ingredient list.");
            }
            else
            {
                ListViewItem moving = new ListViewItem();
                moving = ingredientListView.SelectedItems[0];
                ingredientListView.Items.Remove(ingredientListView.SelectedItems[0]);
                itemIngredientsListView.Items.Add(moving);
                updateCounts();
            }

        }

        private void removeFromItemButton_Click(object sender, EventArgs e)
        {
            if (itemIngredientsListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select an ingredient from the item ingredients list.");
            }
            else
            {
                ListViewItem moving = new ListViewItem();
                moving = itemIngredientsListView.SelectedItems[0];
                itemIngredientsListView.Items.Remove(itemIngredientsListView.SelectedItems[0]);
                ingredientListView.Items.Add(moving);
                updateCounts();
            }

        }

        private void starchyVegTextBox_TextChanged(object sender, EventArgs e)
        {
            float number;
            if (float.TryParse(starchyVegTextBox.Text, out number))
                runningVegTotal();
        }



        private void runningVegTotal()
        {
            float runningTotal = 0;
            runningTotal += float.Parse(dkGreenVegTextBox.Text);
            runningTotal += float.Parse(roVegTextBox.Text);
            runningTotal += float.Parse(legumesTextBox.Text);
            runningTotal += float.Parse(starchyVegTextBox.Text);
            runningTotal += float.Parse(otherVegTextBox.Text);
            runningTotal += float.Parse(addVegTextBox.Text);
            totalVegTextBox.Text = runningTotal.ToString();

        }

        private void otherVegTextBox_TextChanged(object sender, EventArgs e)
        {
            float number;
            if (float.TryParse(otherVegTextBox.Text, out number))
                runningVegTotal();
        }

        private void addVegTextBox_TextChanged(object sender, EventArgs e)
        {
            float number;
            if (float.TryParse(addVegTextBox.Text, out number))
                runningVegTotal();
        }

        private void dkGreenVegTextBox_TextChanged(object sender, EventArgs e)
        {
            float number;
            if (float.TryParse(dkGreenVegTextBox.Text, out number))
                runningVegTotal();
        }

        private void roVegTextBox_TextChanged(object sender, EventArgs e)
        {
            float number;
            if (float.TryParse(roVegTextBox.Text, out number))
                runningVegTotal();
        }

        private void legumesTextBox_TextChanged(object sender, EventArgs e)
        {
            float number;
            if (float.TryParse(legumesTextBox.Text, out number))
                runningVegTotal();
        }

        private void modifyMenuItemButton_Click(object sender, EventArgs e)
        {
            XmlDocument editDoc = new XmlDocument();
            editDoc.Load("menuItems.xml");

            var mgr = new XmlNamespaceManager(editDoc.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode item = editDoc.SelectSingleNode("//a:menuItems/menuItem[@id='" + this.Tag.ToString() + "']", mgr);

            item.Attributes["name"].Value = itemNameTextBox.Text;
            item.ChildNodes[0].InnerText = descriptionTextBox.Text;
            item.ChildNodes[1].InnerText = servingSizeTextBox.Text;
            item.ChildNodes[1].Attributes["units"].Value = servingUnitTextBox.Text;

            //THIS IS BROKEN, NEED TO FIX!! REMEMBER TO MODIFY INGREDIENT COUNTS!! (update: should be fixed)
            //removing all ingredeints first
            XmlNodeList ingredients = editDoc.SelectNodes("//a:menuItems/menuItem[@id='" + this.Tag.ToString() + "']/ingredients/ingredient", mgr);
            foreach (XmlNode ingredient in ingredients)
            {
                item.ChildNodes[2].RemoveChild(ingredient);
            }

            //and then write all the new ones
            item.ChildNodes[2].Attributes["count"].Value = itemIngredientsListView.Items.Count.ToString();
            for (int i = 0; i < itemIngredientsListView.Items.Count; i++)
            {
                XmlNode newIngredient = editDoc.CreateElement("ingredient");
                XmlAttribute newId = editDoc.CreateAttribute("id");
                newId.Value = itemIngredientsListView.Items[i].Text;
                newIngredient.Attributes.Append(newId);
                item.ChildNodes[2].AppendChild(newIngredient);
            }

            //and once again we reverse the process!
            item.ChildNodes[3].ChildNodes[0].InnerText = meatTextBox.Text;
            item.ChildNodes[3].ChildNodes[1].InnerText = grainsTextBox.Text;
            item.ChildNodes[3].ChildNodes[2].InnerText = fruitTextBox.Text;
            item.ChildNodes[3].ChildNodes[3].InnerText = dkGreenVegTextBox.Text;
            item.ChildNodes[3].ChildNodes[4].InnerText = roVegTextBox.Text;
            item.ChildNodes[3].ChildNodes[5].InnerText = legumesTextBox.Text;
            item.ChildNodes[3].ChildNodes[6].InnerText = starchyVegTextBox.Text;
            item.ChildNodes[3].ChildNodes[7].InnerText = otherVegTextBox.Text;
            item.ChildNodes[3].ChildNodes[8].InnerText = addVegTextBox.Text;
            item.ChildNodes[3].ChildNodes[9].InnerText = totalVegTextBox.Text;

            editDoc.Save("menuItems.xml");
            //MessageBox.Show("Successfully added new ingredient"); //somewhat optimistic
            this.Close();
        }
    }
}
