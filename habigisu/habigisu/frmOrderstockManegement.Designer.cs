namespace habigisu
{
    partial class frmOrderstockManegement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fOSBtn1 = new System.Windows.Forms.Button();
            this.fOSBtn2 = new System.Windows.Forms.Button();
            this.fOSSearchBtn = new System.Windows.Forms.Button();
            this.fOSUpdateBtn = new System.Windows.Forms.Button();
            this.fOSFormBtn = new System.Windows.Forms.Button();
            this.fOSConfirmBtn = new System.Windows.Forms.Button();
            this.fOSBackBtn = new System.Windows.Forms.Button();
            this.fOSidlabel = new System.Windows.Forms.Label();
            this.fOSnamelabel = new System.Windows.Forms.Label();
            this.fOSNlabel = new System.Windows.Forms.Label();
            this.fOSMerchandiselabel = new System.Windows.Forms.Label();
            this.fOSOrdernamebrandlabel = new System.Windows.Forms.Label();
            this.fOSOrderidlabel = new System.Windows.Forms.Label();
            this.fOSDaylabel = new System.Windows.Forms.Label();
            this.fOSNamberTBox = new System.Windows.Forms.TextBox();
            this.fOSMerchandiseTBox = new System.Windows.Forms.TextBox();
            this.fOSOrdernamebrandTBox = new System.Windows.Forms.TextBox();
            this.fOSOrderidTBox = new System.Windows.Forms.TextBox();
            this.fOSDataGridView1 = new System.Windows.Forms.DataGridView();
            this.fOSdtPicker1 = new System.Windows.Forms.DateTimePicker();
            this.fOSdtPicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.fOSDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fOSBtn1
            // 
            this.fOSBtn1.Location = new System.Drawing.Point(17, 12);
            this.fOSBtn1.Name = "fOSBtn1";
            this.fOSBtn1.Size = new System.Drawing.Size(101, 46);
            this.fOSBtn1.TabIndex = 0;
            this.fOSBtn1.Text = "入庫一覧";
            this.fOSBtn1.UseVisualStyleBackColor = true;
            this.fOSBtn1.Click += new System.EventHandler(this.fOSBtn1_Click);
            // 
            // fOSBtn2
            // 
            this.fOSBtn2.Location = new System.Drawing.Point(142, 12);
            this.fOSBtn2.Name = "fOSBtn2";
            this.fOSBtn2.Size = new System.Drawing.Size(109, 46);
            this.fOSBtn2.TabIndex = 1;
            this.fOSBtn2.Text = "未入庫一覧";
            this.fOSBtn2.UseVisualStyleBackColor = true;
            this.fOSBtn2.Click += new System.EventHandler(this.fOSBtn2_Click);
            // 
            // fOSSearchBtn
            // 
            this.fOSSearchBtn.Location = new System.Drawing.Point(726, 93);
            this.fOSSearchBtn.Name = "fOSSearchBtn";
            this.fOSSearchBtn.Size = new System.Drawing.Size(93, 43);
            this.fOSSearchBtn.TabIndex = 2;
            this.fOSSearchBtn.Text = "検索";
            this.fOSSearchBtn.UseVisualStyleBackColor = true;
            this.fOSSearchBtn.Click += new System.EventHandler(this.fOSSearchBtn_Click);
            // 
            // fOSUpdateBtn
            // 
            this.fOSUpdateBtn.Location = new System.Drawing.Point(12, 408);
            this.fOSUpdateBtn.Name = "fOSUpdateBtn";
            this.fOSUpdateBtn.Size = new System.Drawing.Size(105, 47);
            this.fOSUpdateBtn.TabIndex = 3;
            this.fOSUpdateBtn.Text = "更新";
            this.fOSUpdateBtn.UseVisualStyleBackColor = true;
            this.fOSUpdateBtn.Click += new System.EventHandler(this.fOSUpdateBtn_Click);
            // 
            // fOSFormBtn
            // 
            this.fOSFormBtn.Location = new System.Drawing.Point(142, 408);
            this.fOSFormBtn.Name = "fOSFormBtn";
            this.fOSFormBtn.Size = new System.Drawing.Size(120, 47);
            this.fOSFormBtn.TabIndex = 4;
            this.fOSFormBtn.Text = "発注書作成";
            this.fOSFormBtn.UseVisualStyleBackColor = true;
            this.fOSFormBtn.Click += new System.EventHandler(this.fOSFormBtn_Click);
            // 
            // fOSConfirmBtn
            // 
            this.fOSConfirmBtn.Location = new System.Drawing.Point(627, 408);
            this.fOSConfirmBtn.Name = "fOSConfirmBtn";
            this.fOSConfirmBtn.Size = new System.Drawing.Size(92, 47);
            this.fOSConfirmBtn.TabIndex = 5;
            this.fOSConfirmBtn.Text = "確定";
            this.fOSConfirmBtn.UseVisualStyleBackColor = true;
            this.fOSConfirmBtn.Click += new System.EventHandler(this.fOSConfirmBtn_Click);
            // 
            // fOSBackBtn
            // 
            this.fOSBackBtn.Location = new System.Drawing.Point(744, 408);
            this.fOSBackBtn.Name = "fOSBackBtn";
            this.fOSBackBtn.Size = new System.Drawing.Size(88, 47);
            this.fOSBackBtn.TabIndex = 6;
            this.fOSBackBtn.Text = "戻る";
            this.fOSBackBtn.UseVisualStyleBackColor = true;
            this.fOSBackBtn.Click += new System.EventHandler(this.fOSBackBtn_Click);
            // 
            // fOSidlabel
            // 
            this.fOSidlabel.AutoSize = true;
            this.fOSidlabel.Location = new System.Drawing.Point(631, 23);
            this.fOSidlabel.Name = "fOSidlabel";
            this.fOSidlabel.Size = new System.Drawing.Size(51, 15);
            this.fOSidlabel.TabIndex = 7;
            this.fOSidlabel.Text = "社員ID";
            this.fOSidlabel.Click += new System.EventHandler(this.fOSidlabel_Click);
            // 
            // fOSnamelabel
            // 
            this.fOSnamelabel.AutoSize = true;
            this.fOSnamelabel.Location = new System.Drawing.Point(723, 23);
            this.fOSnamelabel.Name = "fOSnamelabel";
            this.fOSnamelabel.Size = new System.Drawing.Size(52, 15);
            this.fOSnamelabel.TabIndex = 8;
            this.fOSnamelabel.Text = "社員名";
            this.fOSnamelabel.Click += new System.EventHandler(this.fOSnamelabel_Click);
            // 
            // fOSNlabel
            // 
            this.fOSNlabel.AutoSize = true;
            this.fOSNlabel.Location = new System.Drawing.Point(129, 67);
            this.fOSNlabel.Name = "fOSNlabel";
            this.fOSNlabel.Size = new System.Drawing.Size(67, 15);
            this.fOSNlabel.TabIndex = 9;
            this.fOSNlabel.Text = "発注番号";
            this.fOSNlabel.Click += new System.EventHandler(this.fOSNlabel_Click);
            // 
            // fOSMerchandiselabel
            // 
            this.fOSMerchandiselabel.AutoSize = true;
            this.fOSMerchandiselabel.Location = new System.Drawing.Point(328, 67);
            this.fOSMerchandiselabel.Name = "fOSMerchandiselabel";
            this.fOSMerchandiselabel.Size = new System.Drawing.Size(67, 15);
            this.fOSMerchandiselabel.TabIndex = 10;
            this.fOSMerchandiselabel.Text = "商品情報";
            this.fOSMerchandiselabel.Click += new System.EventHandler(this.fOSMerchandiselabel_Click);
            // 
            // fOSOrdernamebrandlabel
            // 
            this.fOSOrdernamebrandlabel.AutoSize = true;
            this.fOSOrdernamebrandlabel.Location = new System.Drawing.Point(543, 67);
            this.fOSOrdernamebrandlabel.Name = "fOSOrdernamebrandlabel";
            this.fOSOrdernamebrandlabel.Size = new System.Drawing.Size(55, 15);
            this.fOSOrdernamebrandlabel.TabIndex = 11;
            this.fOSOrdernamebrandlabel.Text = "メーカ名";
            this.fOSOrdernamebrandlabel.Click += new System.EventHandler(this.fOSOrdernamebrandlabel_Click);
            // 
            // fOSOrderidlabel
            // 
            this.fOSOrderidlabel.AutoSize = true;
            this.fOSOrderidlabel.Location = new System.Drawing.Point(728, 67);
            this.fOSOrderidlabel.Name = "fOSOrderidlabel";
            this.fOSOrderidlabel.Size = new System.Drawing.Size(51, 15);
            this.fOSOrderidlabel.TabIndex = 12;
            this.fOSOrderidlabel.Text = "発注ID";
            this.fOSOrderidlabel.Click += new System.EventHandler(this.fOSOrderidlabel_Click);
            // 
            // fOSDaylabel
            // 
            this.fOSDaylabel.AutoSize = true;
            this.fOSDaylabel.Location = new System.Drawing.Point(362, 107);
            this.fOSDaylabel.Name = "fOSDaylabel";
            this.fOSDaylabel.Size = new System.Drawing.Size(22, 15);
            this.fOSDaylabel.TabIndex = 15;
            this.fOSDaylabel.Text = "～";
            this.fOSDaylabel.Click += new System.EventHandler(this.fOSDaylabel_Click);
            // 
            // fOSNamberTBox
            // 
            this.fOSNamberTBox.Location = new System.Drawing.Point(17, 64);
            this.fOSNamberTBox.Name = "fOSNamberTBox";
            this.fOSNamberTBox.Size = new System.Drawing.Size(106, 22);
            this.fOSNamberTBox.TabIndex = 19;
            this.fOSNamberTBox.TextChanged += new System.EventHandler(this.fOSNamberTBox_TextChanged);
            // 
            // fOSMerchandiseTBox
            // 
            this.fOSMerchandiseTBox.Location = new System.Drawing.Point(222, 64);
            this.fOSMerchandiseTBox.Name = "fOSMerchandiseTBox";
            this.fOSMerchandiseTBox.Size = new System.Drawing.Size(100, 22);
            this.fOSMerchandiseTBox.TabIndex = 20;
            this.fOSMerchandiseTBox.TextChanged += new System.EventHandler(this.fOSMerchandisTBox_TextChanged);
            // 
            // fOSOrdernamebrandTBox
            // 
            this.fOSOrdernamebrandTBox.Location = new System.Drawing.Point(412, 64);
            this.fOSOrdernamebrandTBox.Name = "fOSOrdernamebrandTBox";
            this.fOSOrdernamebrandTBox.Size = new System.Drawing.Size(125, 22);
            this.fOSOrdernamebrandTBox.TabIndex = 21;
            this.fOSOrdernamebrandTBox.TextChanged += new System.EventHandler(this.fOSOrdernamebrandTBox_TextChanged);
            // 
            // fOSOrderidTBox
            // 
            this.fOSOrderidTBox.Location = new System.Drawing.Point(604, 64);
            this.fOSOrderidTBox.Name = "fOSOrderidTBox";
            this.fOSOrderidTBox.Size = new System.Drawing.Size(118, 22);
            this.fOSOrderidTBox.TabIndex = 22;
            this.fOSOrderidTBox.TextChanged += new System.EventHandler(this.fOSOrderidTBox_TextChanged);
            // 
            // fOSDataGridView1
            // 
            this.fOSDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fOSDataGridView1.Location = new System.Drawing.Point(12, 142);
            this.fOSDataGridView1.Name = "fOSDataGridView1";
            this.fOSDataGridView1.RowTemplate.Height = 24;
            this.fOSDataGridView1.Size = new System.Drawing.Size(825, 260);
            this.fOSDataGridView1.TabIndex = 29;
            this.fOSDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fOSDataGridView1_CellContentClick);
            // 
            // fOSdtPicker1
            // 
            this.fOSdtPicker1.Location = new System.Drawing.Point(89, 101);
            this.fOSdtPicker1.Name = "fOSdtPicker1";
            this.fOSdtPicker1.Size = new System.Drawing.Size(221, 22);
            this.fOSdtPicker1.TabIndex = 30;
            this.fOSdtPicker1.ValueChanged += new System.EventHandler(this.fOSdtPicker1_ValueChanged);
            // 
            // fOSdtPicker2
            // 
            this.fOSdtPicker2.Location = new System.Drawing.Point(428, 101);
            this.fOSdtPicker2.Name = "fOSdtPicker2";
            this.fOSdtPicker2.Size = new System.Drawing.Size(243, 22);
            this.fOSdtPicker2.TabIndex = 31;
            this.fOSdtPicker2.ValueChanged += new System.EventHandler(this.fOSdtPicker2_ValueChanged);
            // 
            // frmOrderstockManegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 458);
            this.Controls.Add(this.fOSdtPicker2);
            this.Controls.Add(this.fOSdtPicker1);
            this.Controls.Add(this.fOSDataGridView1);
            this.Controls.Add(this.fOSOrderidTBox);
            this.Controls.Add(this.fOSOrdernamebrandTBox);
            this.Controls.Add(this.fOSMerchandiseTBox);
            this.Controls.Add(this.fOSNamberTBox);
            this.Controls.Add(this.fOSDaylabel);
            this.Controls.Add(this.fOSOrderidlabel);
            this.Controls.Add(this.fOSOrdernamebrandlabel);
            this.Controls.Add(this.fOSMerchandiselabel);
            this.Controls.Add(this.fOSNlabel);
            this.Controls.Add(this.fOSnamelabel);
            this.Controls.Add(this.fOSidlabel);
            this.Controls.Add(this.fOSBackBtn);
            this.Controls.Add(this.fOSConfirmBtn);
            this.Controls.Add(this.fOSFormBtn);
            this.Controls.Add(this.fOSUpdateBtn);
            this.Controls.Add(this.fOSSearchBtn);
            this.Controls.Add(this.fOSBtn2);
            this.Controls.Add(this.fOSBtn1);
            this.Name = "frmOrderstockManegement";
            this.Text = "frmOrderstockManegement";
            this.Load += new System.EventHandler(this.frmOrderstockManegement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fOSDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fOSBtn1;
        private System.Windows.Forms.Button fOSBtn2;
        private System.Windows.Forms.Button fOSSearchBtn;
        private System.Windows.Forms.Button fOSUpdateBtn;
        private System.Windows.Forms.Button fOSFormBtn;
        private System.Windows.Forms.Button fOSConfirmBtn;
        private System.Windows.Forms.Button fOSBackBtn;
        private System.Windows.Forms.Label fOSidlabel;
        private System.Windows.Forms.Label fOSnamelabel;
        private System.Windows.Forms.Label fOSNlabel;
        private System.Windows.Forms.Label fOSMerchandiselabel;
        private System.Windows.Forms.Label fOSOrdernamebrandlabel;
        private System.Windows.Forms.Label fOSOrderidlabel;
        private System.Windows.Forms.Label fOSDaylabel;
        private System.Windows.Forms.TextBox fOSNamberTBox;
        private System.Windows.Forms.TextBox fOSMerchandiseTBox;
        private System.Windows.Forms.TextBox fOSOrdernamebrandTBox;
        private System.Windows.Forms.TextBox fOSOrderidTBox;
        private System.Windows.Forms.DataGridView fOSDataGridView1;
        private System.Windows.Forms.DateTimePicker fOSdtPicker1;
        private System.Windows.Forms.DateTimePicker fOSdtPicker2;
    }
}