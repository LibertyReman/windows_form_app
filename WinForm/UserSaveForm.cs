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
    public partial class UserSaveForm : Form
    {
        //UserSaveForm()はクラス名　public -..はコンストラクタ
        //オブジェクトが生成されるときに呼ばれる
        public UserSaveForm()
        {
            //UserSaveForm.Designer.csが動く 画面のレイアウトが設定される
            InitializeComponent();

            //起動時にチェックボックスはオフなのでテキストボックスはグレーアウトする
            SetMailAddressTextBox();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetMailAddressTextBox();
        }

        //自作関数を作る
        private void SetMailAddressTextBox()
        {
  
            MailAddressTextBox.Enabled = MailCheckBox.Checked;
            MailAddressLabel.Enabled = MailCheckBox.Checked;

        }

    }
}
