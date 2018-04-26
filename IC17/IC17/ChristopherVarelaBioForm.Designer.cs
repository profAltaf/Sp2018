namespace IC17
{
    partial class ChristopherVarelaBioForm
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
            this.chrisNameLabel = new System.Windows.Forms.Label();
            this.chrisDreamJobLabel = new System.Windows.Forms.Label();
            this.chrisNameTextBox = new System.Windows.Forms.TextBox();
            this.chrisDreamJobTextBox = new System.Windows.Forms.TextBox();
            this.chrisCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chrisNameLabel
            // 
            this.chrisNameLabel.AutoSize = true;
            this.chrisNameLabel.Location = new System.Drawing.Point(40, 65);
            this.chrisNameLabel.Name = "chrisNameLabel";
            this.chrisNameLabel.Size = new System.Drawing.Size(35, 13);
            this.chrisNameLabel.TabIndex = 0;
            this.chrisNameLabel.Text = "Name";
            // 
            // chrisDreamJobLabel
            // 
            this.chrisDreamJobLabel.AutoSize = true;
            this.chrisDreamJobLabel.Location = new System.Drawing.Point(40, 121);
            this.chrisDreamJobLabel.Name = "chrisDreamJobLabel";
            this.chrisDreamJobLabel.Size = new System.Drawing.Size(58, 13);
            this.chrisDreamJobLabel.TabIndex = 1;
            this.chrisDreamJobLabel.Text = "Dream Job";
            // 
            // chrisNameTextBox
            // 
            this.chrisNameTextBox.Location = new System.Drawing.Point(205, 65);
            this.chrisNameTextBox.Name = "chrisNameTextBox";
            this.chrisNameTextBox.ReadOnly = true;
            this.chrisNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.chrisNameTextBox.TabIndex = 2;
            this.chrisNameTextBox.Text = "Christopher Varela";
            // 
            // chrisDreamJobTextBox
            // 
            this.chrisDreamJobTextBox.Location = new System.Drawing.Point(205, 114);
            this.chrisDreamJobTextBox.Name = "chrisDreamJobTextBox";
            this.chrisDreamJobTextBox.ReadOnly = true;
            this.chrisDreamJobTextBox.Size = new System.Drawing.Size(189, 20);
            this.chrisDreamJobTextBox.TabIndex = 3;
            this.chrisDreamJobTextBox.Text = "Senior Account Executive in IT Sales";
            // 
            // chrisCloseButton
            // 
            this.chrisCloseButton.Location = new System.Drawing.Point(205, 193);
            this.chrisCloseButton.Name = "chrisCloseButton";
            this.chrisCloseButton.Size = new System.Drawing.Size(75, 23);
            this.chrisCloseButton.TabIndex = 4;
            this.chrisCloseButton.Text = "Close";
            this.chrisCloseButton.UseVisualStyleBackColor = true;
            this.chrisCloseButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ChristopherVarelaBioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chrisCloseButton);
            this.Controls.Add(this.chrisDreamJobTextBox);
            this.Controls.Add(this.chrisNameTextBox);
            this.Controls.Add(this.chrisDreamJobLabel);
            this.Controls.Add(this.chrisNameLabel);
            this.Name = "ChristopherVarelaBioForm";
            this.Text = "ChristopherVarelaBioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chrisNameLabel;
        private System.Windows.Forms.Label chrisDreamJobLabel;
        private System.Windows.Forms.TextBox chrisNameTextBox;
        private System.Windows.Forms.TextBox chrisDreamJobTextBox;
        private System.Windows.Forms.Button chrisCloseButton;
    }
}