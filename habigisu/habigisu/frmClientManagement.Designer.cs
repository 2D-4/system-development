namespace habigisu
{
    partial class frmClientManagement
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
            this.fCMCLBtn = new System.Windows.Forms.Button();
            this.fCMTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fCMSearchBtn = new System.Windows.Forms.Button();
            this.fCMDataGridView = new System.Windows.Forms.DataGridView();
            this.fCMRegisterBtn = new System.Windows.Forms.Button();
            this.fCMUpdateBtn = new System.Windows.Forms.Button();
            this.fCMBackBtn = new System.Windows.Forms.Button();
            this.fCMidlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fCMDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fCMCLBtn
            // 
            this.fCMCLBtn.Location = new System.Drawing.Point(0, 3);
            this.fCMCLBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fCMCLBtn.Name = "fCMCLBtn";
            this.fCMCLBtn.Size = new System.Drawing.Size(146, 76);
            this.fCMCLBtn.TabIndex = 1;
            this.fCMCLBtn.Text = "顧客一覧";
            this.fCMCLBtn.UseVisualStyleBackColor = true;
            this.fCMCLBtn.Click += new System.EventHandler(this.fCMCLBtn_Click);
            // 
            // fCMTBox
            // 
            this.fCMTBox.Location = new System.Drawing.Point(264, 44);
            this.fCMTBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fCMTBox.Name = "fCMTBox";
            this.fCMTBox.Size = new System.Drawing.Size(493, 30);
            this.fCMTBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "顧客情報：";
            // 
            // fCMSearchBtn
            // 
            this.fCMSearchBtn.Location = new System.Drawing.Point(797, 24);
            this.fCMSearchBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fCMSearchBtn.Name = "fCMSearchBtn";
            this.fCMSearchBtn.Size = new System.Drawing.Size(100, 50);
            this.fCMSearchBtn.TabIndex = 3;
            this.fCMSearchBtn.Text = "検索";
            this.fCMSearchBtn.UseVisualStyleBackColor = true;
            this.fCMSearchBtn.Click += new System.EventHandler(this.fCMSearchBtn_Click);
            // 
            // fCMDataGridView
            // 
            this.fCMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fCMDataGridView.Location = new System.Drawing.Point(0, 87);
            this.fCMDataGridView.Name = "fCMDataGridView";
            this.fCMDataGridView.RowTemplate.Height = 24;
            this.fCMDataGridView.Size = new System.Drawing.Size(1030, 390);
            this.fCMDataGridView.TabIndex = 0;
            this.fCMDataGridView.TabStop = false;
            // 
            // fCMRegisterBtn
            // 
            this.fCMRegisterBtn.Location = new System.Drawing.Point(12, 486);
            this.fCMRegisterBtn.Name = "fCMRegisterBtn";
            this.fCMRegisterBtn.Size = new System.Drawing.Size(120, 55);
            this.fCMRegisterBtn.TabIndex = 4;
            this.fCMRegisterBtn.Text = "登録";
            this.fCMRegisterBtn.UseVisualStyleBackColor = true;
            this.fCMRegisterBtn.Click += new System.EventHandler(this.fCMRegisterBtn_Click);
            // 
            // fCMUpdateBtn
            // 
            this.fCMUpdateBtn.Location = new System.Drawing.Point(138, 486);
            this.fCMUpdateBtn.Name = "fCMUpdateBtn";
            this.fCMUpdateBtn.Size = new System.Drawing.Size(120, 55);
            this.fCMUpdateBtn.TabIndex = 5;
            this.fCMUpdateBtn.Text = "更新";
            this.fCMUpdateBtn.UseVisualStyleBackColor = true;
            this.fCMUpdateBtn.Click += new System.EventHandler(this.fCMUpdateBtn_Click);
            // 
            // fCMBackBtn
            // 
            this.fCMBackBtn.Location = new System.Drawing.Point(890, 486);
            this.fCMBackBtn.Name = "fCMBackBtn";
            this.fCMBackBtn.Size = new System.Drawing.Size(130, 55);
            this.fCMBackBtn.TabIndex = 6;
            this.fCMBackBtn.Text = "戻る";
            this.fCMBackBtn.UseVisualStyleBackColor = true;
            this.fCMBackBtn.Click += new System.EventHandler(this.fCMBackBtn_Click);
            // 
            // fCMidlabel
            // 
            this.fCMidlabel.AutoSize = true;
            this.fCMidlabel.Location = new System.Drawing.Point(963, 9);
            this.fCMidlabel.Name = "fCMidlabel";
            this.fCMidlabel.Size = new System.Drawing.Size(57, 23);
            this.fCMidlabel.TabIndex = 0;
            this.fCMidlabel.Text = "社員ID";
            // 
            // frmClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.fCMidlabel);
            this.Controls.Add(this.fCMBackBtn);
            this.Controls.Add(this.fCMUpdateBtn);
            this.Controls.Add(this.fCMRegisterBtn);
            this.Controls.Add(this.fCMDataGridView);
            this.Controls.Add(this.fCMSearchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fCMTBox);
            this.Controls.Add(this.fCMCLBtn);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmClientManagement";
            this.Text = "顧客管理";
            ((System.ComponentModel.ISupportInitialize)(this.fCMDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fCMCLBtn;
        private System.Windows.Forms.TextBox fCMTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fCMSearchBtn;
        private System.Windows.Forms.DataGridView fCMDataGridView;
        private System.Windows.Forms.Button fCMRegisterBtn;
        private System.Windows.Forms.Button fCMUpdateBtn;
        private System.Windows.Forms.Button fCMBackBtn;
        private System.Windows.Forms.Label fCMidlabel;
    }
}