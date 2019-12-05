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

        private void dataload()   //カスタム関数
        {
            // SQL関係はいずれ変える
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT ID,Pass AS パスワード,Name AS 名前, " +
                "PostNumber AS 郵便番号,Address AS 住所 FROM MEMBER ORDER BY ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fOSDataGridview.DataSource = dt;
            fOSDataGridview.AllowUserToAddRows = false;    //最下行を非表示
            fOSDataGridview.AutoResizeColumns();           //列の幅の自動調整
        }

        private void fOSupdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void fOSCancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("指定された内容を削除してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                int selectrow = fOSDataGridview.CurrentCell.ColumnIndex;                 //選択されている行番号
                OleDbCommand cmd = new OleDbCommand("DELETE FROM Member WHERE 略 = @id", cn);  //ID
                cmd.Parameters.AddWithValue("@id", fOSDataGridview.Rows[0].Cells["ID"].Value);
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
                MessageBox.Show("削除しました", "住所録");
            }
        }

        private void fOSconfirmBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("内容を確定してよろしいですか？", "最終確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                
                //書類生成のコードを打ち込む予定
            }
        }

        private void fOSbackBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmOrderStockManegement.Show();
        }
    }
}
