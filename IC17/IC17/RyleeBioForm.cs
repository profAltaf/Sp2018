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
    public partial class RyleeBioForm : Form
    {
        public RyleeBioForm()
        {
            InitializeComponent();

            dreamJobTextBox.Text = "Billionaire Venture Capitalist funding social enterprises";

            nameTextBox.Text = "Rylee Dunkel";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
