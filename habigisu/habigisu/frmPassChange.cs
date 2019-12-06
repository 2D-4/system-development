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


        //各TextBoxでEnterキーを押すことによって、次の入力画面にフォーカスを当てる



        private void frmPassChange_Shown(object sender, EventArgs e)
        {
            fPCIdTBox.Focus();  //画面を開いた際に、社員IDのTextBoxにフォーカスを当てる
        }

        private void fPCIdTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  //Enterキーを押すと発生
            {
                fPCTBox.Focus();  //Enterキーを押すと、(現在使用の)パスワードのTextBoxにフォーカスを当てる
            }
        }

        private void fPCTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  //Enterキーを押すと発生
            {
                fPCNPTBox.Focus(); 　//Enterキーを押すと、新しいパスワードのTextBoxにフォーカスを当てる
            }
        }

        private void fPCNPTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  //Enterキーを押すと発生
            {
                fPCRNPTBox.Focus();   //Enterキーを押すと、新しいパスワード(再入力)のTextBoxにフォーカスを当てる
            }
        }

        private void fPCRNPTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  //Enterキーを押すと発生
            {
                fPCChangeBtn.Focus();   //Enterキーを押すと、変更するボタンにフォーカスを当てる
            }
        }

        private void fPCChangeBtn_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void fPCIdTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<'0'||'9'<e.KeyChar)&&(e.KeyChar<'A'||'Z'<e.KeyChar)&&(e.KeyChar<'a'||'z'<e.KeyChar)&&e.KeyChar!='\b')
            {
                e.Handled = true;
            }
        }
    }
}
