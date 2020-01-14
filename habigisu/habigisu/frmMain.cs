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
        public AuthoritySelector au = new AuthoritySelector();
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
            au.CheckDeptAuthority(0, eid);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {

        }

        private void btnPassChange_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
