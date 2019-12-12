﻿using System;
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
    OleDbConnection cn = new OleDbConnection(); //グローバル変数　コネクションオブジェクト
    public partial class frmOrderManagement : Form
    {

        public frmOrderManagement()
        {
            InitializeComponent();
        }

        private void dataload()   //カスタム関数
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Habigisu.accdb;";
            dataload();
        }

        private void fOMBtn1_Click(object sender, EventArgs e)
        {
            dataload();
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT * FROM  注文テーブル", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fOMDataGridView.DataSource = dt;
            fOMDataGridView.AllowUserToAddRows = false;    //最下行を非表示
            fOMDataGridView.AutoResizeColumns();           //列の幅の自動調整
        }

        private void fOMBtn2_Click(object sender, EventArgs e)
        {
            dataload();
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT * FROM  未出庫テーブル);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fOMDataGridView.DataSource = dt;
            fOMDataGridView.AllowUserToAddRows = false;    //最下行を非表示
            fOMDataGridView.AutoResizeColumns();           //列の幅の自動調整
        }

        private void fOMSearchBtn_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT " +
               " " +
               "WHERE 日にち BETWEEN @dtime1 AND @dtime2 ORDER BY ID");  //Birthdayが指定した間にある
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            //日時を設定しているコントロールを設定
            cmd.Parameters.AddWithValue("@dtime1", DateTime.Parse(dateTimePicker1.Value.ToString()));
            cmd.Parameters.AddWithValue("@dtime2", DateTime.Parse(dateTimePicker2.Value.ToString()));

            DataTable dt = new DataTable();
            da.Fill(dt);
            fOMDataGridView.DataSource = dt;
            fOMDataGridView.AllowUserToAddRows = false;   //最下行を非表示
            fOMDataGridView.AutoResizeColumns();          //列の幅の自動調整
        }

        private void fOMUpdateBtn_Click(object sender, EventArgs e)
        {
            int selectrow = fOMDataGridView.CurrentCell.RowIndex;         //選択されている行番号
            OleDbCommand cmd =
                new OleDbCommand("UPDATE Member SET Name = @name, PosID = @posid, TeamID = @teamid, " +
                "Birthday = @birthday, Height = @height, Weight = @weight, BloodType = @bloodtype, " +
                "ImageFile = @imgfile WHERE ID = @id", cn);
            cmd.Parameters.AddWithValue("@name",
                fOMDataGridView.Rows[selectrow].Cells["Name"].Value.ToString());
            cmd.Parameters.AddWithValue("@posid",
                fOMDataGridView.Rows[selectrow].Cells["PosID"].Value.ToString());
            cmd.Parameters.AddWithValue("@teamid",
                fOMDataGridView.Rows[selectrow].Cells["TeamID"].Value.ToString());
            cmd.Parameters.AddWithValue("@birthday",
                fOMDataGridView.Rows[selectrow].Cells["Birthday"].Value.ToString());
            cmd.Parameters.AddWithValue("@height",
                fOMDataGridView.Rows[selectrow].Cells["Height"].Value);
            cmd.Parameters.AddWithValue("@weight",
                fOMDataGridView.Rows[selectrow].Cells["Weight"].Value);
            cmd.Parameters.AddWithValue("@bloodtype",
                fOMDataGridView.Rows[selectrow].Cells["BloodType"].Value.ToString());
            cmd.Parameters.AddWithValue("@imgfile",
                fOMDataGridView.Rows[selectrow].Cells["ImageFile"].Value.ToString());
            cmd.Parameters.AddWithValue("@id",
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
            MessageBox.Show("更新しました");
            dataload();
            imgdisp();
        }

        private void fOMMakeBtn_Click(object sender, EventArgs e)
        {
            Form2 frmOrderCreation = new frmOrderCreation();
            Form2.Show();
        }

        private void fOMConfirmBtn_Click(object sender, EventArgs e)
        {

        }

        private void fOMBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fOMStatusTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fOMOrderIdTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fOMProductTbox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

