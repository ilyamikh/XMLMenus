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
    public partial class AddMenuItem : Form
    {
        public AddMenuItem()
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
        private void AddMenuItem_Load(object sender, EventArgs e)
        {
            ingredientListView.View = View.Details;
            itemIngredientsListView.View = View.Details;            
            RefreshIngredientList();
            updateCounts();
            runningVegTotal();
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
            if(float.TryParse(starchyVegTextBox.Text, out number))
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

        private void addMenuItemButton_Click(object sender, EventArgs e)
        {
            XmlDocument editDoc = new XmlDocument();
            editDoc.Load("menuItems.xml");

            var mgr = new XmlNamespaceManager(editDoc.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = editDoc.SelectSingleNode("//a:menuItems", mgr);
            //parse the counting attributes of the xml
            int newId = Int32.Parse(root.Attributes["nextId"].Value);
            int count = Int32.Parse(root.Attributes["count"].Value);

            //terrifying no input validation to follow. Beware!

            XmlNode menuItem = editDoc.CreateElement("menuItem");
            //append id and name
            XmlAttribute attribute = editDoc.CreateAttribute("id");
            attribute.Value = newId.ToString(); //good thing I changed it here, probably will use for every single refresh later event
            menuItem.Attributes.Append(attribute);
            attribute = editDoc.CreateAttribute("name");
            attribute.Value = itemNameTextBox.Text; //had to go back and rewrite intredient with setters and getters here
            menuItem.Attributes.Append(attribute);

            //append food description
            XmlNode properties = editDoc.CreateElement("description"); //lets try doing this one by one and see if the doc is a mess. If it works properly, have to refactor all this
            properties.InnerText = descriptionTextBox.Text;
            menuItem.AppendChild(properties);

            //append serving size
            properties = editDoc.CreateElement("servingSize");
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = servingUnitTextBox.Text;
            properties.Attributes.Append(attribute); //lets try this oone by one also. If the doc turns out to be a mess, have to start over with this
            properties.InnerText = servingSizeTextBox.Text;
            menuItem.AppendChild(properties);

            //append ingredients (ooh boy)
            properties = editDoc.CreateElement("ingredients");
            attribute = editDoc.CreateAttribute("count");
            attribute.Value = itemIngredientsListView.Items.Count.ToString();
            properties.Attributes.Append(attribute);

            //loop through the list view, assuming it has at least one ingredient. Makes no sense to have a blank item, add input validation later
            for (int i = 0; i < itemIngredientsListView.Items.Count; i++)
            {
                XmlNode ingredient = editDoc.CreateElement("ingredient");
                attribute = editDoc.CreateAttribute("id");
                attribute.Value = itemIngredientsListView.Items[i].Text;
                ingredient.Attributes.Append(attribute);
                properties.AppendChild(ingredient);
            }
            //let us see if ths works
            menuItem.AppendChild(properties);

            //contributions... this'll be a long one
            properties = editDoc.CreateElement("contributions");
            //append meat/meat alternate
            XmlNode contribution = editDoc.CreateElement("meatAlt");
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = "oz";
            contribution.Attributes.Append(attribute);
            contribution.InnerText = meatTextBox.Text;
            properties.AppendChild(contribution);
            //append grains
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = "oz";
            contribution = editDoc.CreateElement("grains");
            contribution.Attributes.Append(attribute);
            contribution.InnerText = grainsTextBox.Text;
            properties.AppendChild(contribution);
            //append fruit
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = "cup";
            contribution = editDoc.CreateElement("fruit");
            contribution.Attributes.Append(attribute);
            contribution.InnerText = fruitTextBox.Text;
            properties.AppendChild(contribution);
            //append dark green vegetable
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = "cup";
            contribution = editDoc.CreateElement("dkGreenVeg");
            contribution.Attributes.Append(attribute);
            contribution.InnerText = dkGreenVegTextBox.Text;
            properties.AppendChild(contribution);
            //append red orange vegetable
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = "cup";
            contribution = editDoc.CreateElement("roVeg");
            contribution.Attributes.Append(attribute);
            contribution.InnerText = roVegTextBox.Text;
            properties.AppendChild(contribution);
            //append legumes
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = "cup";
            contribution = editDoc.CreateElement("legumes");
            contribution.Attributes.Append(attribute);
            contribution.InnerText = legumesTextBox.Text;
            properties.AppendChild(contribution);
            //append starchy vegetables
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = "cup";
            contribution = editDoc.CreateElement("starchyVeg");
            contribution.Attributes.Append(attribute);
            contribution.InnerText = starchyVegTextBox.Text;
            properties.AppendChild(contribution);
            //append other vegetable
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = "cup";
            contribution = editDoc.CreateElement("otherVeg");
            contribution.Attributes.Append(attribute);
            contribution.InnerText = otherVegTextBox.Text;
            properties.AppendChild(contribution);
            //append additional vegetable
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = "cup";
            contribution = editDoc.CreateElement("addVeg");
            contribution.Attributes.Append(attribute);
            contribution.InnerText = addVegTextBox.Text;
            properties.AppendChild(contribution);
            //append total vegetables (the calculation of which can crash the whole thing at the input stage)
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = "cup";
            contribution = editDoc.CreateElement("totalVeg");
            contribution.Attributes.Append(attribute);
            contribution.InnerText = totalVegTextBox.Text;
            properties.AppendChild(contribution);

            menuItem.AppendChild(properties);

            root.AppendChild(menuItem);

            //increment these attributes before writing new element
            count++; newId++;
            root.Attributes["nextId"].Value = newId.ToString();
            root.Attributes["count"].Value = count.ToString();
            editDoc.Save("menuItems.xml");

            //MessageBox.Show("Successfully added new ingredient"); //somewhat optimistic
            this.Close();
        }
    }
}
