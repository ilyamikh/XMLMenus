namespace XMLMenus
{
    partial class ModifyDay
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
            this.confirmChangesButton = new System.Windows.Forms.Button();
            this.itemServingSizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemIdcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuItemsListView = new System.Windows.Forms.ListView();
            this.itemServingUnitColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealsListView = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.breakfastNonReimburseableTextBox = new System.Windows.Forms.TextBox();
            this.lunchNonReimburseableTextBox = new System.Windows.Forms.TextBox();
            this.snackNonReimburseableTextBox = new System.Windows.Forms.TextBox();
            this.breakfastReducedTextBox = new System.Windows.Forms.TextBox();
            this.lunchReducedTextBox = new System.Windows.Forms.TextBox();
            this.snackReducedTextBox = new System.Windows.Forms.TextBox();
            this.breakfastPaidTextBox = new System.Windows.Forms.TextBox();
            this.lunchPaidTextBox = new System.Windows.Forms.TextBox();
            this.snackPaidTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.breakfastFreeTextBox = new System.Windows.Forms.TextBox();
            this.lunchFreeTextBox = new System.Windows.Forms.TextBox();
            this.snackFreeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuComboBox = new System.Windows.Forms.ComboBox();
            this.currentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fileNameInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmChangesButton
            // 
            this.confirmChangesButton.Location = new System.Drawing.Point(326, 133);
            this.confirmChangesButton.Name = "confirmChangesButton";
            this.confirmChangesButton.Size = new System.Drawing.Size(122, 23);
            this.confirmChangesButton.TabIndex = 60;
            this.confirmChangesButton.Text = "Confirm Changes";
            this.confirmChangesButton.UseVisualStyleBackColor = true;
            this.confirmChangesButton.Click += new System.EventHandler(this.confirmChangesButton_Click);
            // 
            // itemServingSizeColumn
            // 
            this.itemServingSizeColumn.Text = "Serving Size";
            this.itemServingSizeColumn.Width = 100;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.Text = "Name";
            this.itemNameColumn.Width = 175;
            // 
            // itemIdcolumn
            // 
            this.itemIdcolumn.Text = "ID";
            this.itemIdcolumn.Width = 30;
            // 
            // menuItemsListView
            // 
            this.menuItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemIdcolumn,
            this.itemNameColumn,
            this.itemServingSizeColumn,
            this.itemServingUnitColumn});
            this.menuItemsListView.FullRowSelect = true;
            this.menuItemsListView.Location = new System.Drawing.Point(10, 207);
            this.menuItemsListView.MultiSelect = false;
            this.menuItemsListView.Name = "menuItemsListView";
            this.menuItemsListView.Size = new System.Drawing.Size(507, 139);
            this.menuItemsListView.TabIndex = 59;
            this.menuItemsListView.UseCompatibleStateImageBehavior = false;
            this.menuItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // itemServingUnitColumn
            // 
            this.itemServingUnitColumn.Text = "Serving Unit";
            this.itemServingUnitColumn.Width = 105;
            // 
            // mealTypeColumn
            // 
            this.mealTypeColumn.Text = "Type";
            this.mealTypeColumn.Width = 86;
            // 
            // mealNameColumn
            // 
            this.mealNameColumn.Text = "Name";
            this.mealNameColumn.Width = 125;
            // 
            // mealIdColumn
            // 
            this.mealIdColumn.Text = "ID";
            this.mealIdColumn.Width = 30;
            // 
            // mealsListView
            // 
            this.mealsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mealIdColumn,
            this.mealNameColumn,
            this.mealTypeColumn});
            this.mealsListView.FullRowSelect = true;
            this.mealsListView.Location = new System.Drawing.Point(10, 100);
            this.mealsListView.MultiSelect = false;
            this.mealsListView.Name = "mealsListView";
            this.mealsListView.Size = new System.Drawing.Size(263, 101);
            this.mealsListView.TabIndex = 58;
            this.mealsListView.UseCompatibleStateImageBehavior = false;
            this.mealsListView.View = System.Windows.Forms.View.Details;
            this.mealsListView.SelectedIndexChanged += new System.EventHandler(this.mealsListView_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Non-Reimburseable";
            // 
            // breakfastNonReimburseableTextBox
            // 
            this.breakfastNonReimburseableTextBox.Location = new System.Drawing.Point(444, 21);
            this.breakfastNonReimburseableTextBox.Name = "breakfastNonReimburseableTextBox";
            this.breakfastNonReimburseableTextBox.Size = new System.Drawing.Size(41, 20);
            this.breakfastNonReimburseableTextBox.TabIndex = 48;
            this.breakfastNonReimburseableTextBox.Text = "0";
            // 
            // lunchNonReimburseableTextBox
            // 
            this.lunchNonReimburseableTextBox.Location = new System.Drawing.Point(444, 48);
            this.lunchNonReimburseableTextBox.Name = "lunchNonReimburseableTextBox";
            this.lunchNonReimburseableTextBox.Size = new System.Drawing.Size(41, 20);
            this.lunchNonReimburseableTextBox.TabIndex = 49;
            this.lunchNonReimburseableTextBox.Text = "0";
            // 
            // snackNonReimburseableTextBox
            // 
            this.snackNonReimburseableTextBox.Location = new System.Drawing.Point(444, 74);
            this.snackNonReimburseableTextBox.Name = "snackNonReimburseableTextBox";
            this.snackNonReimburseableTextBox.Size = new System.Drawing.Size(41, 20);
            this.snackNonReimburseableTextBox.TabIndex = 51;
            this.snackNonReimburseableTextBox.Text = "0";
            // 
            // breakfastReducedTextBox
            // 
            this.breakfastReducedTextBox.Location = new System.Drawing.Point(326, 21);
            this.breakfastReducedTextBox.Name = "breakfastReducedTextBox";
            this.breakfastReducedTextBox.Size = new System.Drawing.Size(41, 20);
            this.breakfastReducedTextBox.TabIndex = 40;
            this.breakfastReducedTextBox.Text = "0";
            // 
            // lunchReducedTextBox
            // 
            this.lunchReducedTextBox.Location = new System.Drawing.Point(326, 48);
            this.lunchReducedTextBox.Name = "lunchReducedTextBox";
            this.lunchReducedTextBox.Size = new System.Drawing.Size(41, 20);
            this.lunchReducedTextBox.TabIndex = 43;
            this.lunchReducedTextBox.Text = "0";
            // 
            // snackReducedTextBox
            // 
            this.snackReducedTextBox.Location = new System.Drawing.Point(326, 74);
            this.snackReducedTextBox.Name = "snackReducedTextBox";
            this.snackReducedTextBox.Size = new System.Drawing.Size(41, 20);
            this.snackReducedTextBox.TabIndex = 46;
            this.snackReducedTextBox.Text = "0";
            // 
            // breakfastPaidTextBox
            // 
            this.breakfastPaidTextBox.Location = new System.Drawing.Point(373, 21);
            this.breakfastPaidTextBox.Name = "breakfastPaidTextBox";
            this.breakfastPaidTextBox.Size = new System.Drawing.Size(41, 20);
            this.breakfastPaidTextBox.TabIndex = 41;
            this.breakfastPaidTextBox.Text = "0";
            // 
            // lunchPaidTextBox
            // 
            this.lunchPaidTextBox.Location = new System.Drawing.Point(373, 48);
            this.lunchPaidTextBox.Name = "lunchPaidTextBox";
            this.lunchPaidTextBox.Size = new System.Drawing.Size(41, 20);
            this.lunchPaidTextBox.TabIndex = 44;
            this.lunchPaidTextBox.Text = "0";
            // 
            // snackPaidTextBox
            // 
            this.snackPaidTextBox.Location = new System.Drawing.Point(373, 74);
            this.snackPaidTextBox.Name = "snackPaidTextBox";
            this.snackPaidTextBox.Size = new System.Drawing.Size(41, 20);
            this.snackPaidTextBox.TabIndex = 47;
            this.snackPaidTextBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Snack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Lunch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Breakfast";
            // 
            // breakfastFreeTextBox
            // 
            this.breakfastFreeTextBox.Location = new System.Drawing.Point(279, 22);
            this.breakfastFreeTextBox.Name = "breakfastFreeTextBox";
            this.breakfastFreeTextBox.Size = new System.Drawing.Size(41, 20);
            this.breakfastFreeTextBox.TabIndex = 39;
            this.breakfastFreeTextBox.Text = "0";
            // 
            // lunchFreeTextBox
            // 
            this.lunchFreeTextBox.Location = new System.Drawing.Point(279, 48);
            this.lunchFreeTextBox.Name = "lunchFreeTextBox";
            this.lunchFreeTextBox.Size = new System.Drawing.Size(41, 20);
            this.lunchFreeTextBox.TabIndex = 42;
            this.lunchFreeTextBox.Text = "0";
            // 
            // snackFreeTextBox
            // 
            this.snackFreeTextBox.Location = new System.Drawing.Point(279, 74);
            this.snackFreeTextBox.Name = "snackFreeTextBox";
            this.snackFreeTextBox.Size = new System.Drawing.Size(41, 20);
            this.snackFreeTextBox.TabIndex = 45;
            this.snackFreeTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Paid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Reduced";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Free";
            // 
            // menuComboBox
            // 
            this.menuComboBox.FormattingEnabled = true;
            this.menuComboBox.Location = new System.Drawing.Point(7, 48);
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(197, 21);
            this.menuComboBox.TabIndex = 38;
            this.menuComboBox.SelectedIndexChanged += new System.EventHandler(this.menuComboBox_SelectedIndexChanged);
            // 
            // currentDateTimePicker
            // 
            this.currentDateTimePicker.Enabled = false;
            this.currentDateTimePicker.Location = new System.Drawing.Point(7, 22);
            this.currentDateTimePicker.Name = "currentDateTimePicker";
            this.currentDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.currentDateTimePicker.TabIndex = 37;
            // 
            // fileNameInfoLabel
            // 
            this.fileNameInfoLabel.AutoSize = true;
            this.fileNameInfoLabel.Location = new System.Drawing.Point(7, 6);
            this.fileNameInfoLabel.Name = "fileNameInfoLabel";
            this.fileNameInfoLabel.Size = new System.Drawing.Size(114, 13);
            this.fileNameInfoLabel.TabIndex = 36;
            this.fileNameInfoLabel.Text = "Failed to pass filename";
            // 
            // ModifyDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 353);
            this.Controls.Add(this.confirmChangesButton);
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
            this.Name = "ModifyDay";
            this.Text = "Modify Day";
            this.Load += new System.EventHandler(this.ModifyDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmChangesButton;
        private System.Windows.Forms.ColumnHeader itemServingSizeColumn;
        private System.Windows.Forms.ColumnHeader itemNameColumn;
        private System.Windows.Forms.ColumnHeader itemIdcolumn;
        private System.Windows.Forms.ListView menuItemsListView;
        private System.Windows.Forms.ColumnHeader itemServingUnitColumn;
        private System.Windows.Forms.ColumnHeader mealTypeColumn;
        private System.Windows.Forms.ColumnHeader mealNameColumn;
        private System.Windows.Forms.ColumnHeader mealIdColumn;
        private System.Windows.Forms.ListView mealsListView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox breakfastNonReimburseableTextBox;
        private System.Windows.Forms.TextBox lunchNonReimburseableTextBox;
        private System.Windows.Forms.TextBox snackNonReimburseableTextBox;
        private System.Windows.Forms.TextBox breakfastReducedTextBox;
        private System.Windows.Forms.TextBox lunchReducedTextBox;
        private System.Windows.Forms.TextBox snackReducedTextBox;
        private System.Windows.Forms.TextBox breakfastPaidTextBox;
        private System.Windows.Forms.TextBox lunchPaidTextBox;
        private System.Windows.Forms.TextBox snackPaidTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox breakfastFreeTextBox;
        private System.Windows.Forms.TextBox lunchFreeTextBox;
        private System.Windows.Forms.TextBox snackFreeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox menuComboBox;
        private System.Windows.Forms.DateTimePicker currentDateTimePicker;
        private System.Windows.Forms.Label fileNameInfoLabel;
    }
}