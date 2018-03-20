namespace XMLMenus
{
    partial class ModifyIngredientDialog
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
            this.ingredientIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveChnagesButton = new System.Windows.Forms.Button();
            this.packageDescriptionText = new System.Windows.Forms.TextBox();
            this.packageUnitText = new System.Windows.Forms.TextBox();
            this.packageSizeText = new System.Windows.Forms.TextBox();
            this.servingUnitText = new System.Windows.Forms.TextBox();
            this.servingSizeText = new System.Windows.Forms.TextBox();
            this.foodDescriptionText = new System.Windows.Forms.TextBox();
            this.foodNameText = new System.Windows.Forms.TextBox();
            this.foodDescription = new System.Windows.Forms.Label();
            this.packageDescription = new System.Windows.Forms.Label();
            this.packageUnitLabel = new System.Windows.Forms.Label();
            this.packageSizeValueLabel = new System.Windows.Forms.Label();
            this.servingUnitLabel = new System.Windows.Forms.Label();
            this.servingValLabel = new System.Windows.Forms.Label();
            this.foodNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ingredientIdTextBox
            // 
            this.ingredientIdTextBox.Enabled = false;
            this.ingredientIdTextBox.Location = new System.Drawing.Point(358, 2);
            this.ingredientIdTextBox.Name = "ingredientIdTextBox";
            this.ingredientIdTextBox.Size = new System.Drawing.Size(38, 20);
            this.ingredientIdTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingredient Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingredient ID:";
            // 
            // saveChnagesButton
            // 
            this.saveChnagesButton.Location = new System.Drawing.Point(294, 211);
            this.saveChnagesButton.Name = "saveChnagesButton";
            this.saveChnagesButton.Size = new System.Drawing.Size(101, 23);
            this.saveChnagesButton.TabIndex = 22;
            this.saveChnagesButton.Text = "Save Changes";
            this.saveChnagesButton.UseVisualStyleBackColor = true;
            this.saveChnagesButton.Click += new System.EventHandler(this.saveChnagesButton_Click);
            // 
            // packageDescriptionText
            // 
            this.packageDescriptionText.Location = new System.Drawing.Point(18, 172);
            this.packageDescriptionText.Name = "packageDescriptionText";
            this.packageDescriptionText.Size = new System.Drawing.Size(378, 20);
            this.packageDescriptionText.TabIndex = 20;
            // 
            // packageUnitText
            // 
            this.packageUnitText.Location = new System.Drawing.Point(294, 136);
            this.packageUnitText.Name = "packageUnitText";
            this.packageUnitText.Size = new System.Drawing.Size(102, 20);
            this.packageUnitText.TabIndex = 18;
            // 
            // packageSizeText
            // 
            this.packageSizeText.Location = new System.Drawing.Point(94, 133);
            this.packageSizeText.Name = "packageSizeText";
            this.packageSizeText.Size = new System.Drawing.Size(101, 20);
            this.packageSizeText.TabIndex = 16;
            this.packageSizeText.Text = "0";
            // 
            // servingUnitText
            // 
            this.servingUnitText.Location = new System.Drawing.Point(294, 60);
            this.servingUnitText.Name = "servingUnitText";
            this.servingUnitText.Size = new System.Drawing.Size(102, 20);
            this.servingUnitText.TabIndex = 13;
            // 
            // servingSizeText
            // 
            this.servingSizeText.Location = new System.Drawing.Point(94, 60);
            this.servingSizeText.Name = "servingSizeText";
            this.servingSizeText.Size = new System.Drawing.Size(102, 20);
            this.servingSizeText.TabIndex = 11;
            this.servingSizeText.Text = "0";
            // 
            // foodDescriptionText
            // 
            this.foodDescriptionText.Location = new System.Drawing.Point(15, 99);
            this.foodDescriptionText.Name = "foodDescriptionText";
            this.foodDescriptionText.Size = new System.Drawing.Size(381, 20);
            this.foodDescriptionText.TabIndex = 15;
            // 
            // foodNameText
            // 
            this.foodNameText.Location = new System.Drawing.Point(83, 31);
            this.foodNameText.Name = "foodNameText";
            this.foodNameText.Size = new System.Drawing.Size(173, 20);
            this.foodNameText.TabIndex = 10;
            // 
            // foodDescription
            // 
            this.foodDescription.AutoSize = true;
            this.foodDescription.Location = new System.Drawing.Point(12, 83);
            this.foodDescription.Name = "foodDescription";
            this.foodDescription.Size = new System.Drawing.Size(87, 13);
            this.foodDescription.TabIndex = 23;
            this.foodDescription.Text = "Food Description";
            // 
            // packageDescription
            // 
            this.packageDescription.AutoSize = true;
            this.packageDescription.Location = new System.Drawing.Point(15, 156);
            this.packageDescription.Name = "packageDescription";
            this.packageDescription.Size = new System.Drawing.Size(106, 13);
            this.packageDescription.TabIndex = 21;
            this.packageDescription.Text = "Package Description";
            // 
            // packageUnitLabel
            // 
            this.packageUnitLabel.AutoSize = true;
            this.packageUnitLabel.Location = new System.Drawing.Point(216, 136);
            this.packageUnitLabel.Name = "packageUnitLabel";
            this.packageUnitLabel.Size = new System.Drawing.Size(72, 13);
            this.packageUnitLabel.TabIndex = 19;
            this.packageUnitLabel.Text = "Package Unit";
            // 
            // packageSizeValueLabel
            // 
            this.packageSizeValueLabel.AutoSize = true;
            this.packageSizeValueLabel.Location = new System.Drawing.Point(15, 136);
            this.packageSizeValueLabel.Name = "packageSizeValueLabel";
            this.packageSizeValueLabel.Size = new System.Drawing.Size(73, 13);
            this.packageSizeValueLabel.TabIndex = 17;
            this.packageSizeValueLabel.Text = "Package Size";
            // 
            // servingUnitLabel
            // 
            this.servingUnitLabel.AutoSize = true;
            this.servingUnitLabel.Location = new System.Drawing.Point(216, 63);
            this.servingUnitLabel.Name = "servingUnitLabel";
            this.servingUnitLabel.Size = new System.Drawing.Size(65, 13);
            this.servingUnitLabel.TabIndex = 14;
            this.servingUnitLabel.Text = "Serving Unit";
            // 
            // servingValLabel
            // 
            this.servingValLabel.AutoSize = true;
            this.servingValLabel.Location = new System.Drawing.Point(15, 60);
            this.servingValLabel.Name = "servingValLabel";
            this.servingValLabel.Size = new System.Drawing.Size(66, 13);
            this.servingValLabel.TabIndex = 12;
            this.servingValLabel.Text = "Serving Size";
            // 
            // foodNameLabel
            // 
            this.foodNameLabel.AutoSize = true;
            this.foodNameLabel.Location = new System.Drawing.Point(15, 34);
            this.foodNameLabel.Name = "foodNameLabel";
            this.foodNameLabel.Size = new System.Drawing.Size(62, 13);
            this.foodNameLabel.TabIndex = 9;
            this.foodNameLabel.Text = "Food Name";
            // 
            // ModifyIngredientDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 253);
            this.Controls.Add(this.saveChnagesButton);
            this.Controls.Add(this.packageDescriptionText);
            this.Controls.Add(this.packageUnitText);
            this.Controls.Add(this.packageSizeText);
            this.Controls.Add(this.servingUnitText);
            this.Controls.Add(this.servingSizeText);
            this.Controls.Add(this.foodDescriptionText);
            this.Controls.Add(this.foodNameText);
            this.Controls.Add(this.foodDescription);
            this.Controls.Add(this.packageDescription);
            this.Controls.Add(this.packageUnitLabel);
            this.Controls.Add(this.packageSizeValueLabel);
            this.Controls.Add(this.servingUnitLabel);
            this.Controls.Add(this.servingValLabel);
            this.Controls.Add(this.foodNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingredientIdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ModifyIngredientDialog";
            this.Text = "Modify Selected Ingredient";
            this.Load += new System.EventHandler(this.ModifyIngredientDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ingredientIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveChnagesButton;
        private System.Windows.Forms.TextBox packageDescriptionText;
        private System.Windows.Forms.TextBox packageUnitText;
        private System.Windows.Forms.TextBox packageSizeText;
        private System.Windows.Forms.TextBox servingUnitText;
        private System.Windows.Forms.TextBox servingSizeText;
        private System.Windows.Forms.TextBox foodDescriptionText;
        private System.Windows.Forms.TextBox foodNameText;
        private System.Windows.Forms.Label foodDescription;
        private System.Windows.Forms.Label packageDescription;
        private System.Windows.Forms.Label packageUnitLabel;
        private System.Windows.Forms.Label packageSizeValueLabel;
        private System.Windows.Forms.Label servingUnitLabel;
        private System.Windows.Forms.Label servingValLabel;
        private System.Windows.Forms.Label foodNameLabel;
    }
}