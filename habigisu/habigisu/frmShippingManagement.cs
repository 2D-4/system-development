using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace habigisu
{

    public partial class frmShippingManagement : Form
    {

        public frmShippingManagement()
        {
            InitializeComponent();


            //社員IDを表示する
            FSMIDlbl.Text = "課長";



            

        }

        private void frmShippingManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void FSMSlistBtn_Click(object sender, EventArgs e)
        {
            // ("SELECT *　from  テーブル名Issue ") 出庫一覧

            DataTable dt = new DataTable();
            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
            builder.Provider = "Microsoft.ACE.OLEDB.12.0";
            builder.DataSource = "C:/Users/b8433/Documents/github/system-development/doc/DB/Habigisu.accdb";
            using (OleDbConnection conn = new OleDbConnection(builder.ConnectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT 出庫ID,出庫日,注文ID FROM 出庫テーブル", conn))
                {
                    OleDbDataAdapter odda = new OleDbDataAdapter();
                    odda.SelectCommand = cmd;
                    odda.Fill(dt);
                    FSMDatagridview.DataSource = dt;
                }
            }
        }

        private void FSMNotSlistBtn_Click(object sender, EventArgs e)
        {
            //未出庫一覧
        }

        private void FSMSearchBtn_Click(object sender, EventArgs e)
        {
            var orderId = FSMOrderIDTbox.Text;
            var issueId = FSMSIDTbox.Text;
            var empId = FSMEmpIDTbox.Text;

            DataTable dt = new DataTable();
            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
            builder.Provider = "Microsoft.ACE.OLEDB.12.0";
            builder.DataSource = "C:/Users/b8433/Documents/github/system-development/doc/DB/Habigisu.accdb";
            using (OleDbConnection conn = new OleDbConnection(builder.ConnectionString)) {
                using (OleDbCommand cmd = new OleDbCommand("SELECT " + orderId + "," + issueId + "," + empId + " " + "FROM 出庫テーブル", conn)){
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
