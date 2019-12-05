namespace 販売在庫管理システム__
{
    partial class frmOrderManagement
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
            this.fOMBtn1 = new System.Windows.Forms.Button();
            this.fOMStatusTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fOMSearchBtn = new System.Windows.Forms.Button();
            this.fOMDataGridView = new System.Windows.Forms.DataGridView();
            this.fOMConfirmBtn = new System.Windows.Forms.Button();
            this.fOMUpdateBtn = new System.Windows.Forms.Button();
            this.fOMBackBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fOMYearCbox1 = new System.Windows.Forms.ComboBox();
            this.fOMMonthCbox1 = new System.Windows.Forms.ComboBox();
            this.fOMDayCbox1 = new System.Windows.Forms.ComboBox();
            this.fOMYearCbox2 = new System.Windows.Forms.ComboBox();
            this.fOMMonthCbox2 = new System.Windows.Forms.ComboBox();
            this.fOMDayCbox2 = new System.Windows.Forms.ComboBox();
            this.fOMBtn2 = new System.Windows.Forms.Button();
            this.fOMProductTbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fOMMakeBtn = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.fOMOrderIdTbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fOMDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fOMBtn1
            // 
            this.fOMBtn1.Location = new System.Drawing.Point(2, 1);
            this.fOMBtn1.Name = "fOMBtn1";
            this.fOMBtn1.Size = new System.Drawing.Size(139, 37);
            this.fOMBtn1.TabIndex = 0;
            this.fOMBtn1.Text = "注文一覧";
            this.fOMBtn1.UseVisualStyleBackColor = true;
            this.fOMBtn1.Click += new System.EventHandler(this.fOMBtn1_Click);
            // 
            // fOMStatusTbox
            // 
            this.fOMStatusTbox.Location = new System.Drawing.Point(2, 44);
            this.fOMStatusTbox.Name = "fOMStatusTbox";
            this.fOMStatusTbox.Size = new System.Drawing.Size(156, 22);
            this.fOMStatusTbox.TabIndex = 1;
            this.fOMStatusTbox.TextChanged += new System.EventHandler(this.fOMStatusTbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "顧客注文状況";
            // 
            // fOMSearchBtn
            // 
            this.fOMSearchBtn.Location = new System.Drawing.Point(698, 69);
            this.fOMSearchBtn.Name = "fOMSearchBtn";
            this.fOMSearchBtn.Size = new System.Drawing.Size(100, 26);
            this.fOMSearchBtn.TabIndex = 9;
            this.fOMSearchBtn.Text = "検索";
            this.fOMSearchBtn.UseVisualStyleBackColor = true;
            this.fOMSearchBtn.Click += new System.EventHandler(this.fOMSearchBtn_Click);
            // 
            // fOMDataGridView
            // 
            this.fOMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fOMDataGridView.Location = new System.Drawing.Point(2, 100);
            this.fOMDataGridView.Name = "fOMDataGridView";
            this.fOMDataGridView.RowTemplate.Height = 24;
            this.fOMDataGridView.Size = new System.Drawing.Size(796, 315);
            this.fOMDataGridView.TabIndex = 10;
            // 
            // fOMConfirmBtn
            // 
            this.fOMConfirmBtn.Location = new System.Drawing.Point(624, 418);
            this.fOMConfirmBtn.Name = "fOMConfirmBtn";
            this.fOMConfirmBtn.Size = new System.Drawing.Size(84, 29);
            this.fOMConfirmBtn.TabIndex = 11;
            this.fOMConfirmBtn.Text = "確定";
            this.fOMConfirmBtn.UseVisualStyleBackColor = true;
            this.fOMConfirmBtn.Click += new System.EventHandler(this.fOMConfirmBtn_Click);
            // 
            // fOMUpdateBtn
            // 
            this.fOMUpdateBtn.Location = new System.Drawing.Point(2, 418);
            this.fOMUpdateBtn.Name = "fOMUpdateBtn";
            this.fOMUpdateBtn.Size = new System.Drawing.Size(86, 29);
            this.fOMUpdateBtn.TabIndex = 12;
            this.fOMUpdateBtn.Text = "更新";
            this.fOMUpdateBtn.UseVisualStyleBackColor = true;
            this.fOMUpdateBtn.Click += new System.EventHandler(this.fOMUpdateBtn_Click);
            // 
            // fOMBackBtn
            // 
            this.fOMBackBtn.Location = new System.Drawing.Point(714, 418);
            this.fOMBackBtn.Name = "fOMBackBtn";
            this.fOMBackBtn.Size = new System.Drawing.Size(84, 29);
            this.fOMBackBtn.TabIndex = 13;
            this.fOMBackBtn.Text = "戻る";
            this.fOMBackBtn.UseVisualStyleBackColor = true;
            this.fOMBackBtn.Click += new System.EventHandler(this.fOMBackBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "年";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "月";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "～";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "年";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "月";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "日";
            // 
            // fOMYearCbox1
            // 
            this.fOMYearCbox1.FormattingEnabled = true;
            this.fOMYearCbox1.Location = new System.Drawing.Point(2, 71);
            this.fOMYearCbox1.Name = "fOMYearCbox1";
            this.fOMYearCbox1.Size = new System.Drawing.Size(100, 23);
            this.fOMYearCbox1.TabIndex = 21;
            this.fOMYearCbox1.SelectedIndexChanged += new System.EventHandler(this.fOMYearCbox1_SelectedIndexChanged);
            // 
            // fOMMonthCbox1
            // 
            this.fOMMonthCbox1.FormattingEnabled = true;
            this.fOMMonthCbox1.Location = new System.Drawing.Point(137, 71);
            this.fOMMonthCbox1.Name = "fOMMonthCbox1";
            this.fOMMonthCbox1.Size = new System.Drawing.Size(55, 23);
            this.fOMMonthCbox1.TabIndex = 22;
            this.fOMMonthCbox1.SelectedIndexChanged += new System.EventHandler(this.fOMMonthCbox1_SelectedIndexChanged);
            // 
            // fOMDayCbox1
            // 
            this.fOMDayCbox1.FormattingEnabled = true;
            this.fOMDayCbox1.Location = new System.Drawing.Point(226, 71);
            this.fOMDayCbox1.Name = "fOMDayCbox1";
            this.fOMDayCbox1.Size = new System.Drawing.Size(55, 23);
            this.fOMDayCbox1.TabIndex = 23;
            this.fOMDayCbox1.SelectedIndexChanged += new System.EventHandler(this.fOMDayCbox1_SelectedIndexChanged);
            // 
            // fOMYearCbox2
            // 
            this.fOMYearCbox2.FormattingEnabled = true;
            this.fOMYearCbox2.Location = new System.Drawing.Point(343, 71);
            this.fOMYearCbox2.Name = "fOMYearCbox2";
            this.fOMYearCbox2.Size = new System.Drawing.Size(100, 23);
            this.fOMYearCbox2.TabIndex = 24;
            this.fOMYearCbox2.SelectedIndexChanged += new System.EventHandler(this.fOMYearCbox2_SelectedIndexChanged);
            // 
            // fOMMonthCbox2
            // 
            this.fOMMonthCbox2.FormattingEnabled = true;
            this.fOMMonthCbox2.Location = new System.Drawing.Point(478, 71);
            this.fOMMonthCbox2.Name = "fOMMonthCbox2";
            this.fOMMonthCbox2.Size = new System.Drawing.Size(54, 23);
            this.fOMMonthCbox2.TabIndex = 25;
            this.fOMMonthCbox2.SelectedIndexChanged += new System.EventHandler(this.fOMMonthCbox2_SelectedIndexChanged);
            // 
            // fOMDayCbox2
            // 
            this.fOMDayCbox2.FormattingEnabled = true;
            this.fOMDayCbox2.Location = new System.Drawing.Point(566, 71);
            this.fOMDayCbox2.Name = "fOMDayCbox2";
            this.fOMDayCbox2.Size = new System.Drawing.Size(55, 23);
            this.fOMDayCbox2.TabIndex = 26;
            this.fOMDayCbox2.SelectedIndexChanged += new System.EventHandler(this.fOMDayCbox2_SelectedIndexChanged);
            // 
            // fOMBtn2
            // 
            this.fOMBtn2.Location = new System.Drawing.Point(145, 1);
            this.fOMBtn2.Name = "fOMBtn2";
            this.fOMBtn2.Size = new System.Drawing.Size(125, 37);
            this.fOMBtn2.TabIndex = 27;
            this.fOMBtn2.Text = "未出庫一覧";
            this.fOMBtn2.UseVisualStyleBackColor = true;
            this.fOMBtn2.Click += new System.EventHandler(this.fOMBtn2_Click);
            // 
            // fOMProductTbox
            // 
            this.fOMProductTbox.Location = new System.Drawing.Point(506, 44);
            this.fOMProductTbox.Name = "fOMProductTbox";
            this.fOMProductTbox.Size = new System.Drawing.Size(169, 22);
            this.fOMProductTbox.TabIndex = 28;
            this.fOMProductTbox.TextChanged += new System.EventHandler(this.fOMProductTbox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(681, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "商品ID";
            // 
            // fOMMakeBtn
            // 
            this.fOMMakeBtn.Location = new System.Drawing.Point(94, 418);
            this.fOMMakeBtn.Name = "fOMMakeBtn";
            this.fOMMakeBtn.Size = new System.Drawing.Size(98, 29);
            this.fOMMakeBtn.TabIndex = 30;
            this.fOMMakeBtn.Text = "注文書作成";
            this.fOMMakeBtn.UseVisualStyleBackColor = true;
            this.fOMMakeBtn.Click += new System.EventHandler(this.fOMMakeBtn_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(737, 9);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(52, 15);
            this.namelabel.TabIndex = 31;
            this.namelabel.Text = "社員名";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(668, 9);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(51, 15);
            this.idlabel.TabIndex = 32;
            this.idlabel.Text = "社員ID";
            // 
            // fOMOrderIdTbox
            // 
            this.fOMOrderIdTbox.Location = new System.Drawing.Point(280, 44);
            this.fOMOrderIdTbox.Name = "fOMOrderIdTbox";
            this.fOMOrderIdTbox.Size = new System.Drawing.Size(154, 22);
            this.fOMOrderIdTbox.TabIndex = 33;
            this.fOMOrderIdTbox.TextChanged += new System.EventHandler(this.fOMOrderIdTbox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "注文ID";
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fOMOrderIdTbox);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.fOMMakeBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fOMProductTbox);
            this.Controls.Add(this.fOMBtn2);
            this.Controls.Add(this.fOMDayCbox2);
            this.Controls.Add(this.fOMMonthCbox2);
            this.Controls.Add(this.fOMYearCbox2);
            this.Controls.Add(this.fOMDayCbox1);
            this.Controls.Add(this.fOMMonthCbox1);
            this.Controls.Add(this.fOMYearCbox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fOMBackBtn);
            this.Controls.Add(this.fOMUpdateBtn);
            this.Controls.Add(this.fOMConfirmBtn);
            this.Controls.Add(this.fOMDataGridView);
            this.Controls.Add(this.fOMSearchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fOMStatusTbox);
            this.Controls.Add(this.fOMBtn1);
            this.Name = "frmOrderManagement";
            this.Text = "注文管理画面";
            ((System.ComponentModel.ISupportInitialize)(this.fOMDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fOMBtn1;
        private System.Windows.Forms.TextBox fOMStatusTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fOMSearchBtn;
        private System.Windows.Forms.DataGridView fOMDataGridView;
        private System.Windows.Forms.Button fOMConfirmBtn;
        private System.Windows.Forms.Button fOMUpdateBtn;
        private System.Windows.Forms.Button fOMBackBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox fOMYearCbox1;
        private System.Windows.Forms.ComboBox fOMMonthCbox1;
        private System.Windows.Forms.ComboBox fOMDayCbox1;
        private System.Windows.Forms.ComboBox fOMYearCbox2;
        private System.Windows.Forms.ComboBox fOMMonthCbox2;
        private System.Windows.Forms.ComboBox fOMDayCbox2;
        private System.Windows.Forms.Button fOMBtn2;
        private System.Windows.Forms.TextBox fOMProductTbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button fOMMakeBtn;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox fOMOrderIdTbox;
        private System.Windows.Forms.Label label12;
    }
}