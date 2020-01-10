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
    public partial class frmOrderStockCreation : Form
    {
        OleDbConnection cn = new OleDbConnection(); //グローバル変数　コネクションオブジェクト
        public frmOrderStockCreation()
        {
            InitializeComponent();
        }

        private void frmOrderStockCreation_Load(object sender, EventArgs e)
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\habigisu.accdb;";
            dataload();
        }

        private void frmOrderStockCreation_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("今の画面を終了しますか？", "終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true; //画面を閉じようとすると確認ポップ画面を出す
            }
            else
            {
                //this.Hide();
                //frmOrderStockManegement.Show();
            }
        }
        
        private void dataload()   //カスタム関数
        {
            // SQL関係はいずれ変える
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT * FROM 発注詳細テーブル ORDER BY 発注ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fOSDataGridview.DataSource = dt;
            fOSDataGridview.AllowUserToAddRows = false;    //最下行を非表示
            fOSDataGridview.AutoResizeColumns();           //列の幅の自動調整
        }

        private void fOSupdateBtn_Click(object sender, EventArgs e)
        {
            int selectrow = fOSDataGridview.CurrentCell.ColumnIndex;                 //選択されている行番号
            OleDbCommand cmd =
                new OleDbCommand("UPDATE 発注詳細テーブル SET 発注数量 = @quantity ", cn);

            Console.WriteLine("@quantity");
            cmd.Parameters.AddWithValue("@quantity", fOStB1.Text);                 //数量のデータ
            try
            {
                cn.Open();                 //コネクションを開く
                cmd.ExecuteReader();     //SQLを実行
                cn.Close();                //コネクションを閉じる
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();                //コネクションを閉じる
                return;
            }

            dataload();                    //データをロードする関数
            MessageBox.Show("更新しました", "habigisu");
        }

        private void fOSCancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("指定された内容を削除してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                int selectrow = fOSDataGridview.CurrentCell.ColumnIndex;                 //選択されている行番号
                OleDbCommand cmd = new OleDbCommand("DELETE FROM 発注詳細テーブル WHERE 発注ID = @id ", cn);  //ID
                Console.WriteLine("@id");
                cmd.Parameters.AddWithValue("@id", fOSDataGridview.Rows[0].Cells["発注ID"].Value);
                try
                {
                    cn.Open();                 //コネクションを開く
                    cmd.ExecuteNonQuery();     //SQLを実行
                    cn.Close();                //コネクションを閉じる
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();                //コネクションを閉じる
                    return;
                }
                
                dataload();                   //データをロードする関数
                MessageBox.Show("削除しました", "habigisu",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void fOSconfirmBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("内容を確定してよろしいですか？", "最終確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                savedata();
            }

            //this.Hide();
            //frmOrderStockManegement.Show();
        }

        private void fOSbackBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmOrderStockManegement.Show();
        }
        
        private void savedata()
        {
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT * FROM 発注詳細テーブル ORDER BY 発注ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string path = "発注書.csv"; //出力ファイル
            string strData = ""; //一行分のデータ
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                path, false, System.Text.Encoding.Default);
            foreach (DataRow hattyusho in dt.Rows)
            {
                strData = hattyusho[0] + ","
                        + hattyusho[1] + ","
                        + hattyusho[2] + ","
                        + hattyusho[3].ToString() + ","
                        + hattyusho[4].ToString();
                sw.WriteLine(strData);
            }
        }
    }
}
