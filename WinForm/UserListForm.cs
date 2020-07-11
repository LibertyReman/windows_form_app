using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();

            //データを読み込む
            string[] lines = System.IO.File.ReadAllLines("save.csv",Encoding.GetEncoding("shift_jis"));

            foreach (string line in lines)
            {
                string[] row = line.Split(',');
            }
        }
    }
}

