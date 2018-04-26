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
            this.showAmeliaBioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // professorButton
            // 
            this.professorButton.Location = new System.Drawing.Point(13, 29);
            this.professorButton.Name = "professorButton";
            this.professorButton.Size = new System.Drawing.Size(75, 23);
            this.professorButton.TabIndex = 0;
            this.professorButton.Text = "Professor";
            this.professorButton.UseVisualStyleBackColor = true;
            // 
            // showAmeliaBioButton
            // 
            this.showAmeliaBioButton.Location = new System.Drawing.Point(448, 206);
            this.showAmeliaBioButton.Name = "showAmeliaBioButton";
            this.showAmeliaBioButton.Size = new System.Drawing.Size(117, 23);
            this.showAmeliaBioButton.TabIndex = 1;
            this.showAmeliaBioButton.Text = "Open Amelia\'s Bio";
            this.showAmeliaBioButton.UseVisualStyleBackColor = true;
            this.showAmeliaBioButton.Click += new System.EventHandler(this.showAmeliaBioButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showAmeliaBioButton);
            this.Controls.Add(this.professorButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button professorButton;
        private System.Windows.Forms.Button showAmeliaBioButton;
    }
}

