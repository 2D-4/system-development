﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.OleDb;
using System.Data;

namespace habigisu
{

    //パスワードをハッシュ化するクラス
    class PasswordHash
    {
        OleDbConnection cn = new OleDbConnection(); //グローバル変数　コネクションオブジェクト
        
        //ハッシュ文字列を作成して返す処理
        private string SaltToMake()
        {
            const int SALT_SIZE = 24;

            var buff = new byte[SALT_SIZE];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(buff);
            }
            string salt = Convert.ToBase64String(buff);
            return salt;
        }

        //DBに格納されている各社員のソルトがあるかを確認し、なければ新たにソルトを作成,保存し、そのソルトと入力されたパスワードを用いてハッシュ化した文字列を返す関数
        public string PasswordToHash(string eid, string pwd)
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\habigisu.accdb;";

            OleDbDataAdapter da = new OleDbDataAdapter(); //データアダプタオブジェクト
            OleDbCommand cmd = new OleDbCommand();        //コマンドオブジェクト
<<<<<<< HEAD
            cmd.Connection = cn;
            cn.Open();

            cmd.CommandText = "SELECT ハッシュ文字列 FROM 社員PASSテーブル WHERE 社員ID=@eid"; //ハッシュ文字列をDBからとってくるSQL文
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@eid", eid);       //IDのパラメータ
            DataTable dt = new DataTable();
            da.Fill(dt);

            string salt = "\0";

            
            //Console.WriteLine();

            if(dt.Rows.Count > 0)                       //SQL文が正常に帰ってきた時
            {
                salt = cmd.ExecuteScalar().ToString();　//DBから見つかったハッシュ文字列を変数saltに格納

                if(salt.Length != 32)                   //ハッシュ文字列がまだ空白の場合
                {
                    salt = SaltToMake();                //ハッシュ文字列作成する
                    //DBにハッシュ文字列を格納する
                    cmd.CommandText = "INSERT INTO 社員PASSテーブル (ハッシュ文字列)"
                        + "VALUES (@salt)";

                    cmd.Parameters.AddWithValue("@salt", salt);

                    try//未着手
                    {
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("muripo");
                    }//while
                }  
            }
            else
            {
                return "\0";
            }
           
            return "hoge";
        }
    }
}
=======

            cmd.Connection = cn;

           cmd.CommandText = "SELECT * FROM 社員PASSテーブル WHERE ID=@eid AND PASS=@pwd"

            string salt = "\0";


            const int SALT_SIZE = 24;

            var buff = new byte[SALT_SIZE];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(buff);
            }
            salt = Convert.ToBase64String(buff);
            return Convert.ToBase64String(buff);
        }
    }
}
