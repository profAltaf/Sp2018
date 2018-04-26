// Aaron Ho CIS 345 10:30 - 11:45 AM
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

        private void showAaronHoBioButton_Click(object sender, EventArgs e)
        {
            AaronHoBioForm aaronHoBioForm = new AaronHoBioForm();

            aaronHoBioForm.Show();
        }
    }
}
