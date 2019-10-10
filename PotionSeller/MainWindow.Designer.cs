﻿namespace PotionSeller
{
    partial class MainWindow
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
            this.ingredientBox = new System.Windows.Forms.CheckedListBox();
            this.ingredientLabel = new System.Windows.Forms.Label();
            this.potionListBox = new System.Windows.Forms.ListBox();
            this.calculatePotionsButton = new System.Windows.Forms.Button();
            this.potionLabel = new System.Windows.Forms.Label();
            this.potionOptions = new System.Windows.Forms.ListView();
            this.ingredient1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredient2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredient3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectAllButton = new System.Windows.Forms.Button();
            this.selectNoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ingredientBox
            // 
            this.ingredientBox.CheckOnClick = true;
            this.ingredientBox.FormattingEnabled = true;
            this.ingredientBox.Location = new System.Drawing.Point(12, 27);
            this.ingredientBox.Name = "ingredientBox";
            this.ingredientBox.Size = new System.Drawing.Size(207, 679);
            this.ingredientBox.TabIndex = 1;
            // 
            // ingredientLabel
            // 
            this.ingredientLabel.AutoSize = true;
            this.ingredientLabel.Location = new System.Drawing.Point(12, 9);
            this.ingredientLabel.Name = "ingredientLabel";
            this.ingredientLabel.Size = new System.Drawing.Size(97, 13);
            this.ingredientLabel.TabIndex = 2;
            this.ingredientLabel.Text = "Ingredients owned:";
            // 
            // potionListBox
            // 
            this.potionListBox.FormattingEnabled = true;
            this.potionListBox.HorizontalScrollbar = true;
            this.potionListBox.Location = new System.Drawing.Point(264, 27);
            this.potionListBox.Name = "potionListBox";
            this.potionListBox.Size = new System.Drawing.Size(596, 212);
            this.potionListBox.TabIndex = 3;
            this.potionListBox.SelectedIndexChanged += new System.EventHandler(this.PotionListBox_SelectedIndexChanged);
            // 
            // calculatePotionsButton
            // 
            this.calculatePotionsButton.Location = new System.Drawing.Point(518, 245);
            this.calculatePotionsButton.Name = "calculatePotionsButton";
            this.calculatePotionsButton.Size = new System.Drawing.Size(104, 23);
            this.calculatePotionsButton.TabIndex = 4;
            this.calculatePotionsButton.Text = "Find Valid Potions";
            this.calculatePotionsButton.UseVisualStyleBackColor = true;
            this.calculatePotionsButton.Click += new System.EventHandler(this.CalculatePotions);
            // 
            // potionLabel
            // 
            this.potionLabel.AutoSize = true;
            this.potionLabel.Location = new System.Drawing.Point(261, 9);
            this.potionLabel.Name = "potionLabel";
            this.potionLabel.Size = new System.Drawing.Size(115, 13);
            this.potionLabel.TabIndex = 5;
            this.potionLabel.Text = "Potions you can make:";
            // 
            // potionOptions
            // 
            this.potionOptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ingredient1,
            this.ingredient2,
            this.ingredient3});
            this.potionOptions.HideSelection = false;
            this.potionOptions.Location = new System.Drawing.Point(264, 305);
            this.potionOptions.Name = "potionOptions";
            this.potionOptions.Size = new System.Drawing.Size(596, 414);
            this.potionOptions.TabIndex = 7;
            this.potionOptions.UseCompatibleStateImageBehavior = false;
            this.potionOptions.View = System.Windows.Forms.View.Details;
            // 
            // ingredient1
            // 
            this.ingredient1.Text = "Ingredient 1";
            this.ingredient1.Width = 200;
            // 
            // ingredient2
            // 
            this.ingredient2.Text = "Ingredient 2";
            this.ingredient2.Width = 200;
            // 
            // ingredient3
            // 
            this.ingredient3.Text = "Ingredient 3";
            this.ingredient3.Width = 200;
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(264, 276);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(97, 23);
            this.selectAllButton.TabIndex = 8;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // selectNoneButton
            // 
            this.selectNoneButton.Location = new System.Drawing.Point(264, 245);
            this.selectNoneButton.Name = "selectNoneButton";
            this.selectNoneButton.Size = new System.Drawing.Size(97, 23);
            this.selectNoneButton.TabIndex = 9;
            this.selectNoneButton.Text = "Select None";
            this.selectNoneButton.UseVisualStyleBackColor = true;
            this.selectNoneButton.Click += new System.EventHandler(this.SelectNoneButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 731);
            this.Controls.Add(this.selectNoneButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.potionOptions);
            this.Controls.Add(this.potionLabel);
            this.Controls.Add(this.calculatePotionsButton);
            this.Controls.Add(this.potionListBox);
            this.Controls.Add(this.ingredientLabel);
            this.Controls.Add(this.ingredientBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Potion Seller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ingredientBox;
        private System.Windows.Forms.Label ingredientLabel;
        private System.Windows.Forms.ListBox potionListBox;
        private System.Windows.Forms.Button calculatePotionsButton;
        private System.Windows.Forms.Label potionLabel;
        private System.Windows.Forms.ListView potionOptions;
        private System.Windows.Forms.ColumnHeader ingredient1;
        private System.Windows.Forms.ColumnHeader ingredient2;
        private System.Windows.Forms.ColumnHeader ingredient3;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button selectNoneButton;
    }
}
