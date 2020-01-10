using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace habigisu
{
    //パスワードをハッシュ化し、DB内の文字列と一致しているかを判定するクラス
    class PasswordHash
    {
        OleDbConnection cn = new OleDbConnection(); //グローバル変数　コネクションオブジェクト
        
        //ソルトとパスワードを用いてハッシュ化した文字列を返す関数
        private string GeneratePasswordHash(string pwd, string salt)
        {
            string saltpwd = String.Concat(pwd, salt);                                  //saltとpwdを連結
            UTF8Encoding encoder = new UTF8Encoding();
            byte[] buffer = encoder.GetBytes(saltpwd);                                  //UTF-8にエンコード
            SHA256CryptoServiceProvider csp = new SHA256CryptoServiceProvider();
            byte[] hash = csp.ComputeHash(buffer);                                      //ハッシュ化
            return Convert.ToBase64String(hash);                                        //Base64で返却
        }
        //ハッシュ化文字列がDB内のハッシュ化文字列と一致しているかを判定、DBにハッシュ化文字列がなければ格納する関数
        private int CheckPassword(string hspass ,string id)
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\habigisu.accdb;";

            OleDbDataAdapter da = new OleDbDataAdapter(); //データアダプタオブジェクト
            OleDbCommand cmd = new OleDbCommand();        //コマンドオブジェクト
            cmd.Connection = cn;
            cn.Open();

            cmd.CommandText = "SELECT パスワード FROM 社員PASSテーブル WHERE 社員ID=@id"; //ハッシュ化パスワードをDBからとってくるSQL文
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@id", id);       //IDのパラメータ
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)                          //検索結果が正常に帰ってきた時
            {
                string pass = cmd.ExecuteScalar().ToString();     //DBから見つかったパスワードを変数passに格納
                Console.WriteLine(pass);

                if (pass.Length != 44)                    //ハッシュ文字列がまだ空白の場合
                {
                    pass = hspass;                //ハッシュ文字列作成する

                    //DBにハッシュ文字列を格納する
                    cmd.CommandText = "UPDATE 社員PASSテーブル SET パスワード='" + pass
                        + "' WHERE 社員ID=@eid";
                    try
                    {
                        cmd.ExecuteNonQuery();           //UPDATE文実行
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return -1;              //DBを確認
                    }
                }
                if (pass == hspass)                       //パスワードがひとしければ
                {
                    return 0;
                }
                else
                {
                    return -1;                          //パスワードいっちしないよ
                }
            }
            else
            {
                return -1;                             //社員番号ないよ
            }
        }

        //パスワードをハッシュ化,判定して正しければ社員番号と社員名を返却する関数
        public string CheckEmployee(string pwd, string salt,string eid)
        {
            if(CheckPassword(GeneratePasswordHash(pwd, salt), eid) == 0)
            {
                OleDbDataAdapter da = new OleDbDataAdapter(); //データアダプタオブジェクト
                OleDbCommand cmd = new OleDbCommand();        //コマンドオブジェクト
                cmd.Connection = cn;

                cmd.CommandText = "SELECT 氏名ｶﾅ FROM 社員マスタ WHERE ID=@eid"; //氏名をDBからとってくるSQL文
                da.SelectCommand = cmd;

                cmd.Parameters.AddWithValue("@eid", eid);       //IDのパラメータ
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0)                           //検索結果が正常に帰ってきたとき
                {
                    string ekana = cmd.ExecuteScalar().ToString();    //DBから見つかった社員名をekanaへ格納
                    cn.Close();
                    return ekana;                                       //正常な返却地
                }
               
                else
                {
                    MessageBox.Show("社員番号、もしくはパスワードが間違っているか、存在しません。");
                    return "\0";
                }
            }
            else
                MessageBox.Show("社員番号、もしくはパスワードが間違っているか、存在しません。");
            return "\0";                                                //社員番号ないよ
        }
    }
}