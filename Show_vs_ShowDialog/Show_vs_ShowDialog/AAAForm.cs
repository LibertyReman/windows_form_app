using System;
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
    public partial class AAAForm : Form
    {
        public AAAForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //showの場合、画面を閉じる動作を記述する必要あり
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //showの場合、画面を閉じる動作を記述する必要あり
            Close();
        }
    }
}
