namespace PotionSeller3
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ingredientsCheckList = new System.Windows.Forms.CheckedListBox();
            this.desiredEffectCheckList = new System.Windows.Forms.CheckedListBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.desiredEffectsLabel = new System.Windows.Forms.Label();
            this.searchResultBox = new System.Windows.Forms.ListView();
            this.discoveredEffectsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discoveredEffectsValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discoveredEffectsLabel = new System.Windows.Forms.Label();
            this.potionDetail = new System.Windows.Forms.ListView();
            this.ingredient1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredient2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredient3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1042, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.statusText.Size = new System.Drawing.Size(100, 20);
            this.statusText.Text = "Status Text";
            this.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 18);
            // 
            // ingredientsCheckList
            // 
            this.ingredientsCheckList.FormattingEnabled = true;
            this.ingredientsCheckList.Location = new System.Drawing.Point(15, 29);
            this.ingredientsCheckList.Name = "ingredientsCheckList";
            this.ingredientsCheckList.Size = new System.Drawing.Size(300, 497);
            this.ingredientsCheckList.TabIndex = 1;
            // 
            // desiredEffectCheckList
            // 
            this.desiredEffectCheckList.CheckOnClick = true;
            this.desiredEffectCheckList.FormattingEnabled = true;
            this.desiredEffectCheckList.Location = new System.Drawing.Point(321, 29);
            this.desiredEffectCheckList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desiredEffectCheckList.Name = "desiredEffectCheckList";
            this.desiredEffectCheckList.Size = new System.Drawing.Size(300, 497);
            this.desiredEffectCheckList.TabIndex = 2;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Location = new System.Drawing.Point(12, 9);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(78, 17);
            this.ingredientsLabel.TabIndex = 3;
            this.ingredientsLabel.Text = "Ingredients";
            // 
            // desiredEffectsLabel
            // 
            this.desiredEffectsLabel.AutoSize = true;
            this.desiredEffectsLabel.Location = new System.Drawing.Point(318, 9);
            this.desiredEffectsLabel.Name = "desiredEffectsLabel";
            this.desiredEffectsLabel.Size = new System.Drawing.Size(104, 17);
            this.desiredEffectsLabel.TabIndex = 4;
            this.desiredEffectsLabel.Text = "Desired Effects";
            // 
            // searchResultBox
            // 
            this.searchResultBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.discoveredEffectsColumn,
            this.discoveredEffectsValueColumn});
            this.searchResultBox.HideSelection = false;
            this.searchResultBox.Location = new System.Drawing.Point(627, 29);
            this.searchResultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchResultBox.Name = "searchResultBox";
            this.searchResultBox.Size = new System.Drawing.Size(400, 200);
            this.searchResultBox.TabIndex = 6;
            this.searchResultBox.UseCompatibleStateImageBehavior = false;
            this.searchResultBox.View = System.Windows.Forms.View.Details;
            // 
            // discoveredEffectsColumn
            // 
            this.discoveredEffectsColumn.Text = "Effects";
            this.discoveredEffectsColumn.Width = 227;
            // 
            // discoveredEffectsValueColumn
            // 
            this.discoveredEffectsValueColumn.Text = "Value";
            this.discoveredEffectsValueColumn.Width = 83;
            // 
            // discoveredEffectsLabel
            // 
            this.discoveredEffectsLabel.AutoSize = true;
            this.discoveredEffectsLabel.Location = new System.Drawing.Point(624, 9);
            this.discoveredEffectsLabel.Name = "discoveredEffectsLabel";
            this.discoveredEffectsLabel.Size = new System.Drawing.Size(126, 17);
            this.discoveredEffectsLabel.TabIndex = 7;
            this.discoveredEffectsLabel.Text = "Discovered Effects";
            // 
            // potionDetail
            // 
            this.potionDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ingredient1,
            this.ingredient2,
            this.ingredient3,
            this.value});
            this.potionDetail.HideSelection = false;
            this.potionDetail.Location = new System.Drawing.Point(627, 233);
            this.potionDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.potionDetail.Name = "potionDetail";
            this.potionDetail.Size = new System.Drawing.Size(400, 293);
            this.potionDetail.TabIndex = 8;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 562);
            this.Controls.Add(this.potionDetail);
            this.Controls.Add(this.discoveredEffectsLabel);
            this.Controls.Add(this.searchResultBox);
            this.Controls.Add(this.desiredEffectsLabel);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.desiredEffectCheckList);
            this.Controls.Add(this.ingredientsCheckList);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Skyrim Alchemy Advisor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.CheckedListBox ingredientsCheckList;
        private System.Windows.Forms.CheckedListBox desiredEffectCheckList;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label desiredEffectsLabel;
        private System.Windows.Forms.ListView searchResultBox;
        private System.Windows.Forms.ColumnHeader discoveredEffectsColumn;
        private System.Windows.Forms.ColumnHeader discoveredEffectsValueColumn;
        private System.Windows.Forms.Label discoveredEffectsLabel;
        private System.Windows.Forms.ListView potionDetail;
        private System.Windows.Forms.ColumnHeader ingredient1;
        private System.Windows.Forms.ColumnHeader ingredient2;
        private System.Windows.Forms.ColumnHeader ingredient3;
        private System.Windows.Forms.ColumnHeader value;
    }
}

