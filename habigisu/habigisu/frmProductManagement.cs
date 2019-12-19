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
    public partial class frmProductManagement : Form
    {
        public frmProductManagement()
        {
            InitializeComponent();

        }


        private void frmProductManagement_Shown(object sender, EventArgs e)
        {
            FPMPidTbox.Focus(); //商品IDにフォーカスを当てる
        }



        private void FPMPidTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Enterキーであれば
            {
                FPMProTbox.Focus(); //商品IDを入力すると商品名にフォーカスを当てる
            }
        }

        private void FPMProTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Enterキーであれば
            {
                FPMGenreCBox.Focus(); //商品名を入力するとジャンルにフォーカスを当てる
            }
        }

        private void FPMGenreCBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Enterキーであれば
            {
                FPMAutTbox.Focus(); //ジャンルを入力すると著者名にフォーカスを当てる
            }
        }

        private void FPMAutTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Enterキーであれば
            {
                FPMPubTbox.Focus(); //著者名を入力すると出版社にフォーカスを当てる
            }
        }

    
    }
}
