namespace habigisu
{
    partial class frmShippingManagement
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
            this.FSMSlistBtn = new System.Windows.Forms.Button();
            this.FSMNotSlistBtn = new System.Windows.Forms.Button();
            this.FSMSearchBtn = new System.Windows.Forms.Button();
            this.FSMBackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FSMIDlbl = new System.Windows.Forms.Label();
            this.FSMOrderIDTbox = new System.Windows.Forms.TextBox();
            this.FSMSIDTbox = new System.Windows.Forms.TextBox();
            this.FSMEmpIDTbox = new System.Windows.Forms.TextBox();
            this.FSMDatagridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FSMDatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // FSMSlistBtn
            // 
            this.FSMSlistBtn.Location = new System.Drawing.Point(12, 9);
            this.FSMSlistBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FSMSlistBtn.Name = "FSMSlistBtn";
            this.FSMSlistBtn.Size = new System.Drawing.Size(160, 60);
            this.FSMSlistBtn.TabIndex = 1;
            this.FSMSlistBtn.Text = "出庫一覧";
            this.FSMSlistBtn.UseVisualStyleBackColor = true;
            this.FSMSlistBtn.Click += new System.EventHandler(this.FSMSlistBtn_Click);
            // 
            // FSMNotSlistBtn
            // 
            this.FSMNotSlistBtn.Location = new System.Drawing.Point(178, 9);
            this.FSMNotSlistBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FSMNotSlistBtn.Name = "FSMNotSlistBtn";
            this.FSMNotSlistBtn.Size = new System.Drawing.Size(160, 60);
            this.FSMNotSlistBtn.TabIndex = 2;
            this.FSMNotSlistBtn.Text = "未出庫一覧";
            this.FSMNotSlistBtn.UseVisualStyleBackColor = true;
            this.FSMNotSlistBtn.Click += new System.EventHandler(this.FSMNotSlistBtn_Click);
            // 
            // FSMSearchBtn
            // 
            this.FSMSearchBtn.Location = new System.Drawing.Point(921, 77);
            this.FSMSearchBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FSMSearchBtn.Name = "FSMSearchBtn";
            this.FSMSearchBtn.Size = new System.Drawing.Size(120, 50);
            this.FSMSearchBtn.TabIndex = 6;
            this.FSMSearchBtn.Text = "検索";
            this.FSMSearchBtn.UseVisualStyleBackColor = true;
            this.FSMSearchBtn.Click += new System.EventHandler(this.FSMSearchBtn_Click);
            // 
            // FSMBackBtn
            // 
            this.FSMBackBtn.Location = new System.Drawing.Point(921, 477);
            this.FSMBackBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FSMBackBtn.Name = "FSMBackBtn";
            this.FSMBackBtn.Size = new System.Drawing.Size(120, 50);
            this.FSMBackBtn.TabIndex = 7;
            this.FSMBackBtn.Text = "戻る";
            this.FSMBackBtn.UseVisualStyleBackColor = true;
            this.FSMBackBtn.Click += new System.EventHandler(this.FSMBackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "注文ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "出庫ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "社員ID：";
            // 
            // FSMIDlbl
            // 
            this.FSMIDlbl.AutoSize = true;
            this.FSMIDlbl.Location = new System.Drawing.Point(957, 9);
            this.FSMIDlbl.Name = "FSMIDlbl";
            this.FSMIDlbl.Size = new System.Drawing.Size(57, 23);
            this.FSMIDlbl.TabIndex = 0;
            this.FSMIDlbl.Text = "社員ID";
            // 
            // FSMOrderIDTbox
            // 
            this.FSMOrderIDTbox.Location = new System.Drawing.Point(73, 88);
            this.FSMOrderIDTbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FSMOrderIDTbox.Name = "FSMOrderIDTbox";
            this.FSMOrderIDTbox.Size = new System.Drawing.Size(220, 30);
            this.FSMOrderIDTbox.TabIndex = 3;
            // 
            // FSMSIDTbox
            // 
            this.FSMSIDTbox.Location = new System.Drawing.Point(377, 88);
            this.FSMSIDTbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FSMSIDTbox.Name = "FSMSIDTbox";
            this.FSMSIDTbox.Size = new System.Drawing.Size(220, 30);
            this.FSMSIDTbox.TabIndex = 4;
            // 
            // FSMEmpIDTbox
            // 
            this.FSMEmpIDTbox.Location = new System.Drawing.Point(683, 88);
            this.FSMEmpIDTbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FSMEmpIDTbox.Name = "FSMEmpIDTbox";
            this.FSMEmpIDTbox.Size = new System.Drawing.Size(220, 30);
            this.FSMEmpIDTbox.TabIndex = 5;
            // 
            // FSMDatagridview
            // 
            this.FSMDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FSMDatagridview.Location = new System.Drawing.Point(2, 137);
            this.FSMDatagridview.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FSMDatagridview.Name = "FSMDatagridview";
            this.FSMDatagridview.RowTemplate.Height = 24;
            this.FSMDatagridview.Size = new System.Drawing.Size(1050, 330);
            this.FSMDatagridview.TabIndex = 0;
            // 
            // frmShippingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 533);
            this.Controls.Add(this.FSMDatagridview);
            this.Controls.Add(this.FSMEmpIDTbox);
            this.Controls.Add(this.FSMSIDTbox);
            this.Controls.Add(this.FSMOrderIDTbox);
            this.Controls.Add(this.FSMIDlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FSMBackBtn);
            this.Controls.Add(this.FSMSearchBtn);
            this.Controls.Add(this.FSMNotSlistBtn);
            this.Controls.Add(this.FSMSlistBtn);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmShippingManagement";
            this.Text = "出庫管理";
            ((System.ComponentModel.ISupportInitialize)(this.FSMDatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FSMSlistBtn;
        private System.Windows.Forms.Button FSMNotSlistBtn;
        private System.Windows.Forms.Button FSMSearchBtn;
        private System.Windows.Forms.Button FSMBackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FSMIDlbl;
        private System.Windows.Forms.TextBox FSMOrderIDTbox;
        private System.Windows.Forms.TextBox FSMSIDTbox;
        private System.Windows.Forms.TextBox FSMEmpIDTbox;
        private System.Windows.Forms.DataGridView FSMDatagridview;
    }
}