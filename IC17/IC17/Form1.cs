// Kai Liang, IC17, CIS 345, Tuesday 10:30 AM
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
        BoBioForm boForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void showKaiLiangBioButton_Click(object sender, EventArgs e)
        {
            KaiLiangBioForm kaiLiangBio = new KaiLiangBioForm();
            kaiLiangBio.Show();
        }

        private void showBoBioButton_Click(object sender, EventArgs e)
        {
            boForm = new BoBioForm();
            boForm.Show();
        }

        private void showAntonioPaolettiBioButton_Click(object sender, EventArgs e)
        {
            AntonioPaolettiBioForm tmpForm = new AntonioPaolettiBioForm();

            tmpForm.Show();
        }
    }
}
