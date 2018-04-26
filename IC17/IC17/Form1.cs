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

        private void showJoshuaBioButton_Click(object sender, EventArgs e)
        {
            // Form is instantiated and shown
            JoshuaRoldanBioForm joshForm = new JoshuaRoldanBioForm();
            joshForm.Show();
        }
    }
}
