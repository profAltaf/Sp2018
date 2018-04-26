namespace IC17
{
    partial class HaozhengYuBioForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dreanJobLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dreamJobTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(93, 67);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // dreanJobLabel
            // 
            this.dreanJobLabel.AutoSize = true;
            this.dreanJobLabel.Location = new System.Drawing.Point(96, 120);
            this.dreanJobLabel.Name = "dreanJobLabel";
            this.dreanJobLabel.Size = new System.Drawing.Size(58, 13);
            this.dreanJobLabel.TabIndex = 2;
            this.dreanJobLabel.Text = "Dream Job";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(235, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // dreamJobTextBox
            // 
            this.dreamJobTextBox.Location = new System.Drawing.Point(235, 120);
            this.dreamJobTextBox.Name = "dreamJobTextBox";
            this.dreamJobTextBox.ReadOnly = true;
            this.dreamJobTextBox.Size = new System.Drawing.Size(100, 20);
            this.dreamJobTextBox.TabIndex = 4;
            // 
            // HaozhengYuBioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dreamJobTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dreanJobLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.button1);
            this.Name = "HaozhengYuBioForm";
            this.Text = "HaozhengYuBioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dreanJobLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox dreamJobTextBox;
    }
}