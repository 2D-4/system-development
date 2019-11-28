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

namespace login
{
    public partial class frmSignin : Form
    {
        OleDbConnection cn = new OleDbConnection(); //グローバル変数　コネクションオブジェクト
        public frmSignin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fSIdTBox.ImeMode = ImeMode.Disable; //IMEを無効にして半角の文字だけ入力できるようにする
            fSPassTBox.ImeMode = ImeMode.Disable; //IMEを無効にして半角の文字だけ入力できるようにする
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
            OleDbDataAdapter da = new OleDbDataAdapter(); //データアダプタオブジェクト
            OleDbCommand cmd = new OleDbCommand();        //コマンドオブジェクト
            string sid = fSIdTBox.Text;
            string spass = fSPassTBox.Text;
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Member WHERE ID=@id AND Pass=@pass";
            da.SelectCommand = cmd;
            cmd.Parameters.AddWithValue("@id", sid);         //IDのパラメータ
            cmd.Parameters.AddWithValue("@pass", spass);     //Passのパラメータ
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)    //データテーブルの行数
            {
                this.Hide();
                frmMain fmM = new frmMain();
                fmM.Show();
            }
            else
            {
                MessageBox.Show("ID、パスワードを確認してください。", "WinSystem02");
                fSIdTBox.Focus();
            }
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            Close(); //フォームを閉じようとする(確認ポップ画面が出る)
        }

        
    }
}
