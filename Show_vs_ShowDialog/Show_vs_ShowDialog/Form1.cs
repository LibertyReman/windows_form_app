﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Show_vs_ShowDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AAAFormButton_Click(object sender, EventArgs e)
        {
            var f = new AAAForm();
            //AAAFormはShowで表示したのでダイアログリザルトを設定した場合でも、自動で画面が閉じない
            f.Show();
        }

        private void BBBFormButton_Click(object sender, EventArgs e)
        {
            var f = new BBBForm();
            f.ShowDialog();
        }
    }
}
