namespace habigisu
{
    partial class frmProductManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FPMPlistBtn = new System.Windows.Forms.Button();
            this.FPMSearchBtn = new System.Windows.Forms.Button();
            this.FPMRegiBtn = new System.Windows.Forms.Button();
            this.FPMUpdateBtn = new System.Windows.Forms.Button();
            this.FPMBackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FPMPidTbox = new System.Windows.Forms.TextBox();
            this.FPMProTbox = new System.Windows.Forms.TextBox();
            this.FPMAutTbox = new System.Windows.Forms.TextBox();
            this.FPMPubTbox = new System.Windows.Forms.TextBox();
            this.FPMIDlbl = new System.Windows.Forms.Label();
            this.FPMGenreCBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // FPMPlistBtn
            // 
            this.FPMPlistBtn.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPMPlistBtn.Location = new System.Drawing.Point(8, 8);
            this.FPMPlistBtn.Name = "FPMPlistBtn";
            this.FPMPlistBtn.Size = new System.Drawing.Size(125, 45);
            this.FPMPlistBtn.TabIndex = 1;
            this.FPMPlistBtn.Text = "商品一覧";
            this.FPMPlistBtn.UseVisualStyleBackColor = true;
            // 
            // FPMSearchBtn
            // 
            this.FPMSearchBtn.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPMSearchBtn.Location = new System.Drawing.Point(876, 77);
            this.FPMSearchBtn.Name = "FPMSearchBtn";
            this.FPMSearchBtn.Size = new System.Drawing.Size(90, 40);
            this.FPMSearchBtn.TabIndex = 2;
            this.FPMSearchBtn.Text = "検索";
            this.FPMSearchBtn.UseVisualStyleBackColor = true;
            this.FPMSearchBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FPMSearchBtn_KeyDown);
            // 
            // FPMRegiBtn
            // 
            this.FPMRegiBtn.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPMRegiBtn.Location = new System.Drawing.Point(27, 449);
            this.FPMRegiBtn.Name = "FPMRegiBtn";
            this.FPMRegiBtn.Size = new System.Drawing.Size(123, 47);
            this.FPMRegiBtn.TabIndex = 3;
            this.FPMRegiBtn.Text = "商品登録";
            this.FPMRegiBtn.UseVisualStyleBackColor = true;
            // 
            // FPMUpdateBtn
            // 
            this.FPMUpdateBtn.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPMUpdateBtn.Location = new System.Drawing.Point(173, 449);
            this.FPMUpdateBtn.Name = "FPMUpdateBtn";
            this.FPMUpdateBtn.Size = new System.Drawing.Size(80, 47);
            this.FPMUpdateBtn.TabIndex = 4;
            this.FPMUpdateBtn.Text = "更新";
            this.FPMUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // FPMBackBtn
            // 
            this.FPMBackBtn.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPMBackBtn.Location = new System.Drawing.Point(876, 449);
            this.FPMBackBtn.Name = "FPMBackBtn";
            this.FPMBackBtn.Size = new System.Drawing.Size(90, 47);
            this.FPMBackBtn.TabIndex = 5;
            this.FPMBackBtn.Text = "戻る";
            this.FPMBackBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(181, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "商品ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(389, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "商品名:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "ジャンル:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(391, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "著者名:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(578, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "出版社:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FPMPidTbox
            // 
            this.FPMPidTbox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FPMPidTbox.Location = new System.Drawing.Point(249, 42);
            this.FPMPidTbox.MaxLength = 7;
            this.FPMPidTbox.Name = "FPMPidTbox";
            this.FPMPidTbox.Size = new System.Drawing.Size(106, 30);
            this.FPMPidTbox.TabIndex = 11;
            this.FPMPidTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FPMPidTbox_KeyDown);
            // 
            // FPMProTbox
            // 
            this.FPMProTbox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FPMProTbox.Location = new System.Drawing.Point(450, 42);
            this.FPMProTbox.MaxLength = 60;
            this.FPMProTbox.Name = "FPMProTbox";
            this.FPMProTbox.Size = new System.Drawing.Size(372, 30);
            this.FPMProTbox.TabIndex = 12;
            this.FPMProTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FPMProTbox_KeyDown);
            // 
            // FPMAutTbox
            // 
            this.FPMAutTbox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FPMAutTbox.Location = new System.Drawing.Point(450, 86);
            this.FPMAutTbox.MaxLength = 30;
            this.FPMAutTbox.Name = "FPMAutTbox";
            this.FPMAutTbox.Size = new System.Drawing.Size(124, 30);
            this.FPMAutTbox.TabIndex = 14;
            this.FPMAutTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FPMAutTbox_KeyDown);
            // 
            // FPMPubTbox
            // 
            this.FPMPubTbox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FPMPubTbox.Location = new System.Drawing.Point(639, 86);
            this.FPMPubTbox.MaxLength = 30;
            this.FPMPubTbox.Name = "FPMPubTbox";
            this.FPMPubTbox.Size = new System.Drawing.Size(183, 30);
            this.FPMPubTbox.TabIndex = 15;
            // 
            // FPMIDlbl
            // 
            this.FPMIDlbl.AutoSize = true;
            this.FPMIDlbl.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FPMIDlbl.Location = new System.Drawing.Point(896, 19);
            this.FPMIDlbl.Name = "FPMIDlbl";
            this.FPMIDlbl.Size = new System.Drawing.Size(57, 23);
            this.FPMIDlbl.TabIndex = 16;
            this.FPMIDlbl.Text = "社員ID";
            // 
            // FPMGenreCBox
            // 
            this.FPMGenreCBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FPMGenreCBox.FormattingEnabled = true;
            this.FPMGenreCBox.Items.AddRange(new object[] {
            "文学・評論",
            "ノンフィクション",
            "ビジネス・経済",
            "歴史・地理",
            "政治・社会",
            "芸能・エンターテインメント",
            "アート・建築・デザイン",
            "暮らし・健康・料理",
            "サイエンス・テクノロジー",
            "趣味・実用",
            "教育・自己啓発",
            "スポーツ・アウトドア",
            "事典・年鑑・本・ことば",
            "音楽",
            "旅行・紀行",
            "絵本・児童書",
            "人文・思想・宗教",
            "コミックス"});
            this.FPMGenreCBox.Location = new System.Drawing.Point(94, 86);
            this.FPMGenreCBox.Name = "FPMGenreCBox";
            this.FPMGenreCBox.Size = new System.Drawing.Size(261, 31);
            this.FPMGenreCBox.TabIndex = 17;
            this.FPMGenreCBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FPMGenreCBox_KeyDown);
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 508);
            this.Controls.Add(this.FPMGenreCBox);
            this.Controls.Add(this.FPMIDlbl);
            this.Controls.Add(this.FPMPubTbox);
            this.Controls.Add(this.FPMAutTbox);
            this.Controls.Add(this.FPMProTbox);
            this.Controls.Add(this.FPMPidTbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FPMBackBtn);
            this.Controls.Add(this.FPMUpdateBtn);
            this.Controls.Add(this.FPMRegiBtn);
            this.Controls.Add(this.FPMSearchBtn);
            this.Controls.Add(this.FPMPlistBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmProductManagement";
            this.Text = "frmProductManagement";
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            this.Shown += new System.EventHandler(this.frmProductManagement_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FPMPlistBtn;
        private System.Windows.Forms.Button FPMSearchBtn;
        private System.Windows.Forms.Button FPMRegiBtn;
        private System.Windows.Forms.Button FPMUpdateBtn;
        private System.Windows.Forms.Button FPMBackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FPMPidTbox;
        private System.Windows.Forms.TextBox FPMProTbox;
        private System.Windows.Forms.TextBox FPMAutTbox;
        private System.Windows.Forms.TextBox FPMPubTbox;
        private System.Windows.Forms.Label FPMIDlbl;
        private System.Windows.Forms.ComboBox FPMGenreCBox;
    }
}