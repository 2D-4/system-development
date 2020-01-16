using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habigisu
{
    //役職ｺｰﾄﾞ、部署ｺｰﾄﾞの3桁目で判断し、レベル毎に閲覧を制限するクラス
    class AuthoritySelector
    {
        OleDbConnection cn = new OleDbConnection(); //グローバル変数　コネクションオブジェクト

        //部署毎の管理レベルに応じて閲覧を制限する関数
        public int CheckDeptAuthority(int ManageNumber, string eid)
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\habigisu.accdb;";

            OleDbDataAdapter da = new OleDbDataAdapter(); //データアダプタオブジェクト
            OleDbCommand cmd = new OleDbCommand();        //コマンドオブジェクト
            cmd.Connection = cn;
            cn.Open();

            cmd.CommandText = "SELECT 部署ｺｰﾄﾞ FROM 社員マスタ WHERE ID=@id"; //部署ｺｰﾄﾞをDBから取得するSQL文
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@id", eid);        //IDのパラメータ
            DataTable dt = new DataTable();
                da.Fill(dt);
            if (dt.Rows.Count > 0)                           //検索結果が正常に帰ってきた時
            {
                string dcode = cmd.ExecuteScalar().ToString();
                cn.Close();
                char d1 = dcode[0];
                switch (ManageNumber)
                {
                    case 0:
                        if (d1 == '4')
                            return 0;
                        break;
                    case 1:
                        if (d1 == '3' || d1 == '4')
                            return 0;
                        break;
                    case 2:
                        if (d1 == '3' || d1 == '4')
                            return 0;
                        break;
                    default:
                        break;
                }
                return -1;
            }
            else
                cn.Close();
            return -1;
        }

        //役職毎の管理レベルに応じて閲覧を制限する関数
        public int CheckPosAuthority(int ManageNumber, string eid)
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\habigisu.accdb;";

            OleDbDataAdapter da = new OleDbDataAdapter(); //データアダプタオブジェクト
            OleDbCommand cmd = new OleDbCommand();        //コマンドオブジェクト
            cmd.Connection = cn;
            cn.Open();

            cmd.CommandText = "SELECT 役職ｺｰﾄﾞ FROM 社員マスタ WHERE ID=@id"; //役職ｺｰﾄﾞをDBから取得するSQL文
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@id", eid);        //IDのパラメータ
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)                           //検索結果が正常に帰ってきた時
            {
                string pcode = cmd.ExecuteScalar().ToString();
                cn.Close();
                char p1 = pcode[0];
                switch (ManageNumber)
                {
                    case 0:
                        if (p1 == '1' || p1 == '4' || p1 == '5' || p1 == '6')
                            return 0;
                        cn.Close();
                        break;
                    case 1:
                        if (p1 == '1' || p1 == '4' || p1 == '5')
                            return 0;
                        break;
                    case 2:
                        if (p1 == '1' || p1 == '4')
                            return 0;
                        break;
                    default:
                        break;
                }
                return -1;
            }
            else
                cn.Close();
            return -1;
        }
    }
}
