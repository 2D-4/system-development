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
    public partial class frmProductManagement : Form
    {
        OleDbConnection cn = new OleDbConnection();   //コネクションオブジェクト

        public frmProductManagement()
        {
            InitializeComponent();
        }


        private void selfunc(string sql)
        {
            dataGridView1.DataSource = null;
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;         //データベースに設定
            dataGridView1.AutoResizeColumns();     //列の幅の自動調整
        }



        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\habigisu.accdb;";

            selfunc("SELECT * FROM 商品マスタ");  //全項目
        }



        private int ProdcutSearch(string str)
        {
            //OleDbDataAdapter da = new OleDbDataAdapter(); //データアダプタオブジェクト
            //OleDbCommand cmd = new OleDbCommand();        //コマンドオブジェクト
            //string sid = FPMGenreCBox.Text;
            //cmd.Connection = cn;

            //cmd.CommandText="SELECT ID FROM ジャンルマスタ WHERE ID=@sid ジャンル名";

            //cmd.Parameters.AddWithValue("@sid", sid);  //SQLインジェクション対策

            //Dateset文を使って家でやる。　調べる。

            //cmd.ExecuteScalar;
            //GenreID = cmd.ExecuteNonQuery;
            if (str.Length==0)
            {
                
            }

            return 0; //書かないとエラーおこるのであとりあえず、後で消す
        }


        private void frmProductManagement_Shown(object sender, EventArgs e)
        {
            FPMPidTbox.Focus(); //商品IDにフォーカスを当てる

            dataGridView1.AllowUserToAddRows = false; //DBの最下行を非表示
        }


        //Foucs

        private void FPMPidTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Enterキーであれば
            {
                FPMProTbox.Focus(); //商品IDを入力すると商品名にフォーカスを当てる
            }
        }

        private void FPMProTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Enterキーであれば
            {
                FPMGenreCBox.Focus(); //商品名を入力するとジャンルにフォーカスを当てる
            }
        }

        private void FPMGenreCBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Enterキーであれば
            {
                FPMAutTbox.Focus(); //ジャンルを入力すると著者名にフォーカスを当てる
            }
        }

        private void FPMAutTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Enterキーであれば
            {
                FPMPubTbox.Focus(); //著者名を入力すると出版社にフォーカスを当てる
            }
        }


        //検索ボタン

        private void FPMSearchBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Enterキーであれば
            {　
                string ProdcutID = FPMPidTbox.Text; //商品ID
                string Prname = FPMProTbox.Text;  //商品名
                string CCode = FPMGenreCBox.Text; //ジャンル (分類コードを先に特定しないといけない、検索できない)
                string Author = FPMAutTbox.Text;  //著者名   (仕入れ先ID を先に特定しないといけない、検索できない)　　最悪変える。


            }
        }
    }
}
