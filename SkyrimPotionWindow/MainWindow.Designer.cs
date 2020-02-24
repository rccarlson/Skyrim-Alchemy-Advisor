namespace SkyrimPotionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.skillsColumnLabel = new System.Windows.Forms.Label();
            this.desiredEffectBoxLabel = new System.Windows.Forms.Label();
            this.desiredEffectBox = new System.Windows.Forms.CheckedListBox();
            this.ownedIngredientBox = new System.Windows.Forms.CheckedListBox();
            this.ownedIngredientBoxLabel = new System.Windows.Forms.Label();
            this.skillPanel = new System.Windows.Forms.TableLayoutPanel();
            this.alchemySkillDomain = new System.Windows.Forms.DomainUpDown();
            this.alchemySkillLabel = new System.Windows.Forms.Label();
            this.fortifyAlchemyDomain = new System.Windows.Forms.DomainUpDown();
            this.alchemistPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.fortifyAlchemyLabel = new System.Windows.Forms.Label();
            this.alchemistPerkDomain = new System.Windows.Forms.DomainUpDown();
            this.physicianPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.benefactorPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.poisonerPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.purityPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.ownedIngredientPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ownedIngredientsSelectNoneLabel = new System.Windows.Forms.LinkLabel();
            this.ownedIngredientsSelectAllLabel = new System.Windows.Forms.LinkLabel();
            this.targetEffectPanel = new System.Windows.Forms.TableLayoutPanel();
            this.targetEffectsSelectAllLabel = new System.Windows.Forms.LinkLabel();
            this.targetEffectsSelectNoneLabel = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.resultPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchResultIngredients = new System.Windows.Forms.ListView();
            this.ingredientResultCol1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredientResultCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredientResultCol3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredientResultCol4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultEffectGroups = new System.Windows.Forms.ListView();
            this.searchResultEffects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchResultValues = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainContainer.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.skillPanel.SuspendLayout();
            this.ownedIngredientPanel.SuspendLayout();
            this.targetEffectPanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.ColumnCount = 1;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.Controls.Add(this.searchButton, 0, 1);
            this.mainContainer.Controls.Add(this.inputPanel, 0, 0);
            this.mainContainer.Controls.Add(this.resultPanel, 0, 2);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 3;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer.Size = new System.Drawing.Size(1045, 586);
            this.mainContainer.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(3, 281);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(1039, 24);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // inputPanel
            // 
            this.inputPanel.ColumnCount = 3;
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inputPanel.Controls.Add(this.skillsColumnLabel, 2, 0);
            this.inputPanel.Controls.Add(this.desiredEffectBoxLabel, 1, 0);
            this.inputPanel.Controls.Add(this.desiredEffectBox, 1, 1);
            this.inputPanel.Controls.Add(this.ownedIngredientBox, 0, 1);
            this.inputPanel.Controls.Add(this.ownedIngredientBoxLabel, 0, 0);
            this.inputPanel.Controls.Add(this.skillPanel, 2, 1);
            this.inputPanel.Controls.Add(this.ownedIngredientPanel, 0, 2);
            this.inputPanel.Controls.Add(this.targetEffectPanel, 1, 2);
            this.inputPanel.Controls.Add(this.checkBox1, 2, 2);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(3, 3);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.RowCount = 3;
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.inputPanel.Size = new System.Drawing.Size(1039, 272);
            this.inputPanel.TabIndex = 1;
            // 
            // skillsColumnLabel
            // 
            this.skillsColumnLabel.AutoSize = true;
            this.skillsColumnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillsColumnLabel.Location = new System.Drawing.Point(817, 0);
            this.skillsColumnLabel.Name = "skillsColumnLabel";
            this.skillsColumnLabel.Size = new System.Drawing.Size(219, 20);
            this.skillsColumnLabel.TabIndex = 8;
            this.skillsColumnLabel.Text = "Skills";
            this.skillsColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desiredEffectBoxLabel
            // 
            this.desiredEffectBoxLabel.AutoSize = true;
            this.desiredEffectBoxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desiredEffectBoxLabel.Location = new System.Drawing.Point(410, 0);
            this.desiredEffectBoxLabel.Name = "desiredEffectBoxLabel";
            this.desiredEffectBoxLabel.Size = new System.Drawing.Size(401, 20);
            this.desiredEffectBoxLabel.TabIndex = 7;
            this.desiredEffectBoxLabel.Text = "Target Effects";
            this.desiredEffectBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desiredEffectBox
            // 
            this.desiredEffectBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desiredEffectBox.FormattingEnabled = true;
            this.desiredEffectBox.Location = new System.Drawing.Point(410, 23);
            this.desiredEffectBox.Name = "desiredEffectBox";
            this.desiredEffectBox.Size = new System.Drawing.Size(401, 221);
            this.desiredEffectBox.TabIndex = 6;
            // 
            // ownedIngredientBox
            // 
            this.ownedIngredientBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedIngredientBox.FormattingEnabled = true;
            this.ownedIngredientBox.Location = new System.Drawing.Point(3, 23);
            this.ownedIngredientBox.Name = "ownedIngredientBox";
            this.ownedIngredientBox.Size = new System.Drawing.Size(401, 221);
            this.ownedIngredientBox.TabIndex = 4;
            // 
            // ownedIngredientBoxLabel
            // 
            this.ownedIngredientBoxLabel.AutoSize = true;
            this.ownedIngredientBoxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedIngredientBoxLabel.Location = new System.Drawing.Point(3, 0);
            this.ownedIngredientBoxLabel.Name = "ownedIngredientBoxLabel";
            this.ownedIngredientBoxLabel.Size = new System.Drawing.Size(401, 20);
            this.ownedIngredientBoxLabel.TabIndex = 2;
            this.ownedIngredientBoxLabel.Text = "Owned Ingredients";
            this.ownedIngredientBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skillPanel
            // 
            this.skillPanel.ColumnCount = 2;
            this.skillPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.skillPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.skillPanel.Controls.Add(this.alchemySkillDomain, 1, 0);
            this.skillPanel.Controls.Add(this.alchemySkillLabel, 0, 0);
            this.skillPanel.Controls.Add(this.fortifyAlchemyDomain, 1, 1);
            this.skillPanel.Controls.Add(this.alchemistPerkCheckBox, 0, 2);
            this.skillPanel.Controls.Add(this.fortifyAlchemyLabel, 0, 1);
            this.skillPanel.Controls.Add(this.alchemistPerkDomain, 1, 2);
            this.skillPanel.Controls.Add(this.physicianPerkCheckBox, 0, 3);
            this.skillPanel.Controls.Add(this.benefactorPerkCheckBox, 0, 4);
            this.skillPanel.Controls.Add(this.poisonerPerkCheckBox, 0, 5);
            this.skillPanel.Controls.Add(this.purityPerkCheckBox, 0, 6);
            this.skillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillPanel.Location = new System.Drawing.Point(817, 23);
            this.skillPanel.Name = "skillPanel";
            this.skillPanel.RowCount = 8;
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.Size = new System.Drawing.Size(219, 221);
            this.skillPanel.TabIndex = 9;
            // 
            // alchemySkillDomain
            // 
            this.alchemySkillDomain.Dock = System.Windows.Forms.DockStyle.Left;
            this.alchemySkillDomain.Location = new System.Drawing.Point(111, 2);
            this.alchemySkillDomain.Margin = new System.Windows.Forms.Padding(2);
            this.alchemySkillDomain.Name = "alchemySkillDomain";
            this.alchemySkillDomain.Size = new System.Drawing.Size(103, 20);
            this.alchemySkillDomain.TabIndex = 7;
            this.alchemySkillDomain.Text = "15";
            this.alchemySkillDomain.SelectedItemChanged += new System.EventHandler(this.UpdateDomainItems);
            // 
            // alchemySkillLabel
            // 
            this.alchemySkillLabel.AutoSize = true;
            this.alchemySkillLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alchemySkillLabel.Location = new System.Drawing.Point(3, 0);
            this.alchemySkillLabel.Name = "alchemySkillLabel";
            this.alchemySkillLabel.Size = new System.Drawing.Size(103, 24);
            this.alchemySkillLabel.TabIndex = 0;
            this.alchemySkillLabel.Text = "Alchemy Skill";
            this.alchemySkillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fortifyAlchemyDomain
            // 
            this.fortifyAlchemyDomain.Dock = System.Windows.Forms.DockStyle.Left;
            this.fortifyAlchemyDomain.Location = new System.Drawing.Point(112, 27);
            this.fortifyAlchemyDomain.Name = "fortifyAlchemyDomain";
            this.fortifyAlchemyDomain.Size = new System.Drawing.Size(103, 20);
            this.fortifyAlchemyDomain.TabIndex = 9;
            this.fortifyAlchemyDomain.Text = "0%";
            this.fortifyAlchemyDomain.SelectedItemChanged += new System.EventHandler(this.UpdateDomainItems);
            // 
            // alchemistPerkCheckBox
            // 
            this.alchemistPerkCheckBox.AutoSize = true;
            this.alchemistPerkCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alchemistPerkCheckBox.Location = new System.Drawing.Point(3, 53);
            this.alchemistPerkCheckBox.Name = "alchemistPerkCheckBox";
            this.alchemistPerkCheckBox.Size = new System.Drawing.Size(103, 20);
            this.alchemistPerkCheckBox.TabIndex = 10;
            this.alchemistPerkCheckBox.Text = "Alchemist Perk";
            this.alchemistPerkCheckBox.UseVisualStyleBackColor = true;
            // 
            // fortifyAlchemyLabel
            // 
            this.fortifyAlchemyLabel.AutoSize = true;
            this.fortifyAlchemyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fortifyAlchemyLabel.Location = new System.Drawing.Point(3, 24);
            this.fortifyAlchemyLabel.Name = "fortifyAlchemyLabel";
            this.fortifyAlchemyLabel.Size = new System.Drawing.Size(103, 26);
            this.fortifyAlchemyLabel.TabIndex = 11;
            this.fortifyAlchemyLabel.Text = "Fortify Alchemy";
            this.fortifyAlchemyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alchemistPerkDomain
            // 
            this.alchemistPerkDomain.Dock = System.Windows.Forms.DockStyle.Left;
            this.alchemistPerkDomain.Location = new System.Drawing.Point(112, 53);
            this.alchemistPerkDomain.Name = "alchemistPerkDomain";
            this.alchemistPerkDomain.Size = new System.Drawing.Size(103, 20);
            this.alchemistPerkDomain.TabIndex = 12;
            this.alchemistPerkDomain.Text = "0%";
            this.alchemistPerkDomain.SelectedItemChanged += new System.EventHandler(this.UpdateDomainItems);
            // 
            // physicianPerkCheckBox
            // 
            this.physicianPerkCheckBox.AutoSize = true;
            this.physicianPerkCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.physicianPerkCheckBox.Location = new System.Drawing.Point(3, 79);
            this.physicianPerkCheckBox.Name = "physicianPerkCheckBox";
            this.physicianPerkCheckBox.Size = new System.Drawing.Size(103, 17);
            this.physicianPerkCheckBox.TabIndex = 13;
            this.physicianPerkCheckBox.Text = "Physician Perk";
            this.physicianPerkCheckBox.UseVisualStyleBackColor = true;
            // 
            // benefactorPerkCheckBox
            // 
            this.benefactorPerkCheckBox.AutoSize = true;
            this.benefactorPerkCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.benefactorPerkCheckBox.Location = new System.Drawing.Point(3, 102);
            this.benefactorPerkCheckBox.Name = "benefactorPerkCheckBox";
            this.benefactorPerkCheckBox.Size = new System.Drawing.Size(103, 17);
            this.benefactorPerkCheckBox.TabIndex = 15;
            this.benefactorPerkCheckBox.Text = "Benefactor Perk";
            this.benefactorPerkCheckBox.UseVisualStyleBackColor = true;
            // 
            // poisonerPerkCheckBox
            // 
            this.poisonerPerkCheckBox.AutoSize = true;
            this.poisonerPerkCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonerPerkCheckBox.Location = new System.Drawing.Point(3, 125);
            this.poisonerPerkCheckBox.Name = "poisonerPerkCheckBox";
            this.poisonerPerkCheckBox.Size = new System.Drawing.Size(103, 17);
            this.poisonerPerkCheckBox.TabIndex = 17;
            this.poisonerPerkCheckBox.Text = "Poisoner Perk";
            this.poisonerPerkCheckBox.UseVisualStyleBackColor = true;
            // 
            // purityPerkCheckBox
            // 
            this.purityPerkCheckBox.AutoSize = true;
            this.purityPerkCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purityPerkCheckBox.Location = new System.Drawing.Point(3, 148);
            this.purityPerkCheckBox.Name = "purityPerkCheckBox";
            this.purityPerkCheckBox.Size = new System.Drawing.Size(103, 17);
            this.purityPerkCheckBox.TabIndex = 19;
            this.purityPerkCheckBox.Text = "Purity Perk";
            this.purityPerkCheckBox.UseVisualStyleBackColor = true;
            // 
            // ownedIngredientPanel
            // 
            this.ownedIngredientPanel.ColumnCount = 2;
            this.ownedIngredientPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ownedIngredientPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ownedIngredientPanel.Controls.Add(this.ownedIngredientsSelectNoneLabel, 1, 0);
            this.ownedIngredientPanel.Controls.Add(this.ownedIngredientsSelectAllLabel, 0, 0);
            this.ownedIngredientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedIngredientPanel.Location = new System.Drawing.Point(3, 250);
            this.ownedIngredientPanel.Name = "ownedIngredientPanel";
            this.ownedIngredientPanel.RowCount = 1;
            this.ownedIngredientPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ownedIngredientPanel.Size = new System.Drawing.Size(401, 19);
            this.ownedIngredientPanel.TabIndex = 10;
            // 
            // ownedIngredientsSelectNoneLabel
            // 
            this.ownedIngredientsSelectNoneLabel.AutoSize = true;
            this.ownedIngredientsSelectNoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedIngredientsSelectNoneLabel.Location = new System.Drawing.Point(203, 0);
            this.ownedIngredientsSelectNoneLabel.Name = "ownedIngredientsSelectNoneLabel";
            this.ownedIngredientsSelectNoneLabel.Size = new System.Drawing.Size(195, 19);
            this.ownedIngredientsSelectNoneLabel.TabIndex = 1;
            this.ownedIngredientsSelectNoneLabel.TabStop = true;
            this.ownedIngredientsSelectNoneLabel.Text = "Select None";
            this.ownedIngredientsSelectNoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ownedIngredientsSelectAllLabel
            // 
            this.ownedIngredientsSelectAllLabel.AutoSize = true;
            this.ownedIngredientsSelectAllLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedIngredientsSelectAllLabel.Location = new System.Drawing.Point(3, 0);
            this.ownedIngredientsSelectAllLabel.Name = "ownedIngredientsSelectAllLabel";
            this.ownedIngredientsSelectAllLabel.Size = new System.Drawing.Size(194, 19);
            this.ownedIngredientsSelectAllLabel.TabIndex = 0;
            this.ownedIngredientsSelectAllLabel.TabStop = true;
            this.ownedIngredientsSelectAllLabel.Text = "Select All";
            this.ownedIngredientsSelectAllLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // targetEffectPanel
            // 
            this.targetEffectPanel.ColumnCount = 2;
            this.targetEffectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.targetEffectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.targetEffectPanel.Controls.Add(this.targetEffectsSelectAllLabel, 0, 0);
            this.targetEffectPanel.Controls.Add(this.targetEffectsSelectNoneLabel, 1, 0);
            this.targetEffectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetEffectPanel.Location = new System.Drawing.Point(410, 250);
            this.targetEffectPanel.Name = "targetEffectPanel";
            this.targetEffectPanel.RowCount = 1;
            this.targetEffectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.targetEffectPanel.Size = new System.Drawing.Size(401, 19);
            this.targetEffectPanel.TabIndex = 11;
            // 
            // targetEffectsSelectAllLabel
            // 
            this.targetEffectsSelectAllLabel.AutoSize = true;
            this.targetEffectsSelectAllLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetEffectsSelectAllLabel.Location = new System.Drawing.Point(3, 0);
            this.targetEffectsSelectAllLabel.Name = "targetEffectsSelectAllLabel";
            this.targetEffectsSelectAllLabel.Size = new System.Drawing.Size(194, 19);
            this.targetEffectsSelectAllLabel.TabIndex = 0;
            this.targetEffectsSelectAllLabel.TabStop = true;
            this.targetEffectsSelectAllLabel.Text = "Select All";
            this.targetEffectsSelectAllLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // targetEffectsSelectNoneLabel
            // 
            this.targetEffectsSelectNoneLabel.AutoSize = true;
            this.targetEffectsSelectNoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetEffectsSelectNoneLabel.Location = new System.Drawing.Point(203, 0);
            this.targetEffectsSelectNoneLabel.Name = "targetEffectsSelectNoneLabel";
            this.targetEffectsSelectNoneLabel.Size = new System.Drawing.Size(195, 19);
            this.targetEffectsSelectNoneLabel.TabIndex = 1;
            this.targetEffectsSelectNoneLabel.TabStop = true;
            this.targetEffectsSelectNoneLabel.Text = "Select None";
            this.targetEffectsSelectNoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(817, 250);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(219, 19);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Auto-Search";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // resultPanel
            // 
            this.resultPanel.ColumnCount = 2;
            this.resultPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultPanel.Controls.Add(this.searchResultIngredients, 0, 0);
            this.resultPanel.Controls.Add(this.resultEffectGroups, 0, 0);
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPanel.Location = new System.Drawing.Point(3, 311);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.RowCount = 1;
            this.resultPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultPanel.Size = new System.Drawing.Size(1039, 272);
            this.resultPanel.TabIndex = 12;
            // 
            // searchResultIngredients
            // 
            this.searchResultIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ingredientResultCol1,
            this.ingredientResultCol2,
            this.ingredientResultCol3,
            this.ingredientResultCol4});
            this.searchResultIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultIngredients.HideSelection = false;
            this.searchResultIngredients.Location = new System.Drawing.Point(522, 3);
            this.searchResultIngredients.Name = "searchResultIngredients";
            this.searchResultIngredients.Size = new System.Drawing.Size(514, 266);
            this.searchResultIngredients.TabIndex = 13;
            this.searchResultIngredients.UseCompatibleStateImageBehavior = false;
            this.searchResultIngredients.View = System.Windows.Forms.View.Details;
            // 
            // ingredientResultCol1
            // 
            this.ingredientResultCol1.Text = "Ingredient 1";
            this.ingredientResultCol1.Width = 80;
            // 
            // ingredientResultCol2
            // 
            this.ingredientResultCol2.Text = "Ingredient 2";
            this.ingredientResultCol2.Width = 80;
            // 
            // ingredientResultCol3
            // 
            this.ingredientResultCol3.Text = "Ingredient 3";
            this.ingredientResultCol3.Width = 80;
            // 
            // ingredientResultCol4
            // 
            this.ingredientResultCol4.Text = "Ingredient 4";
            this.ingredientResultCol4.Width = 80;
            // 
            // resultEffectGroups
            // 
            this.resultEffectGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.searchResultEffects,
            this.searchResultValues});
            this.resultEffectGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultEffectGroups.HideSelection = false;
            this.resultEffectGroups.Location = new System.Drawing.Point(3, 3);
            this.resultEffectGroups.Name = "resultEffectGroups";
            this.resultEffectGroups.Size = new System.Drawing.Size(513, 266);
            this.resultEffectGroups.TabIndex = 12;
            this.resultEffectGroups.UseCompatibleStateImageBehavior = false;
            this.resultEffectGroups.View = System.Windows.Forms.View.Details;
            // 
            // searchResultEffects
            // 
            this.searchResultEffects.Text = "Effects";
            // 
            // searchResultValues
            // 
            this.searchResultValues.Text = "Value";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1045, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 586);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Skyrim Alchemy";
            this.mainContainer.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.skillPanel.ResumeLayout(false);
            this.skillPanel.PerformLayout();
            this.ownedIngredientPanel.ResumeLayout(false);
            this.ownedIngredientPanel.PerformLayout();
            this.targetEffectPanel.ResumeLayout(false);
            this.targetEffectPanel.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TableLayoutPanel inputPanel;
        private System.Windows.Forms.Label skillsColumnLabel;
        private System.Windows.Forms.Label desiredEffectBoxLabel;
        private System.Windows.Forms.CheckedListBox desiredEffectBox;
        private System.Windows.Forms.CheckedListBox ownedIngredientBox;
        private System.Windows.Forms.Label ownedIngredientBoxLabel;
        private System.Windows.Forms.TableLayoutPanel skillPanel;
        private System.Windows.Forms.DomainUpDown alchemySkillDomain;
        private System.Windows.Forms.Label alchemySkillLabel;
        private System.Windows.Forms.DomainUpDown fortifyAlchemyDomain;
        private System.Windows.Forms.CheckBox alchemistPerkCheckBox;
        private System.Windows.Forms.Label fortifyAlchemyLabel;
        private System.Windows.Forms.DomainUpDown alchemistPerkDomain;
        private System.Windows.Forms.CheckBox physicianPerkCheckBox;
        private System.Windows.Forms.CheckBox benefactorPerkCheckBox;
        private System.Windows.Forms.CheckBox poisonerPerkCheckBox;
        private System.Windows.Forms.CheckBox purityPerkCheckBox;
        private System.Windows.Forms.TableLayoutPanel resultPanel;
        private System.Windows.Forms.ListView searchResultIngredients;
        private System.Windows.Forms.ColumnHeader ingredientResultCol1;
        private System.Windows.Forms.ColumnHeader ingredientResultCol2;
        private System.Windows.Forms.ColumnHeader ingredientResultCol3;
        private System.Windows.Forms.ColumnHeader ingredientResultCol4;
        private System.Windows.Forms.ListView resultEffectGroups;
        private System.Windows.Forms.ColumnHeader searchResultEffects;
        private System.Windows.Forms.ColumnHeader searchResultValues;
        private System.Windows.Forms.TableLayoutPanel ownedIngredientPanel;
        private System.Windows.Forms.LinkLabel ownedIngredientsSelectNoneLabel;
        private System.Windows.Forms.LinkLabel ownedIngredientsSelectAllLabel;
        private System.Windows.Forms.TableLayoutPanel targetEffectPanel;
        private System.Windows.Forms.LinkLabel targetEffectsSelectAllLabel;
        private System.Windows.Forms.LinkLabel targetEffectsSelectNoneLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

