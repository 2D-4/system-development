namespace habigisu
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
            this.label5 = new System.Windows.Forms.Label();
            this.fOMBtn2 = new System.Windows.Forms.Button();
            this.fOMProductTbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fOMMakeBtn = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.fOMOrderIdTbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "～";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(379, 72);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fOMOrderIdTbox);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.fOMMakeBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fOMProductTbox);
            this.Controls.Add(this.fOMBtn2);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fOMBtn2;
        private System.Windows.Forms.TextBox fOMProductTbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button fOMMakeBtn;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox fOMOrderIdTbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}