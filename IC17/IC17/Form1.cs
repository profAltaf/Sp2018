﻿using System;
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
        JingyuZhuBioForm JingyuZhuBioForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void showJingyuZhuBioButton_Click(object sender, EventArgs e)
        {
            JingyuZhuBioForm = new JingyuZhuBioForm();
            JingyuZhuBioForm.Show();
        }
    }
}
