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

            StatusLabel.Text = "必要事項を記入して保存してください";


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
        

        //保存ボタンクリックイベント
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //空白を除いて1文字以下　＝　空白の場合
            if(IdTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("IDを入力してください",
                    "警告",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                IdTextBox.Focus();
                return;

            }

            if (IdTextBox.Text.Contains(","))
            {
                MessageBox.Show("IDにカンマは入力できません",
                    "警告",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                IdTextBox.Focus();
                return;
            }

            if (MailAddressTextBox.Text.Contains(","))
            {
                MessageBox.Show("メールアドレスにカンマは入力できません",
                    "警告",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                MailAddressTextBox.Focus();
                return;
            }


            DialogResult dialogResult = MessageBox.Show("保存しますか？", "確認", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {

                using (var sw = new
                    System.IO.StreamWriter(
                    "save.csv", true, Encoding.GetEncoding("shift_jis")))
                {
                    sw.Write(IdTextBox.Text);
                    sw.Write(",");
                    sw.Write(MailCheckBox.Checked);
                    sw.Write(",");
                    sw.Write(MailAddressTextBox.Text);
                    sw.Write(",");
                    if (BusinessRadioButton.Checked)
                    {
                        sw.Write("1");
                    }
                    else
                    {
                        sw.Write("0");
                    }
                    sw.Write(",");
                    sw.Write(EnableComboBox.Text);
                    sw.WriteLine("");


                }
                StatusLabel.Text = "保存しました";
            }
            else
            {
                StatusLabel.Text = "キャンセルしました";

            }


        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //画面を閉じる
            Close();
        }
    }
}
