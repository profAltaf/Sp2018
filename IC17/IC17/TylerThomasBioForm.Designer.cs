namespace IC17
{
    partial class TylerThomasBioForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.dreamJobLabel = new System.Windows.Forms.Label();
            this.dreamJobTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(63, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // dreamJobLabel
            // 
            this.dreamJobLabel.AutoSize = true;
            this.dreamJobLabel.Location = new System.Drawing.Point(63, 132);
            this.dreamJobLabel.Name = "dreamJobLabel";
            this.dreamJobLabel.Size = new System.Drawing.Size(58, 13);
            this.dreamJobLabel.TabIndex = 1;
            this.dreamJobLabel.Text = "Dream Job";
            // 
            // dreamJobTextBox
            // 
            this.dreamJobTextBox.Location = new System.Drawing.Point(140, 125);
            this.dreamJobTextBox.Name = "dreamJobTextBox";
            this.dreamJobTextBox.ReadOnly = true;
            this.dreamJobTextBox.Size = new System.Drawing.Size(156, 20);
            this.dreamJobTextBox.TabIndex = 2;
            this.dreamJobTextBox.Text = "Sys Admin";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(140, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(156, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "Tyler Thomas";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(175, 202);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // TylerThomasBioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 292);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dreamJobTextBox);
            this.Controls.Add(this.dreamJobLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "TylerThomasBioForm";
            this.Text = "TylerThomasBioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dreamJobLabel;
        private System.Windows.Forms.TextBox dreamJobTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}