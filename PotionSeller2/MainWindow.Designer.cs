namespace PotionSeller2
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
            this.effectBox = new System.Windows.Forms.CheckedListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.potionDetail = new System.Windows.Forms.ListView();
            this.ingredient1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredient2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredient3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchResultBox = new System.Windows.Forms.ListView();
            this.effects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.potionValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alchemySkill = new System.Windows.Forms.DomainUpDown();
            this.alchemySkillLabel = new System.Windows.Forms.Label();
            this.fortifyAlchemyLevel = new System.Windows.Forms.DomainUpDown();
            this.fortifyAlchemyCheckBox = new System.Windows.Forms.CheckBox();
            this.alchemistPerkLevel = new System.Windows.Forms.DomainUpDown();
            this.physicianPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.alchemistPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.benefactorPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.poisonerPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.purityPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ingredientBox
            // 
            this.ingredientBox.CheckOnClick = true;
            this.ingredientBox.FormattingEnabled = true;
            this.ingredientBox.Location = new System.Drawing.Point(12, 12);
            this.ingredientBox.Name = "ingredientBox";
            this.ingredientBox.Size = new System.Drawing.Size(274, 514);
            this.ingredientBox.TabIndex = 0;
            // 
            // effectBox
            // 
            this.effectBox.CheckOnClick = true;
            this.effectBox.FormattingEnabled = true;
            this.effectBox.Location = new System.Drawing.Point(292, 12);
            this.effectBox.Name = "effectBox";
            this.effectBox.Size = new System.Drawing.Size(283, 514);
            this.effectBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(581, 230);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Search";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // potionDetail
            // 
            this.potionDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ingredient1,
            this.ingredient2,
            this.ingredient3,
            this.value});
            this.potionDetail.HideSelection = false;
            this.potionDetail.Location = new System.Drawing.Point(581, 259);
            this.potionDetail.Name = "potionDetail";
            this.potionDetail.Size = new System.Drawing.Size(364, 267);
            this.potionDetail.TabIndex = 4;
            this.potionDetail.UseCompatibleStateImageBehavior = false;
            this.potionDetail.View = System.Windows.Forms.View.Details;
            // 
            // ingredient1
            // 
            this.ingredient1.Text = "Ingredient 1";
            this.ingredient1.Width = 87;
            // 
            // ingredient2
            // 
            this.ingredient2.Text = "Ingredient 2";
            this.ingredient2.Width = 81;
            // 
            // ingredient3
            // 
            this.ingredient3.Text = "Ingredient 3";
            this.ingredient3.Width = 88;
            // 
            // value
            // 
            this.value.Text = "Value";
            // 
            // searchResultBox
            // 
            this.searchResultBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.effects,
            this.potionValue});
            this.searchResultBox.HideSelection = false;
            this.searchResultBox.Location = new System.Drawing.Point(581, 12);
            this.searchResultBox.Name = "searchResultBox";
            this.searchResultBox.Size = new System.Drawing.Size(364, 212);
            this.searchResultBox.TabIndex = 5;
            this.searchResultBox.UseCompatibleStateImageBehavior = false;
            this.searchResultBox.View = System.Windows.Forms.View.Details;
            // 
            // effects
            // 
            this.effects.Text = "Effects";
            this.effects.Width = 167;
            // 
            // potionValue
            // 
            this.potionValue.Text = "Value";
            // 
            // alchemySkill
            // 
            this.alchemySkill.Location = new System.Drawing.Point(1078, 12);
            this.alchemySkill.Name = "alchemySkill";
            this.alchemySkill.Size = new System.Drawing.Size(60, 22);
            this.alchemySkill.TabIndex = 6;
            this.alchemySkill.Text = "15";
            // 
            // alchemySkillLabel
            // 
            this.alchemySkillLabel.AutoSize = true;
            this.alchemySkillLabel.Location = new System.Drawing.Point(951, 12);
            this.alchemySkillLabel.Name = "alchemySkillLabel";
            this.alchemySkillLabel.Size = new System.Drawing.Size(90, 17);
            this.alchemySkillLabel.TabIndex = 7;
            this.alchemySkillLabel.Text = "Alchemy Skill";
            // 
            // fortifyAlchemyLevel
            // 
            this.fortifyAlchemyLevel.Location = new System.Drawing.Point(1078, 41);
            this.fortifyAlchemyLevel.Name = "fortifyAlchemyLevel";
            this.fortifyAlchemyLevel.Size = new System.Drawing.Size(60, 22);
            this.fortifyAlchemyLevel.TabIndex = 8;
            this.fortifyAlchemyLevel.Text = "0%";
            // 
            // fortifyAlchemyCheckBox
            // 
            this.fortifyAlchemyCheckBox.AutoSize = true;
            this.fortifyAlchemyCheckBox.Location = new System.Drawing.Point(954, 41);
            this.fortifyAlchemyCheckBox.Name = "fortifyAlchemyCheckBox";
            this.fortifyAlchemyCheckBox.Size = new System.Drawing.Size(126, 21);
            this.fortifyAlchemyCheckBox.TabIndex = 9;
            this.fortifyAlchemyCheckBox.Text = "Fortify Alchemy";
            this.fortifyAlchemyCheckBox.UseVisualStyleBackColor = true;
            // 
            // alchemistPerkLevel
            // 
            this.alchemistPerkLevel.Location = new System.Drawing.Point(1078, 69);
            this.alchemistPerkLevel.Name = "alchemistPerkLevel";
            this.alchemistPerkLevel.Size = new System.Drawing.Size(60, 22);
            this.alchemistPerkLevel.TabIndex = 11;
            this.alchemistPerkLevel.Text = "0%";
            // 
            // physicianPerkCheckBox
            // 
            this.physicianPerkCheckBox.AutoSize = true;
            this.physicianPerkCheckBox.Location = new System.Drawing.Point(954, 91);
            this.physicianPerkCheckBox.Name = "physicianPerkCheckBox";
            this.physicianPerkCheckBox.Size = new System.Drawing.Size(123, 21);
            this.physicianPerkCheckBox.TabIndex = 13;
            this.physicianPerkCheckBox.Text = "Physician Perk";
            this.physicianPerkCheckBox.UseVisualStyleBackColor = true;
            // 
            // alchemistPerkCheckBox
            // 
            this.alchemistPerkCheckBox.AutoSize = true;
            this.alchemistPerkCheckBox.Location = new System.Drawing.Point(954, 68);
            this.alchemistPerkCheckBox.Name = "alchemistPerkCheckBox";
            this.alchemistPerkCheckBox.Size = new System.Drawing.Size(123, 21);
            this.alchemistPerkCheckBox.TabIndex = 14;
            this.alchemistPerkCheckBox.Text = "Alchemist Perk";
            this.alchemistPerkCheckBox.UseVisualStyleBackColor = true;
            // 
            // benefactorPerkCheckBox
            // 
            this.benefactorPerkCheckBox.AutoSize = true;
            this.benefactorPerkCheckBox.Location = new System.Drawing.Point(954, 118);
            this.benefactorPerkCheckBox.Name = "benefactorPerkCheckBox";
            this.benefactorPerkCheckBox.Size = new System.Drawing.Size(132, 21);
            this.benefactorPerkCheckBox.TabIndex = 15;
            this.benefactorPerkCheckBox.Text = "Benefactor Perk";
            this.benefactorPerkCheckBox.UseVisualStyleBackColor = true;
            // 
            // poisonerPerkCheckBox
            // 
            this.poisonerPerkCheckBox.AutoSize = true;
            this.poisonerPerkCheckBox.Location = new System.Drawing.Point(954, 145);
            this.poisonerPerkCheckBox.Name = "poisonerPerkCheckBox";
            this.poisonerPerkCheckBox.Size = new System.Drawing.Size(119, 21);
            this.poisonerPerkCheckBox.TabIndex = 16;
            this.poisonerPerkCheckBox.Text = "Poisoner Perk";
            this.poisonerPerkCheckBox.UseVisualStyleBackColor = true;
            // 
            // purityPerkCheckBox
            // 
            this.purityPerkCheckBox.AutoSize = true;
            this.purityPerkCheckBox.Location = new System.Drawing.Point(954, 172);
            this.purityPerkCheckBox.Name = "purityPerkCheckBox";
            this.purityPerkCheckBox.Size = new System.Drawing.Size(99, 21);
            this.purityPerkCheckBox.TabIndex = 17;
            this.purityPerkCheckBox.Text = "Purity Perk";
            this.purityPerkCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 540);
            this.Controls.Add(this.purityPerkCheckBox);
            this.Controls.Add(this.poisonerPerkCheckBox);
            this.Controls.Add(this.benefactorPerkCheckBox);
            this.Controls.Add(this.alchemistPerkCheckBox);
            this.Controls.Add(this.physicianPerkCheckBox);
            this.Controls.Add(this.alchemistPerkLevel);
            this.Controls.Add(this.fortifyAlchemyCheckBox);
            this.Controls.Add(this.fortifyAlchemyLevel);
            this.Controls.Add(this.alchemySkillLabel);
            this.Controls.Add(this.alchemySkill);
            this.Controls.Add(this.searchResultBox);
            this.Controls.Add(this.potionDetail);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.effectBox);
            this.Controls.Add(this.ingredientBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ingredientBox;
        private System.Windows.Forms.CheckedListBox effectBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ListView potionDetail;
        private System.Windows.Forms.ColumnHeader ingredient1;
        private System.Windows.Forms.ColumnHeader ingredient2;
        private System.Windows.Forms.ColumnHeader ingredient3;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.ListView searchResultBox;
        private System.Windows.Forms.ColumnHeader effects;
        private System.Windows.Forms.ColumnHeader potionValue;
        private System.Windows.Forms.DomainUpDown alchemySkill;
        private System.Windows.Forms.Label alchemySkillLabel;
        private System.Windows.Forms.DomainUpDown fortifyAlchemyLevel;
        private System.Windows.Forms.CheckBox fortifyAlchemyCheckBox;
        private System.Windows.Forms.DomainUpDown alchemistPerkLevel;
        private System.Windows.Forms.CheckBox physicianPerkCheckBox;
        private System.Windows.Forms.CheckBox alchemistPerkCheckBox;
        private System.Windows.Forms.CheckBox benefactorPerkCheckBox;
        private System.Windows.Forms.CheckBox poisonerPerkCheckBox;
        private System.Windows.Forms.CheckBox purityPerkCheckBox;
    }
}

