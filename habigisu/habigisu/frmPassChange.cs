using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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




        private int Collation(string str)                       //文字がパターンに一致するか判定する
        {
            if (str.Length == 0)
            {
                return 1;           //文字が入力されていない
            }

            Match matche = Regex.Match(str, "[^a-zA-Z0-9]");　　　　         //入力された文字が半角英数字かチェック

            if (matche.Value != "")
            {
                return 1;            //問題あり(日本語入力や記号が含まれている)
            }
            else
            {
                return 0;            //問題なし
            }

        }



        private int LengthCheck(string str)                                  //入力された文字が8文字以上16文字以内かチェック
        {
            if ((str.Length < 8) && (str.Length > 16))       //文字数の確認
            {
                Warning2.Text = "文字数ーーーーー！";          　　　　　　　　　　　　 //　2019/12/13(金)にやる！（通っていない）

                return 1;   //足りない
            }

            else
            {
                return 0;  //問題なし
            }

        }



        private int CapitalLetterCheck(string str)                           //入力された文字に大文字が含まれているかチェック
        {
            Match matche = Regex.Match(str, "[^A-Z]");

            if (matche.Value == "")
            {
                Warning.Text = "※大文字、小文字、数字各1つ以上入力して下さい。";

                return 1;            //問題あり(大文字が含まれていない)
            }
            else
            {
                Warning.Text = " ";

                return 0;            //問題なし
            }

        }



        private int SmallLetterCheck(string str)                             //入力された文字に小文字が含まれているかチェック
        {
            Match matche = Regex.Match(str, "[^a-z]");

            if (matche.Value == "")
            {
                Warning.Text = "※大文字、小文字、数字各1つ以上入力して下さい。";

                return 1;            //問題あり(小文字が含まれていない)
            }
            else
            {
                Warning.Text = " ";

                return 0;            //問題なし
            }

        }



        private int NumberCheck(string str)                                  //入力された文字に数字が含まれているかチェック
        {
            Match matche = Regex.Match(str, "[^0-9]");

            if (matche.Value == "")
            {
                Warning.Text = "※大文字、小文字、数字各1つ以上入力して下さい。";

                return 1;            //問題あり(数字が含まれていない)
            }
            else
            {
                Warning.Text = " ";

                return 0;            //問題なし
            }

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

        

        //各テキストボックスの入力制限(半角英数字のみ)



        private void fPCIdTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<'0'||'9'<e.KeyChar)&&(e.KeyChar<'A'||'Z'<e.KeyChar)&&(e.KeyChar<'a'||'z'<e.KeyChar)&&e.KeyChar!='\b')  //社員IDの入力制限
            {
                e.Handled = true;
            }
        }

        private void fPCTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<'0'||'9'<e.KeyChar)&&(e.KeyChar<'A'||'Z'<e.KeyChar)&&(e.KeyChar<'a'||'z'<e.KeyChar)&&e.KeyChar!='\b')  //(現在使用の)パスワードの入力制限
            {
                e.Handled = true;
            }
        }

        private void fPCNPTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<'0'||'9'<e.KeyChar)&&(e.KeyChar<'A'||'Z'<e.KeyChar)&&(e.KeyChar<'a'||'z'<e.KeyChar)&&e.KeyChar!='\b')  //新しいパスワードの入力制限
            {
                e.Handled = true;
            }
        }

        private void fPCRNPTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<'0'||'9'<e.KeyChar)&&(e.KeyChar<'A'||'Z'<e.KeyChar)&&(e.KeyChar<'a'||'z'<e.KeyChar)&&e.KeyChar!='\b')  //新しいパスワード(再入力)の入力制限
            {
                e.Handled = true;
            }
        }



        //変更ボタンを押した際



        private void fPCChangeBtn_Click(object sender, EventArgs e)
        {
           
            //問題がない場合０を返却し、問題がある場合１を返却する


            int result=Collation(fPCNPTBox.Text);   //半角英数字かどうか判定する

            if(result==0)
            {
                result = LengthCheck(fPCNPTBox.Text);  //8文字以上  16文字以内かチェック
            }


            if (result == 0)
            {
                result = CapitalLetterCheck(fPCNPTBox.Text); //大文字が含まれているかチェック
            }


            if (result == 0)
            {
                result = SmallLetterCheck(fPCNPTBox.Text);  //小文字が含まれているかチェック
            }


            if (result == 0)
            {
                result = NumberCheck(fPCNPTBox.Text);  //数字が含まれているかチェック
            }
            


            switch (result)
            {

                case 0:　　　　//半角英数字、尚且つPassCheckが通った場合
                    {
                        if (fPCNPTBox.Text== fPCRNPTBox.Text)
                        {
                            //データベースで新しいパスワードを更新するコードを書く

                            MessageBox.Show("パスワードを変更しました。", "入力成功");

                        }

                        else   //再入力されたパスワードと一致しない
                        {
                            MessageBox.Show("新しいパスワードが一致しません。", "入力失敗");
                        }
                    };
                    break;



                case 1:        //半角英数字以外が混ざっている場合
                    {
                         MessageBox.Show("ID、パスワードを確認してください。", "入力失敗");
                    };

                    break;

            }

            
        }

       
    }
}
