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

        private void showAaronHoBioButton_Click(object sender, EventArgs e)
        {
            AaronHoBioForm aaronHoBioForm = new AaronHoBioForm();
            aaronHoBioForm.Show();
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

        private void showQuinnBioButton_Click(object sender, EventArgs e)
        {
            QuinnMcElroyBioForm qmForm = new QuinnMcElroyBioForm();
            qmForm.Show();
        }

        private void RyleeBioButton_Click(object sender, EventArgs e)
        {
            RyleeBioForm ryleeBioForm = new RyleeBioForm();

            

            ryleeBioForm.Show();
        }

        private void showAndrewStievaterBioButton_Click(object sender, EventArgs e)
        {
            AndrewStievaterBioForm andrewStievaterBioForm = new AndrewStievaterBioForm();

            andrewStievaterBioForm.Show();
        }
    }
}
