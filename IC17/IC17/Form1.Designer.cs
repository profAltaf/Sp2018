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
            this.showAaronHoBioButton = new System.Windows.Forms.Button();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.showAaronHoBioButton);
            this.Controls.Add(this.professorButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button professorButton;
        private System.Windows.Forms.Button showAaronHoBioButton;
    }
}

