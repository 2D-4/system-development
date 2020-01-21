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
            string[] array = new string[5];
            array[0] = fCMTBox.Text;
            // SELECT * FROM 顧客マスタ WHERE Client Like '落' AND 
            int count = 0;
            string sql = "SELECT * FROM 顧客マスタ";

            for (int i = 0; i < 1; i++)
            {
                if (array[i] != "")
                {
                    if (count == 0)
                    {
                        sql += " WHERE ";
                        switch (i)
                        {
                            case 0:
                                sql += "fCMTBox Like '" + array[i] + "' ";
                                break;
                        }
                        sql += array[i];
                        count++;
                    }
                    else
                    {
                        sql += " AND ";
                        switch (i)
                        {
                            case 0:
                                sql += "Client Like '" + array[i] + "' ";
                                break;
                        }
                        sql += array[i];
                    }
                }
            }
        }

        private void fCMRegisterBtn_Click(object sender, EventArgs e)
        {
           // frmClientRegister.cs frmClientRegister = new frmClientRegister.cs();
           // frmClientRegister.show();      //顧客登録画面を表示
        }

        private void fCMUpdateBtn_Click(object sender, EventArgs e)
        {
             //OledbcDataAdapter.Update(?) 更新


        }

        private void fCMBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();  //閉じる
        }
    }
}
