using System;
using System.Data.OleDb;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            fSIdTBox.ImeMode = ImeMode.Disable;
            fSPassTBox.ImeMode = ImeMode.Disable;
            frmSigninInstance = this;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            fSIdTBox.Focus(); //画面を開いた際に、ID入力フォームにフォーカスを当てる
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("終了しますか？", "終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
            SaltSelector ss = new SaltSelector();
            PasswordHash ph = new PasswordHash();

            string eid = fSIdTBox.Text;
            string pwd = fSPassTBox.Text;
            string salt = ss.getSalt(eid);
            if (salt == "\0")
            {
                MessageBox.Show("社員番号、もしくはパスワードが間違っているか、存在しません。");
                return;
            }
            else if (salt == "error")
            {
                MessageBox.Show("プログラム作成者にご連絡ください。");
                return;
            }
            else
            {
                    frmMain fm = new frmMain();
                    Hide();
                    fm.Show();
            }
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            Close(); //フォームを閉じようとする(確認ポップ画面が出る)
        }

        private static frmSignin _frmSigninInstance;            //frmSigninのオブジェクトを保持する

        public static frmSignin frmSigninInstance
        {
            get
            {
                return _frmSigninInstance;
            }
            set
            {
                _frmSigninInstance = value;
            }
        }

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
    }
}
