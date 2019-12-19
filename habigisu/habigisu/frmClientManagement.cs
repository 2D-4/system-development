using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace habigisu
{
    public partial class frmClientManagement : Form
    {
        public frmClientManagement()
        {
            InitializeComponent();

        }

        private void fCMCLBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
            builder.Provider = "Microsoft.ACE.OLEDB.12.0";
            builder.DataSource = "../../../../doc/DB/Habigisu.accdb";
            using (OleDbConnection conn = new OleDbConnection(builder.ConnectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT ID, 会社名, 代表者名, 住所, 郵便番号, 電話番号, メールアドレス FROM 顧客マスタ", conn))
                {
                    OleDbDataAdapter odda = new OleDbDataAdapter();
                    odda.SelectCommand = cmd;
                    odda.Fill(dt);
                    fCMDataGridView.DataSource = dt;
                }
            }
        }

        private void fCMSearchBtn_Click(object sender, EventArgs e)
        {
            //検索
        }

        private void fCMRegisterBtn_Click(object sender, EventArgs e)
        {
           // frmClientRegister.cs frmClientRegister = new frmClientRegister.cs();
           // frmClientRegister.show();      //顧客登録画面を表示
        }

        private void fCMUpdateBtn_Click(object sender, EventArgs e)
        {
            //更新
        }

        private void fCMBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();  //閉じる
        }
    }
}
