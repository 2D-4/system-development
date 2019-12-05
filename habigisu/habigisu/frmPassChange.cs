using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace habigisu
{
    public partial class frmPassChange : Form
    {
        //OleDbConnection cn = new OleDbConnection(); //グローバル変数　コネクションオブジェクト



        public frmPassChange()
        {
            InitializeComponent();
        }

        //各テキストボックスにフォーカスを当てる


        private void frmPassChange_Shown(object sender, EventArgs e)
        {
            fPCIdTBox.Focus();  //画面を開いた際に、社員IDのテキストボックスにフォーカスを当てる
        }

        private void fPCIdTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fPCTBox.Focus();  //エンターキーを押すと、(現在使用の)パスワードのテキストボックスにフォーカスを当てる
            }
        }

        private void fPCTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fPCNPTBox.Focus(); 　//きんようびにかく！！！
            }
        }

        private void fPCNPTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fPCRNPTBox.Focus();   //
            }
        }

        private void fPCRNPTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fPCChangeBtn.Focus();   //
            }
        }
    }
}
