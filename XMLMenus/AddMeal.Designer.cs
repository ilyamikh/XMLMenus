namespace XMLMenus
{
    partial class AddMeal
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
            this.itemListView = new System.Windows.Forms.ListView();
            this.itemIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemDescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servingSizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servingUnitColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.itemCountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mealNameTextBox = new System.Windows.Forms.TextBox();
            this.mealTypeTextBox = new System.Windows.Forms.TextBox();
            this.addToMealButton = new System.Windows.Forms.Button();
            this.removeFromMealButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.itemsInMealTextBox = new System.Windows.Forms.TextBox();
            this.addMealButton = new System.Windows.Forms.Button();
            this.itemContribsListView = new System.Windows.Forms.ListView();
            this.itemContributionsIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemContribsMeatColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemContribsGrainsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemContribsFruitColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemContribsDkGreenVegColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemContribsRoVegColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemContribsLegumesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemContribsStarchyVegColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemContribsOtherVegColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemContribsAddVegColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemContribsTotalVegColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealContribsListView = new System.Windows.Forms.ListView();
            this.mealItemCountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealMeatTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealGrainsTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealFuitTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealDkGreenVegTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealRoVegTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealLegumesTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealStarchyVegTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealOtherVegTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealAddVegTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealTotalVegTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemsInMealListView = new System.Windows.Forms.ListView();
            this.mealItemIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealItemNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealItemDescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealItemServingSizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealItemServingUnitsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemListView
            // 
            this.itemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemIdColumn,
            this.itemNameColumn,
            this.itemDescriptionColumn,
            this.servingSizeColumn,
            this.servingUnitColumn});
            this.itemListView.FullRowSelect = true;
            this.itemListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemListView.Location = new System.Drawing.Point(12, 34);
            this.itemListView.MultiSelect = false;
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(676, 88);
            this.itemListView.TabIndex = 0;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.SelectedIndexChanged += new System.EventHandler(this.itemListView_SelectedIndexChanged);
            // 
            // itemIdColumn
            // 
            this.itemIdColumn.Text = "Item ID";
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.Text = "Item Name";
            this.itemNameColumn.Width = 120;
            // 
            // itemDescriptionColumn
            // 
            this.itemDescriptionColumn.Text = "Item Description";
            this.itemDescriptionColumn.Width = 140;
            // 
            // servingSizeColumn
            // 
            this.servingSizeColumn.Text = "Serving Size";
            this.servingSizeColumn.Width = 100;
            // 
            // servingUnitColumn
            // 
            this.servingUnitColumn.Text = "Serving Units";
            this.servingUnitColumn.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items Count";
            // 
            // itemCountTextBox
            // 
            this.itemCountTextBox.Enabled = false;
            this.itemCountTextBox.Location = new System.Drawing.Point(81, 11);
            this.itemCountTextBox.Name = "itemCountTextBox";
            this.itemCountTextBox.Size = new System.Drawing.Size(40, 20);
            this.itemCountTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Meal Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Meal Type:";
            // 
            // mealNameTextBox
            // 
            this.mealNameTextBox.Location = new System.Drawing.Point(82, 406);
            this.mealNameTextBox.Name = "mealNameTextBox";
            this.mealNameTextBox.Size = new System.Drawing.Size(128, 20);
            this.mealNameTextBox.TabIndex = 6;
            // 
            // mealTypeTextBox
            // 
            this.mealTypeTextBox.Location = new System.Drawing.Point(282, 406);
            this.mealTypeTextBox.Name = "mealTypeTextBox";
            this.mealTypeTextBox.Size = new System.Drawing.Size(130, 20);
            this.mealTypeTextBox.TabIndex = 7;
            // 
            // addToMealButton
            // 
            this.addToMealButton.Location = new System.Drawing.Point(472, 201);
            this.addToMealButton.Name = "addToMealButton";
            this.addToMealButton.Size = new System.Drawing.Size(105, 23);
            this.addToMealButton.TabIndex = 8;
            this.addToMealButton.Text = "Add to Meal";
            this.addToMealButton.UseVisualStyleBackColor = true;
            this.addToMealButton.Click += new System.EventHandler(this.addToMealButton_Click);
            // 
            // removeFromMealButton
            // 
            this.removeFromMealButton.Location = new System.Drawing.Point(583, 201);
            this.removeFromMealButton.Name = "removeFromMealButton";
            this.removeFromMealButton.Size = new System.Drawing.Size(105, 23);
            this.removeFromMealButton.TabIndex = 9;
            this.removeFromMealButton.Text = "Remove from Meal";
            this.removeFromMealButton.UseVisualStyleBackColor = true;
            this.removeFromMealButton.Click += new System.EventHandler(this.removeFromMealButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Items in Meal:";
            // 
            // itemsInMealTextBox
            // 
            this.itemsInMealTextBox.Enabled = false;
            this.itemsInMealTextBox.Location = new System.Drawing.Point(81, 206);
            this.itemsInMealTextBox.Name = "itemsInMealTextBox";
            this.itemsInMealTextBox.Size = new System.Drawing.Size(40, 20);
            this.itemsInMealTextBox.TabIndex = 11;
            // 
            // addMealButton
            // 
            this.addMealButton.Location = new System.Drawing.Point(583, 404);
            this.addMealButton.Name = "addMealButton";
            this.addMealButton.Size = new System.Drawing.Size(105, 23);
            this.addMealButton.TabIndex = 14;
            this.addMealButton.Text = "Add Meal";
            this.addMealButton.UseVisualStyleBackColor = true;
            this.addMealButton.Click += new System.EventHandler(this.addMealButton_Click);
            // 
            // itemContribsListView
            // 
            this.itemContribsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemContributionsIdColumn,
            this.itemContribsMeatColumn,
            this.itemContribsGrainsColumn,
            this.itemContribsFruitColumn,
            this.itemContribsDkGreenVegColumn,
            this.itemContribsRoVegColumn,
            this.itemContribsLegumesColumn,
            this.itemContribsStarchyVegColumn,
            this.itemContribsOtherVegColumn,
            this.itemContribsAddVegColumn,
            this.itemContribsTotalVegColumn});
            this.itemContribsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemContribsListView.Location = new System.Drawing.Point(12, 144);
            this.itemContribsListView.MultiSelect = false;
            this.itemContribsListView.Name = "itemContribsListView";
            this.itemContribsListView.Size = new System.Drawing.Size(676, 51);
            this.itemContribsListView.TabIndex = 15;
            this.itemContribsListView.UseCompatibleStateImageBehavior = false;
            // 
            // itemContributionsIdColumn
            // 
            this.itemContributionsIdColumn.Text = "Item ID";
            // 
            // itemContribsMeatColumn
            // 
            this.itemContribsMeatColumn.Text = "Meat/Meat Alt. (oz eq)";
            // 
            // itemContribsGrainsColumn
            // 
            this.itemContribsGrainsColumn.Text = "Grains (oz eq)";
            // 
            // itemContribsFruitColumn
            // 
            this.itemContribsFruitColumn.Text = "Fruit (cups)";
            // 
            // itemContribsDkGreenVegColumn
            // 
            this.itemContribsDkGreenVegColumn.Text = "Dk. Green Veg (cups)";
            // 
            // itemContribsRoVegColumn
            // 
            this.itemContribsRoVegColumn.Text = "R/O Veg. (cups)";
            // 
            // itemContribsLegumesColumn
            // 
            this.itemContribsLegumesColumn.Text = "Legumes (cups)";
            // 
            // itemContribsStarchyVegColumn
            // 
            this.itemContribsStarchyVegColumn.Text = "Starchy Veg. (cups)";
            // 
            // itemContribsOtherVegColumn
            // 
            this.itemContribsOtherVegColumn.Text = "Other Veg. (cups)";
            // 
            // itemContribsAddVegColumn
            // 
            this.itemContribsAddVegColumn.Text = "Additional Veg. (cups)";
            // 
            // itemContribsTotalVegColumn
            // 
            this.itemContribsTotalVegColumn.Text = "Total Veg. (cups)";
            // 
            // mealContribsListView
            // 
            this.mealContribsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mealItemCountColumn,
            this.mealMeatTotalColumn,
            this.mealGrainsTotalColumn,
            this.mealFuitTotalColumn,
            this.mealDkGreenVegTotalColumn,
            this.mealRoVegTotalColumn,
            this.mealLegumesTotalColumn,
            this.mealStarchyVegTotalColumn,
            this.mealOtherVegTotalColumn,
            this.mealAddVegTotalColumn,
            this.mealTotalVegTotalColumn});
            this.mealContribsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mealContribsListView.Location = new System.Drawing.Point(12, 343);
            this.mealContribsListView.MultiSelect = false;
            this.mealContribsListView.Name = "mealContribsListView";
            this.mealContribsListView.Size = new System.Drawing.Size(676, 50);
            this.mealContribsListView.TabIndex = 16;
            this.mealContribsListView.UseCompatibleStateImageBehavior = false;
            // 
            // mealItemCountColumn
            // 
            this.mealItemCountColumn.Text = "Item Count";
            // 
            // mealMeatTotalColumn
            // 
            this.mealMeatTotalColumn.Text = "Meat/Meat Alt. (oz eq)";
            // 
            // mealGrainsTotalColumn
            // 
            this.mealGrainsTotalColumn.Text = "Grains (oz eq)";
            // 
            // mealFuitTotalColumn
            // 
            this.mealFuitTotalColumn.Text = "Fruit (cups)";
            // 
            // mealDkGreenVegTotalColumn
            // 
            this.mealDkGreenVegTotalColumn.Text = "Dk. Green Veg (cups)";
            // 
            // mealRoVegTotalColumn
            // 
            this.mealRoVegTotalColumn.Text = "R/O Veg. (cups)";
            // 
            // mealLegumesTotalColumn
            // 
            this.mealLegumesTotalColumn.Text = "Legumes (cups)";
            // 
            // mealStarchyVegTotalColumn
            // 
            this.mealStarchyVegTotalColumn.Text = "Starchy Veg. (cups)";
            // 
            // mealOtherVegTotalColumn
            // 
            this.mealOtherVegTotalColumn.Text = "Other Veg. (cups)";
            // 
            // mealAddVegTotalColumn
            // 
            this.mealAddVegTotalColumn.Text = "Additional Veg. (cups)";
            // 
            // mealTotalVegTotalColumn
            // 
            this.mealTotalVegTotalColumn.Text = "Total Veg. (cups)";
            // 
            // itemsInMealListView
            // 
            this.itemsInMealListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mealItemIdColumn,
            this.mealItemNameColumn,
            this.mealItemDescriptionColumn,
            this.mealItemServingSizeColumn,
            this.mealItemServingUnitsColumn});
            this.itemsInMealListView.FullRowSelect = true;
            this.itemsInMealListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemsInMealListView.Location = new System.Drawing.Point(12, 232);
            this.itemsInMealListView.MultiSelect = false;
            this.itemsInMealListView.Name = "itemsInMealListView";
            this.itemsInMealListView.Size = new System.Drawing.Size(676, 88);
            this.itemsInMealListView.TabIndex = 17;
            this.itemsInMealListView.UseCompatibleStateImageBehavior = false;
            // 
            // mealItemIdColumn
            // 
            this.mealItemIdColumn.Text = "Item ID";
            // 
            // mealItemNameColumn
            // 
            this.mealItemNameColumn.Text = "Item Name";
            this.mealItemNameColumn.Width = 120;
            // 
            // mealItemDescriptionColumn
            // 
            this.mealItemDescriptionColumn.Text = "Item Description";
            this.mealItemDescriptionColumn.Width = 140;
            // 
            // mealItemServingSizeColumn
            // 
            this.mealItemServingSizeColumn.Text = "Serving Size";
            this.mealItemServingSizeColumn.Width = 100;
            // 
            // mealItemServingUnitsColumn
            // 
            this.mealItemServingUnitsColumn.Text = "Serving Units";
            this.mealItemServingUnitsColumn.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Item Contributions:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Meal Contributions:";
            // 
            // AddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 438);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemsInMealListView);
            this.Controls.Add(this.mealContribsListView);
            this.Controls.Add(this.itemContribsListView);
            this.Controls.Add(this.addMealButton);
            this.Controls.Add(this.itemsInMealTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeFromMealButton);
            this.Controls.Add(this.addToMealButton);
            this.Controls.Add(this.mealTypeTextBox);
            this.Controls.Add(this.mealNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemCountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddMeal";
            this.Text = "Add Meal";
            this.Load += new System.EventHandler(this.AddMeal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemCountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mealNameTextBox;
        private System.Windows.Forms.TextBox mealTypeTextBox;
        private System.Windows.Forms.Button addToMealButton;
        private System.Windows.Forms.Button removeFromMealButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemsInMealTextBox;
        private System.Windows.Forms.Button addMealButton;
        private System.Windows.Forms.ListView itemContribsListView;
        private System.Windows.Forms.ColumnHeader itemContributionsIdColumn;
        private System.Windows.Forms.ColumnHeader itemContribsMeatColumn;
        private System.Windows.Forms.ColumnHeader itemContribsGrainsColumn;
        private System.Windows.Forms.ColumnHeader itemContribsFruitColumn;
        private System.Windows.Forms.ColumnHeader itemContribsDkGreenVegColumn;
        private System.Windows.Forms.ColumnHeader itemContribsRoVegColumn;
        private System.Windows.Forms.ColumnHeader itemContribsLegumesColumn;
        private System.Windows.Forms.ColumnHeader itemContribsStarchyVegColumn;
        private System.Windows.Forms.ColumnHeader itemContribsOtherVegColumn;
        private System.Windows.Forms.ColumnHeader itemContribsAddVegColumn;
        private System.Windows.Forms.ColumnHeader itemContribsTotalVegColumn;
        private System.Windows.Forms.ListView mealContribsListView;
        private System.Windows.Forms.ColumnHeader mealItemCountColumn;
        private System.Windows.Forms.ColumnHeader mealMeatTotalColumn;
        private System.Windows.Forms.ColumnHeader mealGrainsTotalColumn;
        private System.Windows.Forms.ColumnHeader mealFuitTotalColumn;
        private System.Windows.Forms.ColumnHeader mealDkGreenVegTotalColumn;
        private System.Windows.Forms.ColumnHeader mealRoVegTotalColumn;
        private System.Windows.Forms.ColumnHeader mealLegumesTotalColumn;
        private System.Windows.Forms.ColumnHeader mealStarchyVegTotalColumn;
        private System.Windows.Forms.ColumnHeader mealOtherVegTotalColumn;
        private System.Windows.Forms.ColumnHeader mealAddVegTotalColumn;
        private System.Windows.Forms.ColumnHeader mealTotalVegTotalColumn;
        private System.Windows.Forms.ColumnHeader itemIdColumn;
        private System.Windows.Forms.ColumnHeader itemNameColumn;
        private System.Windows.Forms.ColumnHeader itemDescriptionColumn;
        private System.Windows.Forms.ColumnHeader servingSizeColumn;
        private System.Windows.Forms.ColumnHeader servingUnitColumn;
        private System.Windows.Forms.ListView itemsInMealListView;
        private System.Windows.Forms.ColumnHeader mealItemIdColumn;
        private System.Windows.Forms.ColumnHeader mealItemNameColumn;
        private System.Windows.Forms.ColumnHeader mealItemDescriptionColumn;
        private System.Windows.Forms.ColumnHeader mealItemServingSizeColumn;
        private System.Windows.Forms.ColumnHeader mealItemServingUnitsColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}