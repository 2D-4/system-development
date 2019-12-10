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
            DialogResult result = MessageBox.Show("終了しますか？", "終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true; //画面を閉じようとすると確認ポップ画面を出す
            }
        }
        
        private void dataload()   //カスタム関数
        {
            // SQL関係はいずれ変える
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT * FROM 発注詳細テーブル ORDER BY 商品ID", cn);
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
                new OleDbCommand("UPDATE 発注数量 SET 発注数量 = @quantity WHERE 商品ID = @id", cn);
            cmd.Parameters.AddWithValue("@quantity", fOStB1.Text);                 //数量のデータ
            cmd.Parameters.AddWithValue("@id", fOSDataGridview.Rows[0].Cells["商品ID"].Value); //選択行
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
                OleDbCommand cmd = new OleDbCommand("DELETE FROM 発注詳細テーブル WHERE 商品ID = @id", cn);  //ID
                cmd.Parameters.AddWithValue("@id", fOSDataGridview.Rows[0].Cells["商品ID"].Value);
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
                //System.IO.StreamWriter sw = new System.IO.StreamWriter(
                //    "C:/Users/B8035/Desktop/上柴進捗/test.txt", false, System.Text.Encoding.Default);
                //sw.WriteLine("うまくいきよったか？");
                //sw.Close();
            }
        }

        private void fOSbackBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmOrderStockManegement.Show();
        }
        
        private void savedata()
        {
            //string path = "発注書.csv"; //出力ファイル
            //string strData = ""; //一行分のデータ
            //System.IO.StreamWriter sw = new System.IO.StreamWriter(
            //    path, false, System.Text.Encoding.Default);
            //foreach (habigisu.frmOrderStockCreation.)
            //{
            //    strData = 商品名
            //        　　+ 数量
            //}
        }

    }
}
