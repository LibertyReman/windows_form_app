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

            EnableComboBox.Items.Add("有効");
            EnableComboBox.Items.Add("無効");
            //コンボボックスにテキストを入力できないようにする
            EnableComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //コンボボックスの初期値を設定
            EnableComboBox.SelectedIndex = 0;


            //起動時のチェックを指定する
            MailCheckBox.Checked = false;
            FreeRadioButton.Checked = true;


            //起動時にチェックボックスはオフなのでテキストボックスはグレーアウトする
            SetMailAddressTextBox();
            PlanChange();


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

        private void BusinessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PlanChange();
        }


        //自作関数
        private void PlanChange()
        {
            NoteLabel.Visible = BusinessRadioButton.Checked;
        }

    }
}
