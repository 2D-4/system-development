﻿using System;
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
    public partial class frmShippingManagement : Form
    {
        public frmShippingManagement()
        {
            InitializeComponent();

            //社員IDを表示する
            FSMIDlbl.Text = ;

            

        }

        private void FSMSlistBtn_Click(object sender, EventArgs e)
        {
        // ("SELECT *　from  テーブル名Issue ") 出庫一覧
        }

        private void FSMNotSlistBtn_Click(object sender, EventArgs e)
        {
            //未出庫一覧
        }

        private void FSMSearchBtn_Click(object sender, EventArgs e)
        {
            //検索
        }

        private void FSMBackBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //閉じる
        }
    }
}
