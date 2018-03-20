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
    public partial class AddIngredientDialog : Form
    {
        public AddIngredientDialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            //this whole function needs refactoring with shears
            Ingredient newIngredient = new Ingredient(  foodNameText.Text,
                                                        servingSizeText.Text,
                                                        servingUnitText.Text,
                                                        foodDescriptionText.Text,
                                                        packageSizeText.Text,
                                                        packageUnitText.Text,
                                                        packageDescriptionText.Text);
             
            //MessageBox.Show(newIngredient.getString());
            XmlDocument editDoc = new XmlDocument();
            editDoc.Load("ingredients.xml");


            var mgr = new XmlNamespaceManager(editDoc.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = editDoc.SelectSingleNode("//a:ingredients", mgr);
            //parse the counting attributes of the xml
            int newId = Int32.Parse(root.Attributes["nextId"].Value);
            newIngredient.setId(newId); //and here it is
            int count = Int32.Parse(root.Attributes["count"].Value);
            //increment these attributes before writing new element
            count++; newId++;
            root.Attributes["nextId"].Value = (newId).ToString();
            root.Attributes["count"].Value = count.ToString();
            
            XmlNode ingredient = editDoc.CreateElement("ingredient");
            
            XmlAttribute attribute = editDoc.CreateAttribute("id");
            attribute.Value = newIngredient.getIdString(); //good thing I changed it here, probably will use for every single refresh later event
            ingredient.Attributes.Append(attribute);
            attribute = editDoc.CreateAttribute("name");
            attribute.Value = newIngredient.getName(); //had to go back and rewrite intredient with setters and getters here
            ingredient.Attributes.Append(attribute);

            //append serving size
            XmlNode properties = editDoc.CreateElement("servingSize"); //lets try doing this one by one and see if the doc is a mess. If it works properly, have to refactor all this
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = newIngredient.getServingUnit();
            properties.Attributes.Append(attribute); //lets try this oone by one also. If the doc turns out to be a mess, have to start over with this
            properties.InnerText = newIngredient.getServingSizeString();
            ingredient.AppendChild(properties);

            //append food description
            properties = editDoc.CreateElement("foodDescription");
            properties.InnerText = newIngredient.getFoodDescription();
            ingredient.AppendChild(properties);

            //append package size
            properties = editDoc.CreateElement("packageSize");
            attribute = editDoc.CreateAttribute("units");
            attribute.Value = newIngredient.getPackageUnit();
            properties.Attributes.Append(attribute);
            properties.InnerText = newIngredient.getPackageSizeString();
            ingredient.AppendChild(properties);

            //append package description
            properties = editDoc.CreateElement("packageDescription");
            properties.InnerText = newIngredient.getPackageDescription();
            ingredient.AppendChild(properties);

            root.AppendChild(ingredient);
            editDoc.Save("ingredients.xml");

            //MessageBox.Show("Successfully added new ingredient"); //somewhat optimistic
            this.Close();
        }
    }
}
