//Tyler Thomas, IC17, CIS 345 Tues/Thurs 10:30
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
    public partial class TylerThomasBioForm : Form
    {
        public TylerThomasBioForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
