// IC17, Joshua Roldan, CIS 345, 10:30AM

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
    public partial class JoshuaRoldanBioForm : Form
    {
        public JoshuaRoldanBioForm()
        {
            InitializeComponent();

            // the nameTextBox and dreamJobTextBox values are set
            nameTextBox.Text = "Joshua Roldan";
            dreamJobTextBox.Text = "Pro basketball player";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // form is closed
            this.Close();
        }
    }
}
