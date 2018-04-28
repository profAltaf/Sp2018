namespace IC17
{
    partial class AlexaMeyerBioForm
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
            this.jobLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(55, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(55, 134);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(77, 17);
            this.jobLabel.TabIndex = 1;
            this.jobLabel.Text = "Dream Job";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(238, 63);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(164, 22);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.Text = "Alexa Meyer";
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // jobTextBox
            // 
            this.jobTextBox.Location = new System.Drawing.Point(238, 131);
            this.jobTextBox.Multiline = true;
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(164, 53);
            this.jobTextBox.TabIndex = 3;
            this.jobTextBox.Text = "Director of a main series Pokemon game";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(238, 232);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(164, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close the Application";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AlexaMeyerBioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 291);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AlexaMeyerBioForm";
            this.Text = "AlexaMeyerBioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}