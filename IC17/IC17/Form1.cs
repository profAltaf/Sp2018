//IC17, Joseph Wilson, 10:30AM, CIS 345
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void showJosephWilsonBioButton_Click(object sender, EventArgs e)
        {
            JosephWilsonBioForm form = new JosephWilsonBioForm();
            form.Show();
        }
    }
}
