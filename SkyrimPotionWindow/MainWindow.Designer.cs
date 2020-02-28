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
            this.ownedIngredientBox = new System.Windows.Forms.CheckedListBox();
            this.skillsColumnLabel = new System.Windows.Forms.Label();
            this.desiredEffectBoxLabel = new System.Windows.Forms.Label();
            this.desiredEffectBox = new System.Windows.Forms.CheckedListBox();
            this.ownedIngredientBoxLabel = new System.Windows.Forms.Label();
            this.skillPanel = new System.Windows.Forms.TableLayoutPanel();
            this.seekerOfShadowsCheckBox = new System.Windows.Forms.CheckBox();
            this.alchemySkillLabel = new System.Windows.Forms.Label();
            this.fortifyAlchemyLabel = new System.Windows.Forms.Label();
            this.physicianPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.benefactorPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.poisonerPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.purityPerkCheckBox = new System.Windows.Forms.CheckBox();
            this.alchemySkillUpDown = new System.Windows.Forms.NumericUpDown();
            this.alchemistPerkComboBox = new System.Windows.Forms.ComboBox();
            this.alchemistPerkLabel = new System.Windows.Forms.Label();
            this.ownedIngredientPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ownedIngredientsSelectNoneLabel = new System.Windows.Forms.LinkLabel();
            this.ownedIngredientsSelectAllLabel = new System.Windows.Forms.LinkLabel();
            this.targetEffectPanel = new System.Windows.Forms.TableLayoutPanel();
            this.targetEffectsSelectAllLabel = new System.Windows.Forms.LinkLabel();
            this.targetEffectsSelectNoneLabel = new System.Windows.Forms.LinkLabel();
            this.autoSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.resultPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchResultIngredients = new System.Windows.Forms.ListView();
            this.ingredientResultCol1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredientResultCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredientResultCol3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultEffectGroups = new System.Windows.Forms.ListView();
            this.searchResultEffects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchResultValues = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.potionDetailPanel = new System.Windows.Forms.TableLayoutPanel();
            this.potionDetailName = new System.Windows.Forms.Label();
            this.potionDetailDescription = new System.Windows.Forms.Label();
            this.potionDetailValue = new System.Windows.Forms.Label();
            this.potionDetailIngredients = new System.Windows.Forms.ListView();
            this.potionDetailIngredientNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.potionDetailIngredientValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.potionDetailIngredientWeightColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.potionDetailIngredientObtainedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.searchProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundSettingSaver = new System.ComponentModel.BackgroundWorker();
            this.searchResultUpdater = new System.ComponentModel.BackgroundWorker();
            this.autoSearchWorker = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.fortifyAlchemyDomain = new SkyrimPotionWindow.PercentUpDown();
            this.mainContainer.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.skillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alchemySkillUpDown)).BeginInit();
            this.ownedIngredientPanel.SuspendLayout();
            this.targetEffectPanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.potionDetailPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fortifyAlchemyDomain)).BeginInit();
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
            this.mainContainer.RowCount = 4;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainContainer.Size = new System.Drawing.Size(1010, 586);
            this.mainContainer.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(3, 271);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(1004, 24);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.ColumnCount = 3;
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.inputPanel.Controls.Add(this.ownedIngredientBox, 0, 1);
            this.inputPanel.Controls.Add(this.skillsColumnLabel, 2, 0);
            this.inputPanel.Controls.Add(this.desiredEffectBoxLabel, 1, 0);
            this.inputPanel.Controls.Add(this.desiredEffectBox, 1, 1);
            this.inputPanel.Controls.Add(this.ownedIngredientBoxLabel, 0, 0);
            this.inputPanel.Controls.Add(this.skillPanel, 2, 1);
            this.inputPanel.Controls.Add(this.ownedIngredientPanel, 0, 2);
            this.inputPanel.Controls.Add(this.targetEffectPanel, 1, 2);
            this.inputPanel.Controls.Add(this.autoSearchCheckBox, 2, 2);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(3, 3);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.RowCount = 3;
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.inputPanel.Size = new System.Drawing.Size(1004, 262);
            this.inputPanel.TabIndex = 3;
            // 
            // ownedIngredientBox
            // 
            this.ownedIngredientBox.CheckOnClick = true;
            this.ownedIngredientBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedIngredientBox.FormattingEnabled = true;
            this.ownedIngredientBox.Location = new System.Drawing.Point(3, 23);
            this.ownedIngredientBox.Name = "ownedIngredientBox";
            this.ownedIngredientBox.Size = new System.Drawing.Size(381, 211);
            this.ownedIngredientBox.TabIndex = 1;
            this.ownedIngredientBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OwnedIngredientBox_ItemCheck);
            // 
            // skillsColumnLabel
            // 
            this.skillsColumnLabel.AutoSize = true;
            this.skillsColumnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillsColumnLabel.Location = new System.Drawing.Point(777, 0);
            this.skillsColumnLabel.Name = "skillsColumnLabel";
            this.skillsColumnLabel.Size = new System.Drawing.Size(224, 20);
            this.skillsColumnLabel.TabIndex = 0;
            this.skillsColumnLabel.Text = "Skills";
            this.skillsColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desiredEffectBoxLabel
            // 
            this.desiredEffectBoxLabel.AutoSize = true;
            this.desiredEffectBoxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desiredEffectBoxLabel.Location = new System.Drawing.Point(390, 0);
            this.desiredEffectBoxLabel.Name = "desiredEffectBoxLabel";
            this.desiredEffectBoxLabel.Size = new System.Drawing.Size(381, 20);
            this.desiredEffectBoxLabel.TabIndex = 0;
            this.desiredEffectBoxLabel.Text = "Target Effects";
            this.desiredEffectBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desiredEffectBox
            // 
            this.desiredEffectBox.CheckOnClick = true;
            this.desiredEffectBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desiredEffectBox.FormattingEnabled = true;
            this.desiredEffectBox.Location = new System.Drawing.Point(390, 23);
            this.desiredEffectBox.Name = "desiredEffectBox";
            this.desiredEffectBox.Size = new System.Drawing.Size(381, 211);
            this.desiredEffectBox.TabIndex = 2;
            this.desiredEffectBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DesiredEffectBox_ItemCheck);
            // 
            // ownedIngredientBoxLabel
            // 
            this.ownedIngredientBoxLabel.AutoSize = true;
            this.ownedIngredientBoxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedIngredientBoxLabel.Location = new System.Drawing.Point(3, 0);
            this.ownedIngredientBoxLabel.Name = "ownedIngredientBoxLabel";
            this.ownedIngredientBoxLabel.Size = new System.Drawing.Size(381, 20);
            this.ownedIngredientBoxLabel.TabIndex = 0;
            this.ownedIngredientBoxLabel.Text = "Owned Ingredients";
            this.ownedIngredientBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skillPanel
            // 
            this.skillPanel.ColumnCount = 2;
            this.skillPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.skillPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.skillPanel.Controls.Add(this.seekerOfShadowsCheckBox, 0, 7);
            this.skillPanel.Controls.Add(this.alchemySkillLabel, 0, 0);
            this.skillPanel.Controls.Add(this.fortifyAlchemyLabel, 0, 1);
            this.skillPanel.Controls.Add(this.physicianPerkCheckBox, 0, 3);
            this.skillPanel.Controls.Add(this.benefactorPerkCheckBox, 0, 4);
            this.skillPanel.Controls.Add(this.poisonerPerkCheckBox, 0, 5);
            this.skillPanel.Controls.Add(this.purityPerkCheckBox, 0, 6);
            this.skillPanel.Controls.Add(this.alchemySkillUpDown, 1, 0);
            this.skillPanel.Controls.Add(this.fortifyAlchemyDomain, 1, 1);
            this.skillPanel.Controls.Add(this.alchemistPerkComboBox, 1, 2);
            this.skillPanel.Controls.Add(this.alchemistPerkLabel, 0, 2);
            this.skillPanel.Controls.Add(this.button1, 1, 4);
            this.skillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillPanel.Location = new System.Drawing.Point(777, 23);
            this.skillPanel.Name = "skillPanel";
            this.skillPanel.RowCount = 9;
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.skillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.skillPanel.Size = new System.Drawing.Size(224, 211);
            this.skillPanel.TabIndex = 0;
            // 
            // seekerOfShadowsCheckBox
            // 
            this.seekerOfShadowsCheckBox.AutoSize = true;
            this.seekerOfShadowsCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seekerOfShadowsCheckBox.Location = new System.Drawing.Point(3, 180);
            this.seekerOfShadowsCheckBox.Name = "seekerOfShadowsCheckBox";
            this.seekerOfShadowsCheckBox.Size = new System.Drawing.Size(119, 17);
            this.seekerOfShadowsCheckBox.TabIndex = 13;
            this.seekerOfShadowsCheckBox.Text = "Seeker of Shadows";
            this.seekerOfShadowsCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.seekerOfShadowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // alchemySkillLabel
            // 
            this.alchemySkillLabel.AutoSize = true;
            this.alchemySkillLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alchemySkillLabel.Location = new System.Drawing.Point(3, 0);
            this.alchemySkillLabel.Name = "alchemySkillLabel";
            this.alchemySkillLabel.Size = new System.Drawing.Size(119, 26);
            this.alchemySkillLabel.TabIndex = 0;
            this.alchemySkillLabel.Text = "Alchemy Skill";
            this.alchemySkillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fortifyAlchemyLabel
            // 
            this.fortifyAlchemyLabel.AutoSize = true;
            this.fortifyAlchemyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fortifyAlchemyLabel.Location = new System.Drawing.Point(3, 26);
            this.fortifyAlchemyLabel.Name = "fortifyAlchemyLabel";
            this.fortifyAlchemyLabel.Size = new System.Drawing.Size(119, 26);
            this.fortifyAlchemyLabel.TabIndex = 0;
            this.fortifyAlchemyLabel.Text = "Fortify Alchemy";
            this.fortifyAlchemyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // physicianPerkCheckBox
            // 
            this.physicianPerkCheckBox.AutoSize = true;
            this.physicianPerkCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.physicianPerkCheckBox.Location = new System.Drawing.Point(3, 82);
            this.physicianPerkCheckBox.Name = "physicianPerkCheckBox";
            this.physicianPerkCheckBox.Size = new System.Drawing.Size(119, 17);
            this.physicianPerkCheckBox.TabIndex = 7;
            this.physicianPerkCheckBox.Text = "Physician Perk";
            this.physicianPerkCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.physicianPerkCheckBox.UseVisualStyleBackColor = true;
            this.physicianPerkCheckBox.CheckedChanged += new System.EventHandler(this.ParameterValueChanged);
            // 
            // benefactorPerkCheckBox
            // 
            this.benefactorPerkCheckBox.AutoSize = true;
            this.benefactorPerkCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.benefactorPerkCheckBox.Location = new System.Drawing.Point(3, 105);
            this.benefactorPerkCheckBox.Name = "benefactorPerkCheckBox";
            this.benefactorPerkCheckBox.Size = new System.Drawing.Size(119, 23);
            this.benefactorPerkCheckBox.TabIndex = 8;
            this.benefactorPerkCheckBox.Text = "Benefactor Perk";
            this.benefactorPerkCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.benefactorPerkCheckBox.UseVisualStyleBackColor = true;
            this.benefactorPerkCheckBox.CheckedChanged += new System.EventHandler(this.ParameterValueChanged);
            // 
            // poisonerPerkCheckBox
            // 
            this.poisonerPerkCheckBox.AutoSize = true;
            this.poisonerPerkCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonerPerkCheckBox.Location = new System.Drawing.Point(3, 134);
            this.poisonerPerkCheckBox.Name = "poisonerPerkCheckBox";
            this.poisonerPerkCheckBox.Size = new System.Drawing.Size(119, 17);
            this.poisonerPerkCheckBox.TabIndex = 9;
            this.poisonerPerkCheckBox.Text = "Poisoner Perk";
            this.poisonerPerkCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.poisonerPerkCheckBox.UseVisualStyleBackColor = true;
            this.poisonerPerkCheckBox.CheckedChanged += new System.EventHandler(this.ParameterValueChanged);
            // 
            // purityPerkCheckBox
            // 
            this.purityPerkCheckBox.AutoSize = true;
            this.purityPerkCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purityPerkCheckBox.Location = new System.Drawing.Point(3, 157);
            this.purityPerkCheckBox.Name = "purityPerkCheckBox";
            this.purityPerkCheckBox.Size = new System.Drawing.Size(119, 17);
            this.purityPerkCheckBox.TabIndex = 10;
            this.purityPerkCheckBox.Text = "Purity Perk";
            this.purityPerkCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.purityPerkCheckBox.UseVisualStyleBackColor = true;
            this.purityPerkCheckBox.CheckedChanged += new System.EventHandler(this.ParameterValueChanged);
            // 
            // alchemySkillUpDown
            // 
            this.alchemySkillUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alchemySkillUpDown.Location = new System.Drawing.Point(128, 3);
            this.alchemySkillUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.alchemySkillUpDown.Name = "alchemySkillUpDown";
            this.alchemySkillUpDown.Size = new System.Drawing.Size(93, 20);
            this.alchemySkillUpDown.TabIndex = 3;
            this.alchemySkillUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.alchemySkillUpDown.ValueChanged += new System.EventHandler(this.ParameterValueChanged);
            // 
            // alchemistPerkComboBox
            // 
            this.alchemistPerkComboBox.Items.AddRange(new object[] {
            "0%",
            "20%",
            "40%",
            "60%",
            "80%",
            "100%"});
            this.alchemistPerkComboBox.Location = new System.Drawing.Point(128, 55);
            this.alchemistPerkComboBox.MaxDropDownItems = 5;
            this.alchemistPerkComboBox.Name = "alchemistPerkComboBox";
            this.alchemistPerkComboBox.Size = new System.Drawing.Size(52, 21);
            this.alchemistPerkComboBox.TabIndex = 12;
            this.alchemistPerkComboBox.Text = "0%";
            this.alchemistPerkComboBox.SelectedIndexChanged += new System.EventHandler(this.ParameterValueChanged);
            // 
            // alchemistPerkLabel
            // 
            this.alchemistPerkLabel.AutoSize = true;
            this.alchemistPerkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alchemistPerkLabel.Location = new System.Drawing.Point(3, 52);
            this.alchemistPerkLabel.Name = "alchemistPerkLabel";
            this.alchemistPerkLabel.Size = new System.Drawing.Size(119, 27);
            this.alchemistPerkLabel.TabIndex = 0;
            this.alchemistPerkLabel.Text = "Alchemist Perk";
            this.alchemistPerkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ownedIngredientPanel
            // 
            this.ownedIngredientPanel.ColumnCount = 2;
            this.ownedIngredientPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ownedIngredientPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ownedIngredientPanel.Controls.Add(this.ownedIngredientsSelectNoneLabel, 1, 0);
            this.ownedIngredientPanel.Controls.Add(this.ownedIngredientsSelectAllLabel, 0, 0);
            this.ownedIngredientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedIngredientPanel.Location = new System.Drawing.Point(3, 240);
            this.ownedIngredientPanel.Name = "ownedIngredientPanel";
            this.ownedIngredientPanel.RowCount = 1;
            this.ownedIngredientPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ownedIngredientPanel.Size = new System.Drawing.Size(381, 19);
            this.ownedIngredientPanel.TabIndex = 0;
            // 
            // ownedIngredientsSelectNoneLabel
            // 
            this.ownedIngredientsSelectNoneLabel.AutoSize = true;
            this.ownedIngredientsSelectNoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedIngredientsSelectNoneLabel.Location = new System.Drawing.Point(193, 0);
            this.ownedIngredientsSelectNoneLabel.Name = "ownedIngredientsSelectNoneLabel";
            this.ownedIngredientsSelectNoneLabel.Size = new System.Drawing.Size(185, 19);
            this.ownedIngredientsSelectNoneLabel.TabIndex = 12;
            this.ownedIngredientsSelectNoneLabel.TabStop = true;
            this.ownedIngredientsSelectNoneLabel.Text = "Select None";
            this.ownedIngredientsSelectNoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ownedIngredientsSelectNoneLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectNoneIngredients);
            // 
            // ownedIngredientsSelectAllLabel
            // 
            this.ownedIngredientsSelectAllLabel.AutoSize = true;
            this.ownedIngredientsSelectAllLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedIngredientsSelectAllLabel.Location = new System.Drawing.Point(3, 0);
            this.ownedIngredientsSelectAllLabel.Name = "ownedIngredientsSelectAllLabel";
            this.ownedIngredientsSelectAllLabel.Size = new System.Drawing.Size(184, 19);
            this.ownedIngredientsSelectAllLabel.TabIndex = 11;
            this.ownedIngredientsSelectAllLabel.TabStop = true;
            this.ownedIngredientsSelectAllLabel.Text = "Select All";
            this.ownedIngredientsSelectAllLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ownedIngredientsSelectAllLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectAllIngredients);
            // 
            // targetEffectPanel
            // 
            this.targetEffectPanel.ColumnCount = 2;
            this.targetEffectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.targetEffectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.targetEffectPanel.Controls.Add(this.targetEffectsSelectAllLabel, 0, 0);
            this.targetEffectPanel.Controls.Add(this.targetEffectsSelectNoneLabel, 1, 0);
            this.targetEffectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetEffectPanel.Location = new System.Drawing.Point(390, 240);
            this.targetEffectPanel.Name = "targetEffectPanel";
            this.targetEffectPanel.RowCount = 1;
            this.targetEffectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.targetEffectPanel.Size = new System.Drawing.Size(381, 19);
            this.targetEffectPanel.TabIndex = 0;
            // 
            // targetEffectsSelectAllLabel
            // 
            this.targetEffectsSelectAllLabel.AutoSize = true;
            this.targetEffectsSelectAllLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetEffectsSelectAllLabel.Location = new System.Drawing.Point(3, 0);
            this.targetEffectsSelectAllLabel.Name = "targetEffectsSelectAllLabel";
            this.targetEffectsSelectAllLabel.Size = new System.Drawing.Size(184, 19);
            this.targetEffectsSelectAllLabel.TabIndex = 13;
            this.targetEffectsSelectAllLabel.TabStop = true;
            this.targetEffectsSelectAllLabel.Text = "Select All";
            this.targetEffectsSelectAllLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.targetEffectsSelectAllLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectAllEffects);
            // 
            // targetEffectsSelectNoneLabel
            // 
            this.targetEffectsSelectNoneLabel.AutoSize = true;
            this.targetEffectsSelectNoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetEffectsSelectNoneLabel.Location = new System.Drawing.Point(193, 0);
            this.targetEffectsSelectNoneLabel.Name = "targetEffectsSelectNoneLabel";
            this.targetEffectsSelectNoneLabel.Size = new System.Drawing.Size(185, 19);
            this.targetEffectsSelectNoneLabel.TabIndex = 14;
            this.targetEffectsSelectNoneLabel.TabStop = true;
            this.targetEffectsSelectNoneLabel.Text = "Select None";
            this.targetEffectsSelectNoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.targetEffectsSelectNoneLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectNoneEffects);
            // 
            // autoSearchCheckBox
            // 
            this.autoSearchCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.autoSearchCheckBox.AutoSize = true;
            this.autoSearchCheckBox.Location = new System.Drawing.Point(846, 240);
            this.autoSearchCheckBox.Name = "autoSearchCheckBox";
            this.autoSearchCheckBox.Size = new System.Drawing.Size(85, 17);
            this.autoSearchCheckBox.TabIndex = 15;
            this.autoSearchCheckBox.Text = "Auto-Search";
            this.autoSearchCheckBox.UseVisualStyleBackColor = true;
            this.autoSearchCheckBox.CheckedChanged += new System.EventHandler(this.ParameterValueChanged);
            // 
            // resultPanel
            // 
            this.resultPanel.ColumnCount = 3;
            this.resultPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.resultPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.resultPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.resultPanel.Controls.Add(this.searchResultIngredients, 0, 0);
            this.resultPanel.Controls.Add(this.resultEffectGroups, 0, 0);
            this.resultPanel.Controls.Add(this.potionDetailPanel, 2, 0);
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPanel.Location = new System.Drawing.Point(3, 301);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.RowCount = 1;
            this.resultPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resultPanel.Size = new System.Drawing.Size(1004, 262);
            this.resultPanel.TabIndex = 0;
            // 
            // searchResultIngredients
            // 
            this.searchResultIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ingredientResultCol1,
            this.ingredientResultCol2,
            this.ingredientResultCol3});
            this.searchResultIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultIngredients.FullRowSelect = true;
            this.searchResultIngredients.HideSelection = false;
            this.searchResultIngredients.Location = new System.Drawing.Point(337, 3);
            this.searchResultIngredients.Name = "searchResultIngredients";
            this.searchResultIngredients.Size = new System.Drawing.Size(328, 256);
            this.searchResultIngredients.TabIndex = 18;
            this.searchResultIngredients.UseCompatibleStateImageBehavior = false;
            this.searchResultIngredients.View = System.Windows.Forms.View.Details;
            this.searchResultIngredients.SelectedIndexChanged += new System.EventHandler(this.SearchResultIngredients_SelectedIndexChanged);
            // 
            // ingredientResultCol1
            // 
            this.ingredientResultCol1.Text = "Ingredient 1";
            this.ingredientResultCol1.Width = 120;
            // 
            // ingredientResultCol2
            // 
            this.ingredientResultCol2.Text = "Ingredient 2";
            this.ingredientResultCol2.Width = 120;
            // 
            // ingredientResultCol3
            // 
            this.ingredientResultCol3.Text = "Ingredient 3";
            this.ingredientResultCol3.Width = 120;
            // 
            // resultEffectGroups
            // 
            this.resultEffectGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.searchResultEffects,
            this.searchResultValues});
            this.resultEffectGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultEffectGroups.FullRowSelect = true;
            this.resultEffectGroups.HideSelection = false;
            this.resultEffectGroups.Location = new System.Drawing.Point(3, 3);
            this.resultEffectGroups.Name = "resultEffectGroups";
            this.resultEffectGroups.Size = new System.Drawing.Size(328, 256);
            this.resultEffectGroups.TabIndex = 17;
            this.resultEffectGroups.UseCompatibleStateImageBehavior = false;
            this.resultEffectGroups.View = System.Windows.Forms.View.Details;
            this.resultEffectGroups.SelectedIndexChanged += new System.EventHandler(this.ResultEffectGroups_SelectedIndexChanged);
            // 
            // searchResultEffects
            // 
            this.searchResultEffects.Text = "Effects";
            this.searchResultEffects.Width = 199;
            // 
            // searchResultValues
            // 
            this.searchResultValues.Text = "Value";
            // 
            // potionDetailPanel
            // 
            this.potionDetailPanel.ColumnCount = 1;
            this.potionDetailPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.potionDetailPanel.Controls.Add(this.potionDetailName, 0, 0);
            this.potionDetailPanel.Controls.Add(this.potionDetailDescription, 0, 1);
            this.potionDetailPanel.Controls.Add(this.potionDetailValue, 0, 2);
            this.potionDetailPanel.Controls.Add(this.potionDetailIngredients, 0, 3);
            this.potionDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.potionDetailPanel.Location = new System.Drawing.Point(671, 3);
            this.potionDetailPanel.Name = "potionDetailPanel";
            this.potionDetailPanel.RowCount = 4;
            this.potionDetailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.potionDetailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.potionDetailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.potionDetailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.potionDetailPanel.Size = new System.Drawing.Size(330, 256);
            this.potionDetailPanel.TabIndex = 14;
            // 
            // potionDetailName
            // 
            this.potionDetailName.AutoSize = true;
            this.potionDetailName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.potionDetailName.Location = new System.Drawing.Point(3, 0);
            this.potionDetailName.Name = "potionDetailName";
            this.potionDetailName.Size = new System.Drawing.Size(324, 13);
            this.potionDetailName.TabIndex = 0;
            this.potionDetailName.Text = "potionDetailName";
            this.potionDetailName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // potionDetailDescription
            // 
            this.potionDetailDescription.AutoSize = true;
            this.potionDetailDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.potionDetailDescription.Location = new System.Drawing.Point(3, 13);
            this.potionDetailDescription.Name = "potionDetailDescription";
            this.potionDetailDescription.Size = new System.Drawing.Size(324, 13);
            this.potionDetailDescription.TabIndex = 1;
            this.potionDetailDescription.Text = "potionDetailDescription";
            this.potionDetailDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // potionDetailValue
            // 
            this.potionDetailValue.AutoSize = true;
            this.potionDetailValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.potionDetailValue.Location = new System.Drawing.Point(3, 26);
            this.potionDetailValue.Name = "potionDetailValue";
            this.potionDetailValue.Size = new System.Drawing.Size(324, 13);
            this.potionDetailValue.TabIndex = 2;
            this.potionDetailValue.Text = "potionDetailValue";
            this.potionDetailValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // potionDetailIngredients
            // 
            this.potionDetailIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.potionDetailIngredientNameColumn,
            this.potionDetailIngredientValueColumn,
            this.potionDetailIngredientWeightColumn,
            this.potionDetailIngredientObtainedColumn});
            this.potionDetailIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.potionDetailIngredients.FullRowSelect = true;
            this.potionDetailIngredients.HideSelection = false;
            this.potionDetailIngredients.Location = new System.Drawing.Point(3, 42);
            this.potionDetailIngredients.Name = "potionDetailIngredients";
            this.potionDetailIngredients.Size = new System.Drawing.Size(324, 211);
            this.potionDetailIngredients.TabIndex = 19;
            this.potionDetailIngredients.UseCompatibleStateImageBehavior = false;
            this.potionDetailIngredients.View = System.Windows.Forms.View.Details;
            // 
            // potionDetailIngredientNameColumn
            // 
            this.potionDetailIngredientNameColumn.Text = "Ingredient";
            this.potionDetailIngredientNameColumn.Width = 100;
            // 
            // potionDetailIngredientValueColumn
            // 
            this.potionDetailIngredientValueColumn.Text = "Value";
            // 
            // potionDetailIngredientWeightColumn
            // 
            this.potionDetailIngredientWeightColumn.Text = "Weight";
            // 
            // potionDetailIngredientObtainedColumn
            // 
            this.potionDetailIngredientObtainedColumn.Text = "Obtained By";
            this.potionDetailIngredientObtainedColumn.Width = 120;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1010, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // searchProgressBar
            // 
            this.searchProgressBar.Name = "searchProgressBar";
            this.searchProgressBar.Size = new System.Drawing.Size(150, 16);
            // 
            // backgroundSettingSaver
            // 
            this.backgroundSettingSaver.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundSettingSaver_DoWork);
            // 
            // searchResultUpdater
            // 
            this.searchResultUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchResultUpdater_DoWork);
            // 
            // autoSearchWorker
            // 
            this.autoSearchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AutoSearchWorker_DoWork);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fortifyAlchemyDomain
            // 
            this.fortifyAlchemyDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fortifyAlchemyDomain.Location = new System.Drawing.Point(128, 29);
            this.fortifyAlchemyDomain.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.fortifyAlchemyDomain.Name = "fortifyAlchemyDomain";
            this.fortifyAlchemyDomain.Size = new System.Drawing.Size(93, 20);
            this.fortifyAlchemyDomain.TabIndex = 4;
            this.fortifyAlchemyDomain.ValueChanged += new System.EventHandler(this.ParameterValueChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 586);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Skyrim Potion Calculator";
            this.mainContainer.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.skillPanel.ResumeLayout(false);
            this.skillPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alchemySkillUpDown)).EndInit();
            this.ownedIngredientPanel.ResumeLayout(false);
            this.ownedIngredientPanel.PerformLayout();
            this.targetEffectPanel.ResumeLayout(false);
            this.targetEffectPanel.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            this.potionDetailPanel.ResumeLayout(false);
            this.potionDetailPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fortifyAlchemyDomain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TableLayoutPanel inputPanel;
        private System.Windows.Forms.CheckedListBox ownedIngredientBox;
        private System.Windows.Forms.TableLayoutPanel resultPanel;
        private System.Windows.Forms.ListView searchResultIngredients;
        private System.Windows.Forms.ColumnHeader ingredientResultCol1;
        private System.Windows.Forms.ColumnHeader ingredientResultCol2;
        private System.Windows.Forms.ColumnHeader ingredientResultCol3;
        private System.Windows.Forms.ListView resultEffectGroups;
        private System.Windows.Forms.ColumnHeader searchResultEffects;
        private System.Windows.Forms.ColumnHeader searchResultValues;
        private System.Windows.Forms.TableLayoutPanel ownedIngredientPanel;
        private System.Windows.Forms.LinkLabel ownedIngredientsSelectNoneLabel;
        private System.Windows.Forms.LinkLabel ownedIngredientsSelectAllLabel;
        private System.Windows.Forms.TableLayoutPanel targetEffectPanel;
        private System.Windows.Forms.LinkLabel targetEffectsSelectAllLabel;
        private System.Windows.Forms.LinkLabel targetEffectsSelectNoneLabel;
        private System.Windows.Forms.CheckBox autoSearchCheckBox;
        private System.Windows.Forms.TableLayoutPanel potionDetailPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label skillsColumnLabel;
        private System.Windows.Forms.Label desiredEffectBoxLabel;
        private System.Windows.Forms.Label ownedIngredientBoxLabel;
        private System.Windows.Forms.TableLayoutPanel skillPanel;
        private System.Windows.Forms.Label alchemySkillLabel;
        private System.Windows.Forms.Label fortifyAlchemyLabel;
        private System.Windows.Forms.CheckBox physicianPerkCheckBox;
        private System.Windows.Forms.CheckBox benefactorPerkCheckBox;
        private System.Windows.Forms.CheckBox poisonerPerkCheckBox;
        private System.Windows.Forms.CheckBox purityPerkCheckBox;
        private System.Windows.Forms.NumericUpDown alchemySkillUpDown;
        private PercentUpDown fortifyAlchemyDomain;
        private System.Windows.Forms.CheckedListBox desiredEffectBox;
        private System.ComponentModel.BackgroundWorker backgroundSettingSaver;
        private System.Windows.Forms.ComboBox alchemistPerkComboBox;
        private System.Windows.Forms.CheckBox seekerOfShadowsCheckBox;
        private System.ComponentModel.BackgroundWorker searchResultUpdater;
        private System.Windows.Forms.Label alchemistPerkLabel;
        private System.Windows.Forms.Label potionDetailName;
        private System.Windows.Forms.Label potionDetailDescription;
        private System.Windows.Forms.Label potionDetailValue;
        private System.Windows.Forms.ListView potionDetailIngredients;
        private System.Windows.Forms.ColumnHeader potionDetailIngredientNameColumn;
        private System.Windows.Forms.ColumnHeader potionDetailIngredientValueColumn;
        private System.Windows.Forms.ColumnHeader potionDetailIngredientWeightColumn;
        private System.Windows.Forms.ColumnHeader potionDetailIngredientObtainedColumn;
        private System.Windows.Forms.ToolStripProgressBar searchProgressBar;
        private System.ComponentModel.BackgroundWorker autoSearchWorker;
        private System.Windows.Forms.Button button1;
    }
}

