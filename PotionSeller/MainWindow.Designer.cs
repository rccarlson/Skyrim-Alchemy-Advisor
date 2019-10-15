namespace PotionSeller
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
            this.effectsBox = new System.Windows.Forms.CheckedListBox();
            this.selectNoneEffectsButton = new System.Windows.Forms.Button();
            this.findEffectsExclusiveCheckBox = new System.Windows.Forms.CheckBox();
            this.liveUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.liveUpdateWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ingredientBox
            // 
            this.ingredientBox.CheckOnClick = true;
            this.ingredientBox.FormattingEnabled = true;
            this.ingredientBox.Location = new System.Drawing.Point(16, 33);
            this.ingredientBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ingredientBox.Name = "ingredientBox";
            this.ingredientBox.Size = new System.Drawing.Size(275, 667);
            this.ingredientBox.TabIndex = 1;
            // 
            // ingredientLabel
            // 
            this.ingredientLabel.AutoSize = true;
            this.ingredientLabel.Location = new System.Drawing.Point(16, 11);
            this.ingredientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ingredientLabel.Name = "ingredientLabel";
            this.ingredientLabel.Size = new System.Drawing.Size(127, 17);
            this.ingredientLabel.TabIndex = 2;
            this.ingredientLabel.Text = "Ingredients owned:";
            // 
            // potionListBox
            // 
            this.potionListBox.FormattingEnabled = true;
            this.potionListBox.HorizontalScrollbar = true;
            this.potionListBox.ItemHeight = 16;
            this.potionListBox.Location = new System.Drawing.Point(352, 33);
            this.potionListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.potionListBox.Name = "potionListBox";
            this.potionListBox.Size = new System.Drawing.Size(793, 260);
            this.potionListBox.TabIndex = 3;
            this.potionListBox.SelectedIndexChanged += new System.EventHandler(this.PotionListBox_SelectedIndexChanged);
            // 
            // calculatePotionsButton
            // 
            this.calculatePotionsButton.Location = new System.Drawing.Point(352, 301);
            this.calculatePotionsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculatePotionsButton.Name = "calculatePotionsButton";
            this.calculatePotionsButton.Size = new System.Drawing.Size(269, 28);
            this.calculatePotionsButton.TabIndex = 4;
            this.calculatePotionsButton.Text = "Find Valid Potions";
            this.calculatePotionsButton.UseVisualStyleBackColor = true;
            this.calculatePotionsButton.Click += new System.EventHandler(this.CalculatePotionsClick);
            // 
            // potionLabel
            // 
            this.potionLabel.AutoSize = true;
            this.potionLabel.Location = new System.Drawing.Point(348, 11);
            this.potionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.potionLabel.Name = "potionLabel";
            this.potionLabel.Size = new System.Drawing.Size(151, 17);
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
            this.potionOptions.Location = new System.Drawing.Point(352, 337);
            this.potionOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.potionOptions.Name = "potionOptions";
            this.potionOptions.Size = new System.Drawing.Size(793, 399);
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
            this.selectAllButton.Location = new System.Drawing.Point(19, 708);
            this.selectAllButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(129, 28);
            this.selectAllButton.TabIndex = 8;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // selectNoneButton
            // 
            this.selectNoneButton.Location = new System.Drawing.Point(162, 708);
            this.selectNoneButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectNoneButton.Name = "selectNoneButton";
            this.selectNoneButton.Size = new System.Drawing.Size(129, 28);
            this.selectNoneButton.TabIndex = 9;
            this.selectNoneButton.Text = "Select None";
            this.selectNoneButton.UseVisualStyleBackColor = true;
            this.selectNoneButton.Click += new System.EventHandler(this.SelectNoneButton_Click);
            // 
            // effectsBox
            // 
            this.effectsBox.CheckOnClick = true;
            this.effectsBox.FormattingEnabled = true;
            this.effectsBox.Location = new System.Drawing.Point(1155, 33);
            this.effectsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.effectsBox.Name = "effectsBox";
            this.effectsBox.Size = new System.Drawing.Size(299, 633);
            this.effectsBox.TabIndex = 10;
            // 
            // selectNoneEffectsButton
            // 
            this.selectNoneEffectsButton.Location = new System.Drawing.Point(1155, 679);
            this.selectNoneEffectsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectNoneEffectsButton.Name = "selectNoneEffectsButton";
            this.selectNoneEffectsButton.Size = new System.Drawing.Size(100, 28);
            this.selectNoneEffectsButton.TabIndex = 11;
            this.selectNoneEffectsButton.Text = "Select None";
            this.selectNoneEffectsButton.UseVisualStyleBackColor = true;
            this.selectNoneEffectsButton.Click += new System.EventHandler(this.selectNoneEffectsButton_Click);
            // 
            // findEffectsExclusiveCheckBox
            // 
            this.findEffectsExclusiveCheckBox.AutoSize = true;
            this.findEffectsExclusiveCheckBox.Location = new System.Drawing.Point(1155, 715);
            this.findEffectsExclusiveCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findEffectsExclusiveCheckBox.Name = "findEffectsExclusiveCheckBox";
            this.findEffectsExclusiveCheckBox.Size = new System.Drawing.Size(262, 21);
            this.findEffectsExclusiveCheckBox.TabIndex = 13;
            this.findEffectsExclusiveCheckBox.Text = "Find potions with ONLY these effects";
            this.findEffectsExclusiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // liveUpdateCheckBox
            // 
            this.liveUpdateCheckBox.AutoSize = true;
            this.liveUpdateCheckBox.Location = new System.Drawing.Point(628, 306);
            this.liveUpdateCheckBox.Name = "liveUpdateCheckBox";
            this.liveUpdateCheckBox.Size = new System.Drawing.Size(104, 21);
            this.liveUpdateCheckBox.TabIndex = 14;
            this.liveUpdateCheckBox.Text = "Live update";
            this.liveUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // liveUpdateWorker
            // 
            this.liveUpdateWorker.WorkerSupportsCancellation = true;
            this.liveUpdateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LiveUpdateWorker_DoWork);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 759);
            this.Controls.Add(this.liveUpdateCheckBox);
            this.Controls.Add(this.findEffectsExclusiveCheckBox);
            this.Controls.Add(this.selectNoneEffectsButton);
            this.Controls.Add(this.effectsBox);
            this.Controls.Add(this.selectNoneButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.potionOptions);
            this.Controls.Add(this.potionLabel);
            this.Controls.Add(this.calculatePotionsButton);
            this.Controls.Add(this.potionListBox);
            this.Controls.Add(this.ingredientLabel);
            this.Controls.Add(this.ingredientBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.CheckedListBox effectsBox;
        private System.Windows.Forms.Button selectNoneEffectsButton;
        private System.Windows.Forms.CheckBox findEffectsExclusiveCheckBox;
        private System.Windows.Forms.CheckBox liveUpdateCheckBox;
        private System.ComponentModel.BackgroundWorker liveUpdateWorker;
    }
}

