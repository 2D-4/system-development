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
    public partial class frmSignin : Form
    {
        OleDbConnection cn = new OleDbConnection(); //グローバル変数　コネクションオブジェクト

        public frmSignin()
        {
            InitializeComponent();
        }
        
        //public static frmSignin frmSigninInstance
        //{
        //    get
        //    {
        //        return frmSigninInstance;
        //    }
        //    set
        //    {
        //        frmSigninInstance = value;
        //    }
        //}

        public string fSIdTBoxText
        {
            get
            {
                return fSIdTBox.Text;
            }
            set
            {
                fSIdTBox.Text = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //frmSignin.frmSigninInstance = this;

            fSIdTBox.ImeMode = ImeMode.Disable; //IMEを無効にして半角の文字だけ入力できるようにする
            fSPassTBox.ImeMode = ImeMode.Disable; //IMEを無効にして半角の文字だけ入力できるようにする

            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\habigisu.accdb;";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            fSIdTBox.Focus(); //画面を開いた際に、ID入力フォームにフォーカスを当てる
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("終了しますか？", "終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true; //画面を閉じようとすると確認ポップ画面を出す
            }
        }

        private void textBID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Enterキーであれば
            {
                fSPassTBox.Focus(); //パスワードを入力するとTextBoxにフォーカスを当てる
            }
        }

        private void textBPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Enterキーであれば
            {
                fSSigninBtn.Focus(); //ログイン1ボタンにフォーカスを当てる
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            OleDbDataAdapter da = new OleDbDataAdapter(); //データアダプタオブジェクト
            OleDbCommand cmd = new OleDbCommand();        //コマンドオブジェクト
            string sid = fSIdTBox.Text;
            string spass = fSPassTBox.Text;
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM 社員PASSテーブル WHERE 社員ID = @id AND パスワード = @pass";
            da.SelectCommand = cmd;
            cmd.Parameters.AddWithValue("@id", sid);         //IDのパラメータ
            cmd.Parameters.AddWithValue("@pass", spass);     //Passのパラメータ
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)    //データテーブルの行数
            {
                //this.Hide();
                //habigisu.frmMain fmM = new habigisu.frmMain();
                //fmM.Show();
                this.Hide();//仮置きコード（いずれ消す）
                habigisu.frmOrderStockCreation fmO = new habigisu.frmOrderStockCreation();
                fmO.Show();
            }
            else
            {
                MessageBox.Show("ID、パスワードを確認してください。", "WinSystem02");
                fSIdTBox.Focus();
            }
=======
            this.Hide();
            habigisu.frmOrderstockManegement fmOM = new habigisu.frmOrderstockManegement();
            fmOM.Show();//仮置きコード（後で消す）
>>>>>>> 7ad2297fb927db58cab2a1197c7c46bc4817985c
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            Close(); //フォームを閉じようとする(確認ポップ画面が出る)
        }

        
    }
}
