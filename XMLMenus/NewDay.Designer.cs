namespace XMLMenus
{
    partial class NewDay
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
            this.fileNameInfoLabel = new System.Windows.Forms.Label();
            this.menuComboBox = new System.Windows.Forms.ComboBox();
            this.currentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.snackFreeTextBox = new System.Windows.Forms.TextBox();
            this.lunchFreeTextBox = new System.Windows.Forms.TextBox();
            this.breakfastFreeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.breakfastPaidTextBox = new System.Windows.Forms.TextBox();
            this.lunchPaidTextBox = new System.Windows.Forms.TextBox();
            this.snackPaidTextBox = new System.Windows.Forms.TextBox();
            this.breakfastReducedTextBox = new System.Windows.Forms.TextBox();
            this.lunchReducedTextBox = new System.Windows.Forms.TextBox();
            this.snackReducedTextBox = new System.Windows.Forms.TextBox();
            this.breakfastNonReimburseableTextBox = new System.Windows.Forms.TextBox();
            this.lunchNonReimburseableTextBox = new System.Windows.Forms.TextBox();
            this.snackNonReimburseableTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mealsListView = new System.Windows.Forms.ListView();
            this.mealIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuItemsListView = new System.Windows.Forms.ListView();
            this.itemIdcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemServingSizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemServingUnitColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addDayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileNameInfoLabel
            // 
            this.fileNameInfoLabel.AutoSize = true;
            this.fileNameInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.fileNameInfoLabel.Name = "fileNameInfoLabel";
            this.fileNameInfoLabel.Size = new System.Drawing.Size(114, 13);
            this.fileNameInfoLabel.TabIndex = 0;
            this.fileNameInfoLabel.Text = "Failed to pass filename";
            // 
            // menuComboBox
            // 
            this.menuComboBox.FormattingEnabled = true;
            this.menuComboBox.Location = new System.Drawing.Point(12, 51);
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(197, 21);
            this.menuComboBox.TabIndex = 2;
            this.menuComboBox.SelectedIndexChanged += new System.EventHandler(this.menuComboBox_SelectedIndexChanged);
            this.menuComboBox.SelectionChangeCommitted += new System.EventHandler(this.menuComboBox_SelectionChangeCommitted);
            // 
            // currentDateTimePicker
            // 
            this.currentDateTimePicker.Location = new System.Drawing.Point(12, 25);
            this.currentDateTimePicker.Name = "currentDateTimePicker";
            this.currentDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.currentDateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Free";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Reduced";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Paid";
            // 
            // snackFreeTextBox
            // 
            this.snackFreeTextBox.Location = new System.Drawing.Point(284, 77);
            this.snackFreeTextBox.Name = "snackFreeTextBox";
            this.snackFreeTextBox.Size = new System.Drawing.Size(41, 20);
            this.snackFreeTextBox.TabIndex = 9;
            this.snackFreeTextBox.Text = "0";
            // 
            // lunchFreeTextBox
            // 
            this.lunchFreeTextBox.Location = new System.Drawing.Point(284, 51);
            this.lunchFreeTextBox.Name = "lunchFreeTextBox";
            this.lunchFreeTextBox.Size = new System.Drawing.Size(41, 20);
            this.lunchFreeTextBox.TabIndex = 6;
            this.lunchFreeTextBox.Text = "0";
            // 
            // breakfastFreeTextBox
            // 
            this.breakfastFreeTextBox.Location = new System.Drawing.Point(284, 25);
            this.breakfastFreeTextBox.Name = "breakfastFreeTextBox";
            this.breakfastFreeTextBox.Size = new System.Drawing.Size(41, 20);
            this.breakfastFreeTextBox.TabIndex = 3;
            this.breakfastFreeTextBox.Text = "0";
            this.breakfastFreeTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Breakfast";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Lunch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Snack";
            // 
            // breakfastPaidTextBox
            // 
            this.breakfastPaidTextBox.Location = new System.Drawing.Point(378, 24);
            this.breakfastPaidTextBox.Name = "breakfastPaidTextBox";
            this.breakfastPaidTextBox.Size = new System.Drawing.Size(41, 20);
            this.breakfastPaidTextBox.TabIndex = 5;
            this.breakfastPaidTextBox.Text = "0";
            // 
            // lunchPaidTextBox
            // 
            this.lunchPaidTextBox.Location = new System.Drawing.Point(378, 51);
            this.lunchPaidTextBox.Name = "lunchPaidTextBox";
            this.lunchPaidTextBox.Size = new System.Drawing.Size(41, 20);
            this.lunchPaidTextBox.TabIndex = 8;
            this.lunchPaidTextBox.Text = "0";
            // 
            // snackPaidTextBox
            // 
            this.snackPaidTextBox.Location = new System.Drawing.Point(378, 77);
            this.snackPaidTextBox.Name = "snackPaidTextBox";
            this.snackPaidTextBox.Size = new System.Drawing.Size(41, 20);
            this.snackPaidTextBox.TabIndex = 11;
            this.snackPaidTextBox.Text = "0";
            // 
            // breakfastReducedTextBox
            // 
            this.breakfastReducedTextBox.Location = new System.Drawing.Point(331, 24);
            this.breakfastReducedTextBox.Name = "breakfastReducedTextBox";
            this.breakfastReducedTextBox.Size = new System.Drawing.Size(41, 20);
            this.breakfastReducedTextBox.TabIndex = 4;
            this.breakfastReducedTextBox.Text = "0";
            // 
            // lunchReducedTextBox
            // 
            this.lunchReducedTextBox.Location = new System.Drawing.Point(331, 51);
            this.lunchReducedTextBox.Name = "lunchReducedTextBox";
            this.lunchReducedTextBox.Size = new System.Drawing.Size(41, 20);
            this.lunchReducedTextBox.TabIndex = 7;
            this.lunchReducedTextBox.Text = "0";
            // 
            // snackReducedTextBox
            // 
            this.snackReducedTextBox.Location = new System.Drawing.Point(331, 77);
            this.snackReducedTextBox.Name = "snackReducedTextBox";
            this.snackReducedTextBox.Size = new System.Drawing.Size(41, 20);
            this.snackReducedTextBox.TabIndex = 10;
            this.snackReducedTextBox.Text = "0";
            // 
            // breakfastNonReimburseableTextBox
            // 
            this.breakfastNonReimburseableTextBox.Location = new System.Drawing.Point(449, 24);
            this.breakfastNonReimburseableTextBox.Name = "breakfastNonReimburseableTextBox";
            this.breakfastNonReimburseableTextBox.Size = new System.Drawing.Size(41, 20);
            this.breakfastNonReimburseableTextBox.TabIndex = 12;
            this.breakfastNonReimburseableTextBox.Text = "20";
            // 
            // lunchNonReimburseableTextBox
            // 
            this.lunchNonReimburseableTextBox.Location = new System.Drawing.Point(449, 51);
            this.lunchNonReimburseableTextBox.Name = "lunchNonReimburseableTextBox";
            this.lunchNonReimburseableTextBox.Size = new System.Drawing.Size(41, 20);
            this.lunchNonReimburseableTextBox.TabIndex = 13;
            this.lunchNonReimburseableTextBox.Text = "20";
            // 
            // snackNonReimburseableTextBox
            // 
            this.snackNonReimburseableTextBox.Location = new System.Drawing.Point(449, 77);
            this.snackNonReimburseableTextBox.Name = "snackNonReimburseableTextBox";
            this.snackNonReimburseableTextBox.Size = new System.Drawing.Size(41, 20);
            this.snackNonReimburseableTextBox.TabIndex = 14;
            this.snackNonReimburseableTextBox.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Non-Reimburseable";
            // 
            // mealsListView
            // 
            this.mealsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mealIdColumn,
            this.mealNameColumn,
            this.mealTypeColumn});
            this.mealsListView.FullRowSelect = true;
            this.mealsListView.Location = new System.Drawing.Point(15, 103);
            this.mealsListView.MultiSelect = false;
            this.mealsListView.Name = "mealsListView";
            this.mealsListView.Size = new System.Drawing.Size(263, 101);
            this.mealsListView.TabIndex = 33;
            this.mealsListView.UseCompatibleStateImageBehavior = false;
            this.mealsListView.View = System.Windows.Forms.View.Details;
            this.mealsListView.SelectedIndexChanged += new System.EventHandler(this.mealsListView_SelectedIndexChanged);
            // 
            // mealIdColumn
            // 
            this.mealIdColumn.Text = "ID";
            this.mealIdColumn.Width = 30;
            // 
            // mealNameColumn
            // 
            this.mealNameColumn.Text = "Name";
            this.mealNameColumn.Width = 125;
            // 
            // mealTypeColumn
            // 
            this.mealTypeColumn.Text = "Type";
            this.mealTypeColumn.Width = 86;
            // 
            // menuItemsListView
            // 
            this.menuItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemIdcolumn,
            this.itemNameColumn,
            this.itemServingSizeColumn,
            this.itemServingUnitColumn});
            this.menuItemsListView.FullRowSelect = true;
            this.menuItemsListView.Location = new System.Drawing.Point(15, 210);
            this.menuItemsListView.MultiSelect = false;
            this.menuItemsListView.Name = "menuItemsListView";
            this.menuItemsListView.Size = new System.Drawing.Size(507, 139);
            this.menuItemsListView.TabIndex = 34;
            this.menuItemsListView.UseCompatibleStateImageBehavior = false;
            this.menuItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // itemIdcolumn
            // 
            this.itemIdcolumn.Text = "ID";
            this.itemIdcolumn.Width = 30;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.Text = "Name";
            this.itemNameColumn.Width = 175;
            // 
            // itemServingSizeColumn
            // 
            this.itemServingSizeColumn.Text = "Serving Size";
            this.itemServingSizeColumn.Width = 100;
            // 
            // itemServingUnitColumn
            // 
            this.itemServingUnitColumn.Text = "Serving Unit";
            this.itemServingUnitColumn.Width = 105;
            // 
            // addDayButton
            // 
            this.addDayButton.Location = new System.Drawing.Point(378, 136);
            this.addDayButton.Name = "addDayButton";
            this.addDayButton.Size = new System.Drawing.Size(75, 23);
            this.addDayButton.TabIndex = 35;
            this.addDayButton.Text = "Add Day";
            this.addDayButton.UseVisualStyleBackColor = true;
            this.addDayButton.Click += new System.EventHandler(this.addDayButton_Click);
            // 
            // NewDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 358);
            this.Controls.Add(this.addDayButton);
            this.Controls.Add(this.menuItemsListView);
            this.Controls.Add(this.mealsListView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.breakfastNonReimburseableTextBox);
            this.Controls.Add(this.lunchNonReimburseableTextBox);
            this.Controls.Add(this.snackNonReimburseableTextBox);
            this.Controls.Add(this.breakfastReducedTextBox);
            this.Controls.Add(this.lunchReducedTextBox);
            this.Controls.Add(this.snackReducedTextBox);
            this.Controls.Add(this.breakfastPaidTextBox);
            this.Controls.Add(this.lunchPaidTextBox);
            this.Controls.Add(this.snackPaidTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.breakfastFreeTextBox);
            this.Controls.Add(this.lunchFreeTextBox);
            this.Controls.Add(this.snackFreeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuComboBox);
            this.Controls.Add(this.currentDateTimePicker);
            this.Controls.Add(this.fileNameInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewDay";
            this.Text = "New Day";
            this.Load += new System.EventHandler(this.NewDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileNameInfoLabel;
        private System.Windows.Forms.ComboBox menuComboBox;
        private System.Windows.Forms.DateTimePicker currentDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox snackFreeTextBox;
        private System.Windows.Forms.TextBox lunchFreeTextBox;
        private System.Windows.Forms.TextBox breakfastFreeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox breakfastPaidTextBox;
        private System.Windows.Forms.TextBox lunchPaidTextBox;
        private System.Windows.Forms.TextBox snackPaidTextBox;
        private System.Windows.Forms.TextBox breakfastReducedTextBox;
        private System.Windows.Forms.TextBox lunchReducedTextBox;
        private System.Windows.Forms.TextBox snackReducedTextBox;
        private System.Windows.Forms.TextBox breakfastNonReimburseableTextBox;
        private System.Windows.Forms.TextBox lunchNonReimburseableTextBox;
        private System.Windows.Forms.TextBox snackNonReimburseableTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView mealsListView;
        private System.Windows.Forms.ListView menuItemsListView;
        private System.Windows.Forms.Button addDayButton;
        private System.Windows.Forms.ColumnHeader mealIdColumn;
        private System.Windows.Forms.ColumnHeader mealNameColumn;
        private System.Windows.Forms.ColumnHeader mealTypeColumn;
        private System.Windows.Forms.ColumnHeader itemIdcolumn;
        private System.Windows.Forms.ColumnHeader itemNameColumn;
        private System.Windows.Forms.ColumnHeader itemServingSizeColumn;
        private System.Windows.Forms.ColumnHeader itemServingUnitColumn;
    }
}