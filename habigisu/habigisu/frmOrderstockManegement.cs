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
        private object habigisu;
        private object fOSManegement;

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
            Hide();
            //fOSManegement.();
        }

        private void fOSSearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void fOSUpdateBtn_Click(object sender, EventArgs e)
        {

            int selectrow = fOSDataGridView1.CurrentCell.RowIndex;         //選択されている行番号
            OleDbCommand cmd =
                new OleDbCommand("UPDATE Member SET Name = @name, PosID = @posid, TeamID = @teamid, " +
                "Birthday = @birthday, Height = @height, Weight = @weight, BloodType = @bloodtype, " +
                "ImageFile = @imgfile WHERE ID = @id", cn);
            cmd.Parameters.AddWithValue("@name",
               fOSDataGridView1.Rows[selectrow].Cells["Name"].Value.ToString());
            cmd.Parameters.AddWithValue("@posid",
                fOSDataGridView1.Rows[selectrow].Cells["PosID"].Value.ToString());
            cmd.Parameters.AddWithValue("@teamid",
                fOSDataGridView1.Rows[selectrow].Cells["TeamID"].Value.ToString());
            cmd.Parameters.AddWithValue("@birthday",
                fOSDataGridView1.Rows[selectrow].Cells["Birthday"].Value.ToString());
            cmd.Parameters.AddWithValue("@height",
                fOSDataGridView1.Rows[selectrow].Cells["Height"].Value);
            cmd.Parameters.AddWithValue("@weight",
                fOSDataGridView1.Rows[selectrow].Cells["Weight"].Value);
            cmd.Parameters.AddWithValue("@bloodtype",
                fOSDataGridView1.Rows[selectrow].Cells["BloodType"].Value.ToString());
            cmd.Parameters.AddWithValue("@imgfile",
                fOSDataGridView1.Rows[selectrow].Cells["ImageFile"].Value.ToString());
            cmd.Parameters.AddWithValue("@id",
                fOSDataGridView1.Rows[selectrow].Cells["ID"].Value.ToString());
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WinDB03");
                cn.Close();
                return;
            }
            MessageBox.Show("更新しました", "WinDB03");
            dataload();
            imgdisp();
        }

        private void imgdisp()
        {
            throw new NotImplementedException();
        }

        private void fOSFormBtn_Click(object sender, EventArgs e)
        {
            frmOrderstockManegement form2 = new
            frmOrderstockManegement();
            form2.ShowDialog();
        }

        private void fOSConfirmBtn_Click(object sender, EventArgs e)
        {
            frmOrderstockManegement form2 = new
            frmOrderstockManegement();
            form2.ShowDialog();
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

        private void fOSDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fOSSearchBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

       
    }
}
    