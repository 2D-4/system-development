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
    public partial class frmOrderManagement : Form
    {
        OleDbConnection cn = new OleDbConnection();

        public frmOrderManagement()
        {
            InitializeComponent();
        }

        private void dataload()   //カスタム関数
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Habigisu.accdb";
            OleDbDataAdapter da = new OleDbDataAdapter();
            
        }




        private void fOMBtn1_Click(object sender, EventArgs e)
        {
            cn.ConnectionString =
          @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = |DataDirectory|\Habigisu.accdb;";
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM 注文テーブル", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fOMDataGridView.DataSource = dt;
        }




        private void fOMBtn2_Click(object sender, EventArgs e)
        {  
            cn.ConnectionString =
            @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = |DataDirectory|\Habigisu.accdb;";
               OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM 注文テーブル WHERE 出庫チェック LIKE '未出庫'", cn);
               DataTable dt = new DataTable();
               da.Fill(dt);
               fOMDataGridView.DataSource = dt;
        }






        private void fOMSearchBtn_Click(object sender, EventArgs e)
        {
            string[] array = new string[2];
            array[0] = fOMOrderIdTbox.Text;
            array[1] = fOMCustomerTbox.Text;
            //array[2] = fOMProductTbox.Text;
            // SELECT * FROM 商品マスタ WHERE Client Like '落' AND 
            int count = 0;
            string sql = "SELECT * FROM 注文テーブル";

            for (int i = 0; i < 2; i++)
            {
                if (array[i] != "")
                {
                    if (count == 0)
                    {
                        sql += " WHERE ";
                        switch (i)
                        {
                            case 0:
                                sql += "注文ID LIKE '" + array[i] + "' ";
                                break;
                            case 1:
                                sql += "顧客ID LIKE '" + array[i] + "' ";
                                break;
                           /* case 2:
                                sql += " Like '" + array[i] + "' ";
                                break;*/
                        }
                        sql += array[i];
                        count++;
                    }
                    else
                    {
                        sql += " AND ";
                        switch (i)
                        {
                            case 0:
                                sql += "注文ID LIKE '" + array[i] + "' ";
                                break;
                            case 1:
                                sql += "顧客ID LIKE '" + array[i] + "' ";
                                break;
                           /* case 2:
                                sql += " Like '" + array[i] + "' ";
                                break;*/
                        }
                        sql += array[i];
                    }
                }
            }
        }







            private void fOMUpdateBtn_Click(object sender, EventArgs e)
            {
            int selectrow = fOMDataGridView.CurrentCell.RowIndex;         //選択されている行番号
            OleDbCommand cmd =
                new OleDbCommand("UPDATE 注文テーブル SET 顧客ID = @CustomerID, 注文年月日 = @OrderDate, 社員ID = @MemberID, 出庫日 = @SyukkoDate, 出庫チェック = @SyukkoCheck WHERE 顧客ID = @CustomerID", cn); 
            cmd.Parameters.AddWithValue("@CustomerID",
                fOMDataGridView.Rows[selectrow].Cells["顧客ID"].Value.ToString());
            cmd.Parameters.AddWithValue("@OrderDate",
                fOMDataGridView.Rows[selectrow].Cells["注文年月日"].Value.ToString());
            cmd.Parameters.AddWithValue("@MemberID",
                fOMDataGridView.Rows[selectrow].Cells["社員ID"].Value.ToString());
            cmd.Parameters.AddWithValue("@SyukkoDate",
                fOMDataGridView.Rows[selectrow].Cells["出庫日"].Value.ToString());
            cmd.Parameters.AddWithValue("@SyukkoCheck",
                fOMDataGridView.Rows[selectrow].Cells["出庫チェック"].Value.ToString());
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
            MessageBox.Show("更新しました");
            dataload();
        }





        private void fOMMakeBtn_Click(object sender, EventArgs e)
            {
                frmOrderCreation form2 = new frmOrderCreation();
                form2.ShowDialog();
            }

        private void fOMConfirmBtn_Click(object sender, EventArgs e)
        {
            int selectrow = fOMDataGridView.CurrentCell.RowIndex;                //選択されている行番号
            OleDbCommand cmd =
                new OleDbCommand("INSERT INTO 注文詳細 ID VALUES @ProductId", cn);

            cmd.Parameters.AddWithValue("@ProductId",
                fOMDataGridView.Rows[selectrow].Cells["ID"].Value.ToString());
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
            MessageBox.Show("追加しました");
            dataload();
        }




        private void fOMBackBtn_Click(object sender, EventArgs e)
        {
         this.Close();
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {           
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else 
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void ProductS_Click(object sender, EventArgs e)
        {
            cn.ConnectionString =
            @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = |DataDirectory|\Habigisu.accdb;";
            OleDbDataAdapter da = new OleDbDataAdapter
                ("SELECT * FROM 商品マスタ WHERE 商品ID LIKE '%" + this.fOMProductTbox + "%'", cn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            fOMDataGridView.DataSource = dt;
        }
    }
}

