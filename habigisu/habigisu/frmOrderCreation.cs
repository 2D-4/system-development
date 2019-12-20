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

    public partial class frmOrderCreation : Form
    {
        OleDbConnection cn = new OleDbConnection();
        public frmOrderCreation()
        {
            InitializeComponent();
        }
        private void dataload()
        {
            cn.ConnectionString =
                @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = |DataDirectory|\DBJapan.accdb;";
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Member2 ORDER BY ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fOCDataGridView.DataSource = dt;
        }

        private void fOCSaveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("内容を保存してもよろしいですか？", "確認画面",
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
        
        private void frmOrderCreation_Load(object sender, EventArgs e)
        {

         cn.ConnectionString =
         @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = |DataDirectory|\DBJapan.accdb;";
         OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Member2 ORDER BY ID", cn);
         DataTable dt = new DataTable();
         da.Fill(dt);
         fOCDataGridView.DataSource = dt;

        }

        private void fOCBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fOCDeleteBtn_Click(object sender, EventArgs e)
        {
            int selectrow = fOCDataGridView.CurrentCell.RowIndex;                 //選択されている行番号
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Member2 WHERE ID = @id", cn);
            cmd.Parameters.AddWithValue("@id", fOCDataGridView.Rows[selectrow].Cells["ID"].Value);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
                return;
            }
            MessageBox.Show("削除しました");
            dataload();
        }
    }
}
