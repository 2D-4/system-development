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
    public partial class frmShippingManagement : Form
    {
        OleDbConnection cn = new OleDbConnection(); //グローバル変数　コネクションオブジェクト
        public frmShippingManagement()
        {
            InitializeComponent();

            //社員IDを表示する
            FSMIDlbl.Text = ;

            

        }

        private void dataload()   //カスタム関数
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Habigisu.accdb;";
        }

        private void FSMSlistBtn_Click(object sender, EventArgs e)
        {
            //出庫一覧
            dataload();
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT ID,Pass AS 出庫ID,Name AS 出庫日, " +
                "PostNumber AS 社員ID,Address AS 注文ID FROM MEMBER ORDER BY ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            FSMDatagridview.DataSource = dt;
            FSMDatagridview.AllowUserToAddRows = false;    //最下行を非表示
            FSMDatagridview.AutoResizeColumns();           //列の幅の自動調整
        }

        private void FSMNotSlistBtn_Click(object sender, EventArgs e)
        {
            // 未出庫一覧
            dataload();
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT ID,Pass AS 出庫ID,Name AS 出庫日, " +
                "PostNumber AS 社員ID,Address AS 注文ID FROM MEMBER ORDER BY ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            FSMDatagridview.DataSource = dt;
            FSMDatagridview.AllowUserToAddRows = false;    //最下行を非表示
            FSMDatagridview.AutoResizeColumns();           //列の幅の自動調整
        }

        private void FSMSearchBtn_Click(object sender, EventArgs e)
        {
            //strFilter　検索
        }

        private void FSMBackBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //閉じる
        }

        private void frmShippingManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
