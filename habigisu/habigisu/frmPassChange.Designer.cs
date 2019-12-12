namespace habigisu
{
    partial class frmPassChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fPCIdTBox = new System.Windows.Forms.TextBox();
            this.fPCTBox = new System.Windows.Forms.TextBox();
            this.fPCNPTBox = new System.Windows.Forms.TextBox();
            this.fPCRNPTBox = new System.Windows.Forms.TextBox();
            this.fPCBackBtn = new System.Windows.Forms.Button();
            this.fPCChangeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(218, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "社員ID：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(101, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "(現在使用の)パスワード：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(144, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "新しいパスワード：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(85, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "新しいパスワードの再入力：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fPCIdTBox
            // 
            this.fPCIdTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fPCIdTBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fPCIdTBox.Location = new System.Drawing.Point(305, 62);
            this.fPCIdTBox.MaxLength = 7;
            this.fPCIdTBox.Name = "fPCIdTBox";
            this.fPCIdTBox.Size = new System.Drawing.Size(235, 30);
            this.fPCIdTBox.TabIndex = 4;
            this.fPCIdTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fPCIdTBox_KeyDown);
            this.fPCIdTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fPCIdTBox_KeyPress);
            // 
            // fPCTBox
            // 
            this.fPCTBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fPCTBox.Location = new System.Drawing.Point(305, 109);
            this.fPCTBox.MaxLength = 16;
            this.fPCTBox.Name = "fPCTBox";
            this.fPCTBox.PasswordChar = '*';
            this.fPCTBox.Size = new System.Drawing.Size(236, 30);
            this.fPCTBox.TabIndex = 5;
            this.fPCTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fPCTBox_KeyDown);
            this.fPCTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fPCTBox_KeyPress);
            // 
            // fPCNPTBox
            // 
            this.fPCNPTBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fPCNPTBox.Location = new System.Drawing.Point(304, 201);
            this.fPCNPTBox.MaxLength = 16;
            this.fPCNPTBox.Name = "fPCNPTBox";
            this.fPCNPTBox.PasswordChar = '*';
            this.fPCNPTBox.Size = new System.Drawing.Size(236, 30);
            this.fPCNPTBox.TabIndex = 6;
            this.fPCNPTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fPCNPTBox_KeyDown);
            this.fPCNPTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fPCNPTBox_KeyPress);
            // 
            // fPCRNPTBox
            // 
            this.fPCRNPTBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fPCRNPTBox.Location = new System.Drawing.Point(305, 272);
            this.fPCRNPTBox.MaxLength = 16;
            this.fPCRNPTBox.Name = "fPCRNPTBox";
            this.fPCRNPTBox.PasswordChar = '*';
            this.fPCRNPTBox.Size = new System.Drawing.Size(236, 30);
            this.fPCRNPTBox.TabIndex = 7;
            this.fPCRNPTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fPCRNPTBox_KeyDown);
            this.fPCRNPTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fPCRNPTBox_KeyPress);
            // 
            // fPCBackBtn
            // 
            this.fPCBackBtn.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPCBackBtn.Location = new System.Drawing.Point(211, 335);
            this.fPCBackBtn.Name = "fPCBackBtn";
            this.fPCBackBtn.Size = new System.Drawing.Size(90, 28);
            this.fPCBackBtn.TabIndex = 8;
            this.fPCBackBtn.Text = "戻る";
            this.fPCBackBtn.UseVisualStyleBackColor = true;
            // 
            // fPCChangeBtn
            // 
            this.fPCChangeBtn.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPCChangeBtn.Location = new System.Drawing.Point(336, 335);
            this.fPCChangeBtn.Name = "fPCChangeBtn";
            this.fPCChangeBtn.Size = new System.Drawing.Size(97, 28);
            this.fPCChangeBtn.TabIndex = 9;
            this.fPCChangeBtn.Text = "変更する";
            this.fPCChangeBtn.UseVisualStyleBackColor = true;
            this.fPCChangeBtn.Click += new System.EventHandler(this.fPCChangeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(92, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "(8文字以上半角英数字のみ)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 398);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fPCChangeBtn);
            this.Controls.Add(this.fPCBackBtn);
            this.Controls.Add(this.fPCRNPTBox);
            this.Controls.Add(this.fPCNPTBox);
            this.Controls.Add(this.fPCTBox);
            this.Controls.Add(this.fPCIdTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPassChange";
            this.Text = "パスワード変更画面";
            this.Shown += new System.EventHandler(this.frmPassChange_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fPCIdTBox;
        private System.Windows.Forms.TextBox fPCTBox;
        private System.Windows.Forms.TextBox fPCNPTBox;
        private System.Windows.Forms.TextBox fPCRNPTBox;
        private System.Windows.Forms.Button fPCBackBtn;
        private System.Windows.Forms.Button fPCChangeBtn;
        private System.Windows.Forms.Label label5;
    }
}