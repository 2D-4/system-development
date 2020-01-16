using habigisu;
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
    public partial class frmMain : Form
    {
        string eid = "9";
        AuthoritySelector au = new AuthoritySelector();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnOderStock_Click(object sender, EventArgs e)
        {

        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            int aflag = au.CheckDeptAuthority(0, eid);
            Console.WriteLine(aflag);
            if(aflag == 0)
            {
                MessageBox.Show("出庫管理に行くお");
            }
            else
            {
                MessageBox.Show("権限ないよ");
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            int aflag = au.CheckDeptAuthority(1, eid);
            Console.WriteLine(aflag);
            if (aflag == 0)
            {
                MessageBox.Show("売上管理に行くお");
            }
            else
            {
                MessageBox.Show("権限ないよ");
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            int aflag = au.CheckDeptAuthority(2, eid);
            Console.WriteLine(aflag);
            if (aflag == 0)
            {
                MessageBox.Show("顧客管理に行くお");
            }
            else
            {
                MessageBox.Show("権限ないよ");
            }
        }

        private void btnPassChange_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
