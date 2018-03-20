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
//somewhat lazy way of doing this dialog, not sure why I need the ingredient class at all up to this point
//this whole thing needs refactoring like crazy

namespace XMLMenus
{
    public partial class ModifyIngredientDialog : Form
    {
        public ModifyIngredientDialog()
        {
            InitializeComponent();
        }

        private void ModifyIngredientDialog_Load(object sender, EventArgs e)
        {
            ingredientIdTextBox.Text = this.Tag.ToString();

            XmlDocument loadIngredientData = new XmlDocument();
            loadIngredientData.Load("ingredients.xml");

            var mgr = new XmlNamespaceManager(loadIngredientData.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = loadIngredientData.SelectSingleNode("//a:ingredients", mgr);
            XmlNode ingredient = loadIngredientData.SelectSingleNode("//a:ingredients/ingredient[@id='" + this.Tag.ToString() + "']", mgr);

            foodNameText.Text = ingredient.Attributes["name"].Value; //food name
            servingSizeText.Text = ingredient.ChildNodes[0].InnerText; //serving size
            servingUnitText.Text = ingredient.ChildNodes[0].Attributes["units"].Value; //serving unit
            foodDescriptionText.Text = ingredient.ChildNodes[1].InnerText; //food description
            packageSizeText.Text = ingredient.ChildNodes[2].InnerText; //package size
            packageUnitText.Text = ingredient.ChildNodes[2].Attributes["units"].Value; //package unit
            packageDescriptionText.Text = ingredient.ChildNodes[3].InnerText; //package description

        }

        private void saveChnagesButton_Click(object sender, EventArgs e)
        {
            //and now we reverse the process!!
            XmlDocument loadIngredientData = new XmlDocument();
            loadIngredientData.Load("ingredients.xml");

            var mgr = new XmlNamespaceManager(loadIngredientData.NameTable);
            mgr.AddNamespace("a", "");
            XmlNode root = loadIngredientData.SelectSingleNode("//a:ingredients", mgr);
            XmlNode ingredient = loadIngredientData.SelectSingleNode("//a:ingredients/ingredient[@id='" + this.Tag.ToString() + "']", mgr);

            ingredient.Attributes["name"].Value = foodNameText.Text; //food name
            ingredient.ChildNodes[0].InnerText = servingSizeText.Text; //serving size
            ingredient.ChildNodes[0].Attributes["units"].Value = servingUnitText.Text; //serving unit
            ingredient.ChildNodes[1].InnerText = foodDescriptionText.Text; //food description
            ingredient.ChildNodes[2].InnerText = packageSizeText.Text; //package size
            ingredient.ChildNodes[2].Attributes["units"].Value = packageUnitText.Text; //package unit
            ingredient.ChildNodes[3].InnerText = packageDescriptionText.Text; //package description

            loadIngredientData.Save("ingredients.xml");
            this.Close();
        }
    }
}
