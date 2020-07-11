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
    public partial class BBBForm : Form
    {
        //valueは BBBInitializeの中かっこを抜けると忘れるので_valueに退避させる
        //アンダーバーはプライベートな変数を宣言するときに使用するルール
        private int _value;

        //valueで値を受け取る
        public BBBForm(int value)
        {
            InitializeComponent();
            _value = value;

            this.Text = value.ToString();
        }
    }
}
