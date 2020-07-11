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
        //型式UserInfoDTOの配列 
        private BindingList<UserInfoDTO> _dtos = new BindingList<UserInfoDTO>();
        public UserListForm()
        {
            InitializeComponent();

            //読み込むファイルが存在しているかチェック
            if (System.IO.File.Exists("save.csv"))
            {
                //データを読み込む
                string[] lines = System.IO.File.ReadAllLines("save.csv", Encoding.GetEncoding("shift_jis"));

                foreach (string line in lines)
                {
                    string[] row = line.Split(',');
                    UserInfoDTO dto = new UserInfoDTO(
                        row[0],
                        row[1],
                        row[2],
                        row[3],
                        row[4]);
                    //データ追加
                    _dtos.Add(dto);
                }

                //データを表示
                UserDataGrid.DataSource = _dtos;

                //カラム名を設定
                UserDataGrid.Columns[0].HeaderText = "ID";
                UserDataGrid.Columns[1].HeaderText = "メール送信";
                UserDataGrid.Columns[2].HeaderText = "メールアドレス";
                UserDataGrid.Columns[3].HeaderText = "プラン";
                UserDataGrid.Columns[4].HeaderText = "有効／無効";
            }

        }

    }
}

