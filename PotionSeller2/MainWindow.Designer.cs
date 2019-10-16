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
            this.searchResultBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
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
            // searchResultBox
            // 
            this.searchResultBox.FormattingEnabled = true;
            this.searchResultBox.ItemHeight = 16;
            this.searchResultBox.Location = new System.Drawing.Point(581, 12);
            this.searchResultBox.Name = "searchResultBox";
            this.searchResultBox.Size = new System.Drawing.Size(364, 116);
            this.searchResultBox.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(581, 134);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Search";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 540);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.searchResultBox);
            this.Controls.Add(this.effectBox);
            this.Controls.Add(this.ingredientBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ingredientBox;
        private System.Windows.Forms.CheckedListBox effectBox;
        private System.Windows.Forms.ListBox searchResultBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

