using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC17
{
    public partial class QuinnMcElroyBioForm : Form
    {
        public QuinnMcElroyBioForm()
        {
            InitializeComponent();
        }

        private void QuinnMcElroyBioForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = "Quinn McElroy";
            dreamJobTextBox.Text = "Application Developer for Spotify";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
