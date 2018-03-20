namespace XMLMenus
{
    partial class AddMenuItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ingredientCountTextBox = new System.Windows.Forms.TextBox();
            this.ingredientListView = new System.Windows.Forms.ListView();
            this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredientNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servingSizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servingUnitHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodDescriptonHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.packageSizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.packageUnitHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.packageDescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addToItemButton = new System.Windows.Forms.Button();
            this.removeFromItemButton = new System.Windows.Forms.Button();
            this.itemIngredientsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.itemIngredientCountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.meatTextBox = new System.Windows.Forms.TextBox();
            this.grainsTextBox = new System.Windows.Forms.TextBox();
            this.fruitTextBox = new System.Windows.Forms.TextBox();
            this.totalVegTextBox = new System.Windows.Forms.TextBox();
            this.addVegTextBox = new System.Windows.Forms.TextBox();
            this.otherVegTextBox = new System.Windows.Forms.TextBox();
            this.starchyVegTextBox = new System.Windows.Forms.TextBox();
            this.legumesTextBox = new System.Windows.Forms.TextBox();
            this.roVegTextBox = new System.Windows.Forms.TextBox();
            this.dkGreenVegTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.servingSizeTextBox = new System.Windows.Forms.TextBox();
            this.servingUnitTextBox = new System.Windows.Forms.TextBox();
            this.addMenuItemButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredient Count:";
            // 
            // ingredientCountTextBox
            // 
            this.ingredientCountTextBox.Enabled = false;
            this.ingredientCountTextBox.Location = new System.Drawing.Point(130, 10);
            this.ingredientCountTextBox.Name = "ingredientCountTextBox";
            this.ingredientCountTextBox.Size = new System.Drawing.Size(40, 20);
            this.ingredientCountTextBox.TabIndex = 0;
            // 
            // ingredientListView
            // 
            this.ingredientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.ingredientNameHeader,
            this.servingSizeHeader,
            this.servingUnitHeader,
            this.foodDescriptonHeader,
            this.packageSizeHeader,
            this.packageUnitHeader,
            this.packageDescriptionHeader});
            this.ingredientListView.FullRowSelect = true;
            this.ingredientListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ingredientListView.Location = new System.Drawing.Point(12, 36);
            this.ingredientListView.MultiSelect = false;
            this.ingredientListView.Name = "ingredientListView";
            this.ingredientListView.Size = new System.Drawing.Size(707, 108);
            this.ingredientListView.TabIndex = 1;
            this.ingredientListView.UseCompatibleStateImageBehavior = false;
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "ID";
            this.idColumnHeader.Width = 30;
            // 
            // ingredientNameHeader
            // 
            this.ingredientNameHeader.Text = "Name";
            this.ingredientNameHeader.Width = 70;
            // 
            // servingSizeHeader
            // 
            this.servingSizeHeader.Text = "Serving Size";
            this.servingSizeHeader.Width = 80;
            // 
            // servingUnitHeader
            // 
            this.servingUnitHeader.Text = "Serving Unit";
            this.servingUnitHeader.Width = 80;
            // 
            // foodDescriptonHeader
            // 
            this.foodDescriptonHeader.Text = "Description";
            this.foodDescriptonHeader.Width = 120;
            // 
            // packageSizeHeader
            // 
            this.packageSizeHeader.Text = "Package Size";
            this.packageSizeHeader.Width = 80;
            // 
            // packageUnitHeader
            // 
            this.packageUnitHeader.Text = "Package Units";
            this.packageUnitHeader.Width = 90;
            // 
            // packageDescriptionHeader
            // 
            this.packageDescriptionHeader.Text = "Package Description";
            this.packageDescriptionHeader.Width = 120;
            // 
            // addToItemButton
            // 
            this.addToItemButton.Location = new System.Drawing.Point(469, 152);
            this.addToItemButton.Name = "addToItemButton";
            this.addToItemButton.Size = new System.Drawing.Size(122, 29);
            this.addToItemButton.TabIndex = 3;
            this.addToItemButton.Text = "Add To Item";
            this.addToItemButton.UseVisualStyleBackColor = true;
            this.addToItemButton.Click += new System.EventHandler(this.addToItemButton_Click);
            // 
            // removeFromItemButton
            // 
            this.removeFromItemButton.Location = new System.Drawing.Point(597, 151);
            this.removeFromItemButton.Name = "removeFromItemButton";
            this.removeFromItemButton.Size = new System.Drawing.Size(122, 30);
            this.removeFromItemButton.TabIndex = 4;
            this.removeFromItemButton.Text = "Remove From Item";
            this.removeFromItemButton.UseVisualStyleBackColor = true;
            this.removeFromItemButton.Click += new System.EventHandler(this.removeFromItemButton_Click);
            // 
            // itemIngredientsListView
            // 
            this.itemIngredientsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.itemIngredientsListView.FullRowSelect = true;
            this.itemIngredientsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemIngredientsListView.Location = new System.Drawing.Point(16, 187);
            this.itemIngredientsListView.MultiSelect = false;
            this.itemIngredientsListView.Name = "itemIngredientsListView";
            this.itemIngredientsListView.Size = new System.Drawing.Size(707, 108);
            this.itemIngredientsListView.TabIndex = 41;
            this.itemIngredientsListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Serving Size";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Serving Unit";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Package Size";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Package Units";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Package Description";
            this.columnHeader8.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Item Ingredient Count:";
            // 
            // itemIngredientCountTextBox
            // 
            this.itemIngredientCountTextBox.Enabled = false;
            this.itemIngredientCountTextBox.Location = new System.Drawing.Point(130, 299);
            this.itemIngredientCountTextBox.Name = "itemIngredientCountTextBox";
            this.itemIngredientCountTextBox.Size = new System.Drawing.Size(40, 20);
            this.itemIngredientCountTextBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contributions:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Meat/Meat Alt., oz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Grains, oz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fruit, cup(s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dk. Green Veg., cup(s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "R/O Veg., cup(s)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Legumes, cup(s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Starchy Veg., cup(s)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(396, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Other Veg., cup(s)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(376, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Additional Veg., cup(s)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(562, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Total Veg., cup(s)";
            // 
            // meatTextBox
            // 
            this.meatTextBox.Location = new System.Drawing.Point(130, 355);
            this.meatTextBox.Name = "meatTextBox";
            this.meatTextBox.Size = new System.Drawing.Size(40, 20);
            this.meatTextBox.TabIndex = 8;
            this.meatTextBox.Text = "0";
            this.meatTextBox.TextChanged += new System.EventHandler(this.starchyVegTextBox_TextChanged);
            // 
            // grainsTextBox
            // 
            this.grainsTextBox.Location = new System.Drawing.Point(130, 382);
            this.grainsTextBox.Name = "grainsTextBox";
            this.grainsTextBox.Size = new System.Drawing.Size(40, 20);
            this.grainsTextBox.TabIndex = 9;
            this.grainsTextBox.Text = "0";
            this.grainsTextBox.TextChanged += new System.EventHandler(this.starchyVegTextBox_TextChanged);
            // 
            // fruitTextBox
            // 
            this.fruitTextBox.Location = new System.Drawing.Point(130, 408);
            this.fruitTextBox.Name = "fruitTextBox";
            this.fruitTextBox.Size = new System.Drawing.Size(40, 20);
            this.fruitTextBox.TabIndex = 10;
            this.fruitTextBox.Text = "0";
            this.fruitTextBox.TextChanged += new System.EventHandler(this.starchyVegTextBox_TextChanged);
            // 
            // totalVegTextBox
            // 
            this.totalVegTextBox.Enabled = false;
            this.totalVegTextBox.Location = new System.Drawing.Point(659, 355);
            this.totalVegTextBox.Name = "totalVegTextBox";
            this.totalVegTextBox.Size = new System.Drawing.Size(40, 20);
            this.totalVegTextBox.TabIndex = 27;
            // 
            // addVegTextBox
            // 
            this.addVegTextBox.Location = new System.Drawing.Point(495, 408);
            this.addVegTextBox.Name = "addVegTextBox";
            this.addVegTextBox.Size = new System.Drawing.Size(40, 20);
            this.addVegTextBox.TabIndex = 16;
            this.addVegTextBox.Text = "0";
            this.addVegTextBox.TextChanged += new System.EventHandler(this.addVegTextBox_TextChanged);
            // 
            // otherVegTextBox
            // 
            this.otherVegTextBox.Location = new System.Drawing.Point(495, 382);
            this.otherVegTextBox.Name = "otherVegTextBox";
            this.otherVegTextBox.Size = new System.Drawing.Size(40, 20);
            this.otherVegTextBox.TabIndex = 15;
            this.otherVegTextBox.Text = "0";
            this.otherVegTextBox.TextChanged += new System.EventHandler(this.otherVegTextBox_TextChanged);
            // 
            // starchyVegTextBox
            // 
            this.starchyVegTextBox.Location = new System.Drawing.Point(495, 355);
            this.starchyVegTextBox.Name = "starchyVegTextBox";
            this.starchyVegTextBox.Size = new System.Drawing.Size(40, 20);
            this.starchyVegTextBox.TabIndex = 14;
            this.starchyVegTextBox.Text = "0";
            this.starchyVegTextBox.TextChanged += new System.EventHandler(this.starchyVegTextBox_TextChanged);
            // 
            // legumesTextBox
            // 
            this.legumesTextBox.Location = new System.Drawing.Point(320, 408);
            this.legumesTextBox.Name = "legumesTextBox";
            this.legumesTextBox.Size = new System.Drawing.Size(40, 20);
            this.legumesTextBox.TabIndex = 13;
            this.legumesTextBox.Text = "0";
            this.legumesTextBox.TextChanged += new System.EventHandler(this.legumesTextBox_TextChanged);
            // 
            // roVegTextBox
            // 
            this.roVegTextBox.Location = new System.Drawing.Point(320, 382);
            this.roVegTextBox.Name = "roVegTextBox";
            this.roVegTextBox.Size = new System.Drawing.Size(40, 20);
            this.roVegTextBox.TabIndex = 12;
            this.roVegTextBox.Text = "0";
            this.roVegTextBox.TextChanged += new System.EventHandler(this.roVegTextBox_TextChanged);
            // 
            // dkGreenVegTextBox
            // 
            this.dkGreenVegTextBox.Location = new System.Drawing.Point(320, 355);
            this.dkGreenVegTextBox.Name = "dkGreenVegTextBox";
            this.dkGreenVegTextBox.Size = new System.Drawing.Size(40, 20);
            this.dkGreenVegTextBox.TabIndex = 11;
            this.dkGreenVegTextBox.Text = "0";
            this.dkGreenVegTextBox.TextChanged += new System.EventHandler(this.dkGreenVegTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(202, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Decription:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(266, 299);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(433, 20);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(191, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Serving Size:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(344, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Serving Unit:";
            // 
            // servingSizeTextBox
            // 
            this.servingSizeTextBox.Location = new System.Drawing.Point(266, 322);
            this.servingSizeTextBox.Name = "servingSizeTextBox";
            this.servingSizeTextBox.Size = new System.Drawing.Size(40, 20);
            this.servingSizeTextBox.TabIndex = 6;
            this.servingSizeTextBox.Text = "0";
            // 
            // servingUnitTextBox
            // 
            this.servingUnitTextBox.Location = new System.Drawing.Point(418, 322);
            this.servingUnitTextBox.Name = "servingUnitTextBox";
            this.servingUnitTextBox.Size = new System.Drawing.Size(40, 20);
            this.servingUnitTextBox.TabIndex = 7;
            // 
            // addMenuItemButton
            // 
            this.addMenuItemButton.Location = new System.Drawing.Point(597, 399);
            this.addMenuItemButton.Name = "addMenuItemButton";
            this.addMenuItemButton.Size = new System.Drawing.Size(122, 29);
            this.addMenuItemButton.TabIndex = 17;
            this.addMenuItemButton.Text = "Add Menu Item";
            this.addMenuItemButton.UseVisualStyleBackColor = true;
            this.addMenuItemButton.Click += new System.EventHandler(this.addMenuItemButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Item Name:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(83, 157);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.itemNameTextBox.TabIndex = 2;
            // 
            // AddMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 441);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.addMenuItemButton);
            this.Controls.Add(this.servingUnitTextBox);
            this.Controls.Add(this.servingSizeTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dkGreenVegTextBox);
            this.Controls.Add(this.roVegTextBox);
            this.Controls.Add(this.legumesTextBox);
            this.Controls.Add(this.starchyVegTextBox);
            this.Controls.Add(this.otherVegTextBox);
            this.Controls.Add(this.addVegTextBox);
            this.Controls.Add(this.totalVegTextBox);
            this.Controls.Add(this.fruitTextBox);
            this.Controls.Add(this.grainsTextBox);
            this.Controls.Add(this.meatTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemIngredientCountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemIngredientsListView);
            this.Controls.Add(this.removeFromItemButton);
            this.Controls.Add(this.addToItemButton);
            this.Controls.Add(this.ingredientListView);
            this.Controls.Add(this.ingredientCountTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddMenuItem";
            this.Text = "Add Menu Item";
            this.Load += new System.EventHandler(this.AddMenuItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingredientCountTextBox;
        private System.Windows.Forms.ListView ingredientListView;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader ingredientNameHeader;
        private System.Windows.Forms.ColumnHeader servingSizeHeader;
        private System.Windows.Forms.ColumnHeader servingUnitHeader;
        private System.Windows.Forms.ColumnHeader foodDescriptonHeader;
        private System.Windows.Forms.ColumnHeader packageSizeHeader;
        private System.Windows.Forms.ColumnHeader packageUnitHeader;
        private System.Windows.Forms.ColumnHeader packageDescriptionHeader;
        private System.Windows.Forms.Button addToItemButton;
        private System.Windows.Forms.Button removeFromItemButton;
        private System.Windows.Forms.ListView itemIngredientsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemIngredientCountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox meatTextBox;
        private System.Windows.Forms.TextBox grainsTextBox;
        private System.Windows.Forms.TextBox fruitTextBox;
        private System.Windows.Forms.TextBox totalVegTextBox;
        private System.Windows.Forms.TextBox addVegTextBox;
        private System.Windows.Forms.TextBox otherVegTextBox;
        private System.Windows.Forms.TextBox starchyVegTextBox;
        private System.Windows.Forms.TextBox legumesTextBox;
        private System.Windows.Forms.TextBox roVegTextBox;
        private System.Windows.Forms.TextBox dkGreenVegTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox servingSizeTextBox;
        private System.Windows.Forms.TextBox servingUnitTextBox;
        private System.Windows.Forms.Button addMenuItemButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox itemNameTextBox;
    }
}