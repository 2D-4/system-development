using System;
using System.Windows.Forms;

namespace habigisu
{
    public partial class frmMain : Form
    {
        string eid = frmSignin.frmSigninInstance.fSIdTBoxText;
        AuthoritySelector au = new AuthoritySelector();
        public frmMain()
        {
            InitializeComponent();
            lblfMAssigneid.Text += eid;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("商品管理に行く");           
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("注文管理に行く");
        }

        private void btnOderStock_Click(object sender, EventArgs e)
        {
            frmOrderstockManegement fo = new frmOrderstockManegement();
            fo.ShowDialog();
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            int d_flag = au.CheckDeptAuthority(0, eid);
            int p_flag = au.CheckPosAuthority(0, eid);

            if(d_flag == 0 || p_flag == 0)
            {
                MessageBox.Show("出庫管理に行く");
            }
            else
            {
                MessageBox.Show("権限ないよ");
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            int d_flag = au.CheckDeptAuthority(1, eid);
            int p_flag = au.CheckPosAuthority(1, eid);

            if (d_flag == 0 || p_flag == 0)
            {
                MessageBox.Show("売上管理に行く");
            }
            else
            {
                MessageBox.Show("権限ないよ");
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            int d_flag = au.CheckDeptAuthority(2, eid);
            int p_flag = au.CheckPosAuthority(2, eid);

            if (d_flag == 0 || p_flag == 0)
            {
                MessageBox.Show("顧客管理に行く");
            }
            else
            {
                MessageBox.Show("権限ないよ");
            }
        }

        private void btnPassChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("パスワード変更します");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmSignin fs = new frmSignin();
            Close();
            fs.Show();
        }
    }
}
