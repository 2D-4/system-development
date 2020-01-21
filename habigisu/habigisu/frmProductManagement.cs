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
            string[] Prodcut = new string[6];

            Prodcut[0] = FPMPubTbox.Text; //出版社名 (仕入れ先ID を先に特定しないといけない、検索できない)
            Prodcut[1] = FPMGenreCBox.Text; //ジャンル (分類コードを先に特定しないといけない、検索できない) 
            Prodcut[2] = FPMPidTbox.Text; //商品ID
            Prodcut[3] = FPMProTbox.Text;  //商品名
            Prodcut[4] = FPMAutTbox.Text;  //著者名


            int flg = 0; //テーブル結合検索が複数ある場合も大丈夫なように、WHERE句を別に分ける
            int count = 0; //1つ以上あるかどうか(テーブル結合検索以外で
            
            string sql = "SELECT 商品マスタ.* FROM ";



            for (int i = 0; i <= 5; i++)
            {
                if (Prodcut[i] != "")
                {
                    if (count == 0)
                    {
                        switch (i)
                        {
                            case 0: //出版社検索

                                sql += " 商品マスタ LEFT JOIN 仕入先マスタ ";

                                flg += 1;   //出版社検索のWHERE句を覚えておく(最後に使う)
                                break;


                            case 1: //ジャンル検索

                                if (1 == flg)
                                {
                                    sql += "ジャンルマスタ LEFT JOIN 分類マスタ ";
                                }
                                else
                                {
                                   sql += "(ジャンルマスタ INNER JOIN 分類マスタ ON 分類マスタ.ジャンルID=ジャンルマスタ.ID)INNER JOIN 商品マスタ ";
                                }

                                flg += 2;   //ジャンル検索のWHERE句を覚えておく(最後に使う)
                                break;


                            case 2: //商品ID検索

                                if (flg == 0)   //テーブル結合のON句を追加
                                {
                                    sql += "商品マスタ ";   //なければFROM句にマスタを追加する
                                }
                                else
                                {
                                    switch (flg)
                                    {
                                        case 1:
                                            sql += "ON 商品マスタ.仕入先ID=仕入先マスタ.ID ";
                                            break;

                                        case 2:
                                             sql += "ON 商品マスタ.分類コード= 分類マスタ.分類コード ";
                                            break;

                                        case 3:
                                            sql += "ON 商品マスタ.仕入先ID=仕入先マスタ.ID ";
                                            sql += "ON 商品マスタ.分類コード= 分類マスタ.分類コード ";
                                            break;
                                    }
                                }

                                    sql += "WHERE 商品マスタ.ID Like '%" + Prodcut[i] + "' ";
                                    count++;
                                    break;
                                

                            case 3: //商品名検索

                                if (flg == 0)   //テーブル結合のON句を追加
                                {
                                    sql += "商品マスタ ";   //なければFROM句にマスタを追加する
                                }
                                else
                                {
                                    switch (flg)
                                    {
                                        case 1:
                                            sql += "ON 商品マスタ.仕入先ID=仕入先マスタ.ID ";
                                            break;

                                        case 2:
                                            sql += "ON 商品マスタ.分類コード= 分類マスタ.分類コード ";
                                            break;

                                        case 3:
                                            sql += "ON 商品マスタ.仕入先ID=仕入先マスタ.ID ";
                                            sql += "ON 商品マスタ.分類コード= 分類マスタ.分類コード ";
                                            break;
                                    }
                                }


                                sql += "WHERE 商品名 Like '%" + Prodcut[i] + "%' ";
                                    count++;
                                    break;
                                

                            case 4: //著者名検索

                                if (flg == 0)   //テーブル結合のON句を追加
                                {
                                    sql += "商品マスタ ";   //なければFROM句にマスタを追加する
                                }
                                else
                                {
                                    switch (flg)
                                    {
                                        case 1:
                                            sql += "ON 商品マスタ.仕入先ID=仕入先マスタ.ID ";
                                            break;

                                        case 2:
                                            sql += "ON 商品マスタ.分類コード= 分類マスタ.分類コード ";
                                            break;

                                        case 3:
                                            sql += "ON 商品マスタ.仕入先ID=仕入先マスタ.ID ";
                                            sql += "ON 商品マスタ.分類コード= 分類マスタ.分類コード ";
                                            break;
                                    }
                                }

                                sql += "WHERE 著者名 Like '%" + Prodcut[i] + "%' ";
                                    count++;
                                    break;


                            default:   //何もない場合(テーブル結合検索があり、著者名に項目がある場合の時の為に一度余分にfor文を回している。elseのif(1<=flg)を通すため)
                                    break;
                        }

                    }

                    else //一つ以上の検索内容があった場合
                    {


                        if (1 <= flg)   //ジャンル・出版社検索に項目があり、他にも項目がある場合(AND)
                        {
                            switch (flg)
                            {
                                case 1:   //テーブル結合検索が出版社だけの場合

                                        sql += " AND 仕入先マスタ.仕入先名='" + Prodcut[0] + "'";    //出版社(AND)
                                        flg = 0;
                                        break;

                                case 2:   //テーブル結合検索がジャンルだけの場合

                                        sql += " AND ジャンルマスタ.ジャンル名='" + Prodcut[1] + "'";   //ジャンル(AND)
                                        flg = 0;
                                        break;
                                    
                                
                                    
                                case 3:    //テーブル結合検索が両方ある場合

                                        sql += " AND ジャンルマスタ.ジャンル名='" + Prodcut[1] + "'";   //ジャンル(AND)
                                        sql += " AND 仕入先マスタ.仕入先名='" + Prodcut[0] + "'";   //出版社(AND)
                                        flg = 0;
                                        break;
                                    
                            }
                        }



                        
                        switch (i)
                        {     
                            case 2: //商品ID検索

                                sql += " AND ";
                                sql += "ID Like '%" + Prodcut[i] + "' ";
                                break;

                            case 3: //商品名検索

                                sql += " AND ";
                                sql += "商品名 Like '%" + Prodcut[i] + "%' ";
                                break;

                            case 4: //著者名検索

                                sql += " AND ";
                                sql += "著者名 Like '%" + Prodcut[i] + "%' ";
                                break;

                            default:   //テーブル結合検索があり、著者名に項目がある場合は、ここを通る(テーブル結合のAND句を通すため)
                                break;
                        }

                    }
                }
            }


            if (1 <= flg)   //ジャンル・出版社検索に項目があり、他にない場合(WHERE)
            {
                switch (flg)
                {
                    case 1:   //テーブル結合検索が出版社だけの場合
                        sql += "ON 商品マスタ.仕入先ID=仕入先マスタ.ID WHERE 仕入先マスタ.仕入先名='" + Prodcut[0] + "'";
                        //sql += "WHERE 仕入先マスタ.仕入先名='" + Prodcut[1] + "'";    //出版社(WHERE)
                        flg = 0;
                        
                            break;
                        
                    case 2:   //テーブル結合検索がジャンルだけの場合
                        sql += "ON 商品マスタ.分類コード= 分類マスタ.分類コード ";
                        sql += "WHERE ジャンルマスタ.ジャンル名='" + Prodcut[1] + "'";   //ジャンル(WHERE)
                        flg = 0;

                        break;
                        
                    case 3:    //テーブル結合検索が両方ある場合
                        sql += "ON 商品マスタ.分類コード= 分類マスタ.分類コード ";
                        sql += "ON 商品マスタ.仕入先ID=仕入先マスタ.ID ";
                        sql += "WHERE ジャンルマスタ.ジャンル名='" + Prodcut[1] + "'";   //ジャンル(WHERE)
                            sql += "AND 仕入先マスタ.仕入先名='" + Prodcut[0] + "'";   //出版社(AND)
                            flg = 0;
                            break;
                        
                }
            }



            selfunc(sql);   //SQL表示

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

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FPMPubTbox.Clear();  //出版社名 (仕入れ先ID を先に特定しないといけない、検索できない)
            FPMPidTbox.Clear();  //商品ID
            FPMProTbox.Clear();  //商品名
            FPMAutTbox.Clear();  //著者名
        }
    }
}
