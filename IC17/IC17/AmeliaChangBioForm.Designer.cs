namespace IC17
{
    partial class AmeliaChangBioForm
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
            this.dreamJobLabel = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dreamJobTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dreamJobLabel
            // 
            this.dreamJobLabel.AutoSize = true;
            this.dreamJobLabel.Location = new System.Drawing.Point(91, 47);
            this.dreamJobLabel.Name = "dreamJobLabel";
            this.dreamJobLabel.Size = new System.Drawing.Size(58, 13);
            this.dreamJobLabel.TabIndex = 0;
            this.dreamJobLabel.Text = "Dream Job";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(94, 121);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(59, 13);
            this.Name.TabIndex = 1;
            this.Name.Text = "nameLabel";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(173, 47);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(323, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // dreamJobTextBox
            // 
            this.dreamJobTextBox.Location = new System.Drawing.Point(173, 113);
            this.dreamJobTextBox.Multiline = true;
            this.dreamJobTextBox.Name = "dreamJobTextBox";
            this.dreamJobTextBox.Size = new System.Drawing.Size(323, 20);
            this.dreamJobTextBox.TabIndex = 3;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(237, 179);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(205, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // AmeliaChangBioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 295);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dreamJobTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.dreamJobLabel);
       //     this.Name = "AmeliaChangBioForm"; 
       //     this.Text = "Amelia Chang BioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dreamJobLabel;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox dreamJobTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}