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
    public partial class frmOrderstockManegement : Form
    {
        OleDbConnection cn = new OleDbConnection(); //グローバル変数　コネクションオブジェクト
        public frmOrderstockManegement()
        {
            InitializeComponent();
        }

        private void dataload()
        {
            cn.ConnectionString =
               @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\habigisu.accdb;";
            
        }

        private void fOSBtn1_Click(object sender, EventArgs e)
        {
            dataload();
            
            OleDbDataAdapter da =
               new OleDbDataAdapter("SELECT * FROM 発注テーブル WHERE 入庫チェック = '出庫済' ORDER BY 発注ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fOSDataGridView1.DataSource = dt;
            fOSDataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            fOSDataGridView1.AutoResizeColumns();           //列の幅の自動調整
        }

        private void fOSBtn2_Click(object sender, EventArgs e)
        {
            dataload();

            OleDbDataAdapter da =
               new OleDbDataAdapter("SELECT * FROM 発注テーブル WHERE 入庫チェック = '未出庫' ORDER BY 発注ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fOSDataGridView1.DataSource = dt;
            fOSDataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            fOSDataGridView1.AutoResizeColumns();           //列の幅の自動調整
        }

        private void fOSidlabel_Click(object sender, EventArgs e)
        {

        }

        private void fOSnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void fOSNlabel_Click(object sender, EventArgs e)
        {

        }

        private void fOSNamberTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fOSMerchandiselabel_Click(object sender, EventArgs e)
        {

        }

        private void fOSMerchandisTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fOSOrdernamebrandlabel_Click(object sender, EventArgs e)
        {

        }

        private void fOSOrdernamebrandTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fOSOrderidlabel_Click(object sender, EventArgs e)
        {

        }

        private void fOSOrderidTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fOSDaylabel_Click(object sender, EventArgs e)
        {

        }

        private void fOSBackBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmMain.Show();
        }

        private void fOSSearchBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void fOSUpdateBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void fOSFormBtn_Click(object sender, EventArgs e)
        {
             void ChangeButton_Click(object  EventArgs )
            {
               //this. Hide();
               // fOSFormBtn.Show();
            }
        }

        private void fOSConfirmBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void fOSdtPicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmOrderstockManegement_Load(object sender, EventArgs e)
        {

        }

        private void fOSdtPicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}