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
            FSMIDlbl.Text = "課長";
        }

        private void dataload()   //カスタム関数
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Habigisu.accdb;";
        }
        private void frmShippingManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void FSMSlistBtn_Click(object sender, EventArgs e)
        {
            //出庫一覧
            dataload();
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT 出庫ID,出庫日, " +
                "社員ID,注文ID FROM 出庫テーブル", cn);
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
                new OleDbDataAdapter("SELECT 出庫ID,出庫日, " +
                "社員ID,注文ID FROM 出庫テーブル　WHERE 出庫日 is NULL", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            FSMDatagridview.DataSource = dt;
            FSMDatagridview.AllowUserToAddRows = false;    //最下行を非表示
            FSMDatagridview.AutoResizeColumns();           //列の幅の自動調整

        }

        private void FSMSearchBtn_Click(object sender, EventArgs e)
        {
            //　検索
            var orderId = FSMOrderIDTbox.Text;
            var issueId = FSMSIDTbox.Text;
            var empId = FSMEmpIDTbox.Text;

            DataTable dt = new DataTable();
            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
            builder.Provider = "Microsoft.ACE.OLEDB.12.0";
            builder.DataSource = "C:/Users/b8433/Documents/github/system-development/doc/DB/Habigisu.accdb";
            using (OleDbConnection conn = new OleDbConnection(builder.ConnectionString)) {
                using (OleDbCommand cmd = new OleDbCommand("SELECT " + orderId + "," + issueId + "," + empId + " " + "FROM 出庫テーブル  " +
                    "WHERE orderId like '% FSMOrderIDTbox.Text' and issueId like '%FSMSIDTbox.Text%' and empId like '%FSMEmpIDTbox.Text%'  ", conn)){
                    OleDbDataAdapter odda = new OleDbDataAdapter();
                    odda.SelectCommand = cmd;
                    odda.Fill(dt);
                    FSMDatagridview.DataSource = dt;
                }
            }

        }

        private void FSMBackBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //閉じる
        }
    }
}
