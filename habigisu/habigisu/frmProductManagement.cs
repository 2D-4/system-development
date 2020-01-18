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



        private int  Search()　　　　　　　　　　　　　　　　//検索項目を使いSQLで検索する。
        {
            string[] Prodcut = new string[5];

            Prodcut[0] = FPMGenreCBox.Text; //ジャンル (分類コードを先に特定しないといけない、検索できない) 
            Prodcut[1] = FPMPubTbox.Text; //出版社名 (仕入れ先ID を先に特定しないといけない、検索できない)
            Prodcut[2] = FPMPidTbox.Text; //商品ID
            Prodcut[3] = FPMProTbox.Text;  //商品名
            Prodcut[4] = FPMAutTbox.Text;  //著者名


            int flg = 0; //テーブル結合検索が複数ある場合も大丈夫なように、WHERE句を別に分ける
            int count = 0; //1つ以上あるかどうか(テーブル結合検索以外で
            
            string sql = "SELECT 商品マスタ.* FROM ";



            for (int i = 0; i < 5; i++)
            {
                if (Prodcut[i] != "")
                {
                    if (count == 0)
                    {
                        switch (i)
                        {
                            case 0: //ジャンル検索
                                {
                                    sql += "(ジャンルマスタ INNER JOIN 分類マスタ ON 分類マスタ.ジャンルID=ジャンルマスタ.ID)INNER JOIN 商品マスタ ON 商品マスタ.分類コード= 分類マスタ.分類コード WHERE ジャンルマスタ.ジャンル名='" + Prodcut[i] + "'";

                                    flg += 1;//WHERE句様のやつ(家でやる)
                                    break;
                                }

                            case 1: //出版社検索
                                {
                                    sql += "商品マスタ LEFT JOIN 仕入先マスタ ON 商品マスタ.仕入先ID=仕入先マスタ.ID WHERE 仕入先マスタ.仕入先名='" + Prodcut[i] + "'";

                                    flg += 2; //同じようにやる↑
                                    break;
                                }
                                

                            case 2: //商品ID検索
                                {
                                    sql += "商品マスタ WHERE ";
                                    sql += "ID Like '%" + Prodcut[i] + "' ";
                                    count++;
                                    break;
                                }

                            case 3: //商品名検索
                                {
                                    sql += "商品マスタ WHERE ";
                                    sql += "商品名 Like '%" + Prodcut[i] + "%' ";
                                    count++;
                                    break;
                                }

                            case 4: //著者名検索
                                {
                                    sql += "商品マスタ WHERE ";
                                    sql += "著者名 Like '%" + Prodcut[i] + "%' ";
                                    count++;
                                    break;
                                }
                        }

                    }
                    else //一つ以上の検索内容があった場合
                    {
                        sql += " AND ";
                        switch (i)
                        {     
                            case 2: //商品ID検索
                                sql += "ID Like '%" + Prodcut[i] + "' ";
                                break;
                            case 3: //商品名検索
                                sql += "商品名 Like '%" + Prodcut[i] + "%' ";
                                break;
                            case 4: //著者名検索
                                sql += "著者名 Like '%" + Prodcut[i] + "%' ";
                                break;
                        }

                    }
                }
            }

            selfunc(sql);

            return 0;
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
                Search(); //検索表示
            }
        }

        private void FPMSearchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void FPMPlistBtn_Click(object sender, EventArgs e)
        {
            selfunc("SELECT * FROM 商品マスタ");  //全商品表示
        }
    }
}
