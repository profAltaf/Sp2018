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
    public partial class EmilyBeckBioForm : Form
    {
        public EmilyBeckBioForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmilyBeckBioForm_Load(object sender, EventArgs e)
        {
            dreamJobTextBox.Text = "Graduating college (hopefully)";
            nameTextBox.Text = "Emily Beck";
        }
    }
}
