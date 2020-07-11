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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AAAFormButton_Click(object sender, EventArgs e)
        {
            var f = new AAAForm();

            //閉じたときの呼ばれる関数を追加 +=入力後 tabで自動生成
            f.FormClosed += F_FormClosed;

            //AAAFormはShowで表示したのでダイアログリザルトを設定した場合でも、自動で画面が閉じない
            f.Show();
        }


        //閉じたときに呼ばれる関数
        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            //引数のsenderがAAAFormになっている。 asで型変換をすると使える
            var f = sender as AAAForm;

            if (f.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("OKが押されました");
            }
            else if (f.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelが押されました");
            }

        }

        private void BBBFormButton_Click(object sender, EventArgs e)
        {
            //値を渡す
            var f = new BBBForm(100);
            f.ShowDialog();
            //画面間の値を戻す
            MessageBox.Show(f.BBBValue + "円");
        }
    }
}
