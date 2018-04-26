namespace IC17
{
    partial class Form1
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
            this.professorButton = new System.Windows.Forms.Button();
            this.showAntonioPaolettiBioButton = new System.Windows.Forms.Button();
            this.showBoBioButton = new System.Windows.Forms.Button();
            this.showKaiLiangBioButton = new System.Windows.Forms.Button();
            this.showQuinnBioButton = new System.Windows.Forms.Button();
            this.showAaronHoBioButton = new System.Windows.Forms.Button();
            this.RyleeBioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // professorButton
            // 
            this.professorButton.Location = new System.Drawing.Point(20, 45);
            this.professorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.professorButton.Name = "professorButton";
            this.professorButton.Size = new System.Drawing.Size(112, 35);
            this.professorButton.TabIndex = 0;
            this.professorButton.Text = "Professor";
            this.professorButton.UseVisualStyleBackColor = true;
            // 
            // showAaronHoBioButton
            // 
            this.showAaronHoBioButton.Location = new System.Drawing.Point(20, 199);
            this.showAaronHoBioButton.Name = "showAaronHoBioButton";
            this.showAaronHoBioButton.Size = new System.Drawing.Size(103, 35);
            this.showAaronHoBioButton.TabIndex = 1;
            this.showAaronHoBioButton.Text = "Aaron";
            this.showAaronHoBioButton.UseVisualStyleBackColor = true;
            this.showAaronHoBioButton.Click += new System.EventHandler(this.showAaronHoBioButton_Click);
            // 
            // showBoBioButton
            // 
            this.showBoBioButton.Location = new System.Drawing.Point(314, 305);
            this.showBoBioButton.Name = "showBoBioButton";
            this.showBoBioButton.Size = new System.Drawing.Size(75, 23);
            this.showBoBioButton.TabIndex = 1;
            this.showBoBioButton.Text = "Show";
            this.showBoBioButton.UseVisualStyleBackColor = true;
            this.showBoBioButton.Click += new System.EventHandler(this.showBoBioButton_Click);
            // 
            // showKaiLiangBioButton
            // 
            this.showKaiLiangBioButton.Location = new System.Drawing.Point(166, 28);
            this.showKaiLiangBioButton.Name = "showKaiLiangBioButton";
            this.showKaiLiangBioButton.Size = new System.Drawing.Size(142, 23);
            this.showKaiLiangBioButton.TabIndex = 1;
            this.showKaiLiangBioButton.Text = "Kai Liang";
            this.showKaiLiangBioButton.UseVisualStyleBackColor = true;
            this.showKaiLiangBioButton.Click += new System.EventHandler(this.showKaiLiangBioButton_Click);
            // 
            // showAntonioPaolettiBioButton
            // 
            this.showAntonioPaolettiBioButton.Location = new System.Drawing.Point(179, 395);
            this.showAntonioPaolettiBioButton.Name = "showAntonioPaolettiBioButton";
            this.showAntonioPaolettiBioButton.Size = new System.Drawing.Size(75, 23);
            this.showAntonioPaolettiBioButton.TabIndex = 1;
            this.showAntonioPaolettiBioButton.Text = "Antonio";
            this.showAntonioPaolettiBioButton.UseVisualStyleBackColor = true;
            this.showAntonioPaolettiBioButton.Click += new System.EventHandler(this.showAntonioPaolettiBioButton_Click);
            // 
            // showQuinnBioButton
            // 
            this.showQuinnBioButton.Location = new System.Drawing.Point(697, 364);
            this.showQuinnBioButton.Name = "showQuinnBioButton";
            this.showQuinnBioButton.Size = new System.Drawing.Size(75, 23);
            this.showQuinnBioButton.TabIndex = 1;
            this.showQuinnBioButton.Text = "Quinnilius";
            this.showQuinnBioButton.UseVisualStyleBackColor = true;
            this.showQuinnBioButton.Click += new System.EventHandler(this.showQuinnBioButton_Click);
            // 
            // RyleeBioButton
            // 
            this.RyleeBioButton.Location = new System.Drawing.Point(637, 404);
            this.RyleeBioButton.Name = "RyleeBioButton";
            this.RyleeBioButton.Size = new System.Drawing.Size(75, 23);
            this.RyleeBioButton.TabIndex = 1;
            this.RyleeBioButton.Text = "Rylee";
            this.RyleeBioButton.UseVisualStyleBackColor = true;
            this.RyleeBioButton.Click += new System.EventHandler(this.RyleeBioButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.showAaronHoBioButton);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showKaiLiangBioButton);
            this.Controls.Add(this.showBoBioButton);
            this.Controls.Add(this.showAntonioPaolettiBioButton);
            this.Controls.Add(this.showQuinnBioButton);
            this.Controls.Add(this.RyleeBioButton);
            this.Controls.Add(this.professorButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button professorButton;
        private System.Windows.Forms.Button showAaronHoBioButton;
        private System.Windows.Forms.Button showKaiLiangBioButton;
        private System.Windows.Forms.Button showBoBioButton;
        private System.Windows.Forms.Button showAntonioPaolettiBioButton;
        private System.Windows.Forms.Button showQuinnBioButton;
        private System.Windows.Forms.Button RyleeBioButton;
    }
}

