using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace habigisu
{
    public partial class frmOrderCreation : Form
    {

        public frmOrderCreation()
        {
            InitializeComponent();
        }

            private void fOCSaveBtn_Click(object sender, EventArgs e)
            {
                DialogResult result = MessageBox.Show("内容を保存してもよろしいですか？","確認画面",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                frmOrderCreation form2 = new frmOrderCreation();
                form2.Close();
            }

        }

        private void fOCBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrderCreation_Load(object sender, EventArgs e)
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBHabigisu.accdb;";
            dataload();
        }

        private void dataload()   //カスタム関数
        {
            // ID、Pass（パスワード）、Name(名前）
            // PostNumber（郵便番号）、Address（住所）  Memberテーブルから
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT ID,Pass AS パスワード,Name AS 名前, " +
                "PostNumber AS 郵便番号,Address AS 住所 FROM MEMBER ORDER BY ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            dataGridView1.AutoResizeColumns();           //列の幅の自動調整
        }
    }
}
