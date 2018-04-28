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
            this.RastkoStojsinBioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RastkoStojsinBioButton
            // 
            this.RastkoStojsinBioButton.Location = new System.Drawing.Point(120, 99);
            this.RastkoStojsinBioButton.Name = "RastkoStojsinBioButton";
            this.RastkoStojsinBioButton.Size = new System.Drawing.Size(132, 57);
            this.RastkoStojsinBioButton.TabIndex = 0;
            this.RastkoStojsinBioButton.Text = "Rastko Stojsin";
            this.RastkoStojsinBioButton.UseVisualStyleBackColor = true;
            this.RastkoStojsinBioButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(348, 244);
            this.Controls.Add(this.RastkoStojsinBioButton);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button professorButton;
        private System.Windows.Forms.Button RastkoStojsinBioButton;
    }
}

