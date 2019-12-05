namespace habigisu
{
    partial class frmOrderStockCreation
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
            this.fOSidlabel = new System.Windows.Forms.Label();
            this.fOSnamelabel = new System.Windows.Forms.Label();
            this.fOSupdateBtn = new System.Windows.Forms.Button();
            this.fOSCancelBtn = new System.Windows.Forms.Button();
            this.fOSconfirmBtn = new System.Windows.Forms.Button();
            this.fOSbackBtn = new System.Windows.Forms.Button();
            this.fOSDataGridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fOSDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // fOSidlabel
            // 
            this.fOSidlabel.AutoSize = true;
            this.fOSidlabel.Location = new System.Drawing.Point(597, 20);
            this.fOSidlabel.Name = "fOSidlabel";
            this.fOSidlabel.Size = new System.Drawing.Size(51, 15);
            this.fOSidlabel.TabIndex = 0;
            this.fOSidlabel.Text = "社員ID";
            // 
            // fOSnamelabel
            // 
            this.fOSnamelabel.AutoSize = true;
            this.fOSnamelabel.Location = new System.Drawing.Point(715, 20);
            this.fOSnamelabel.Name = "fOSnamelabel";
            this.fOSnamelabel.Size = new System.Drawing.Size(52, 15);
            this.fOSnamelabel.TabIndex = 1;
            this.fOSnamelabel.Text = "社員名";
            // 
            // fOSupdateBtn
            // 
            this.fOSupdateBtn.Location = new System.Drawing.Point(12, 393);
            this.fOSupdateBtn.Name = "fOSupdateBtn";
            this.fOSupdateBtn.Size = new System.Drawing.Size(88, 45);
            this.fOSupdateBtn.TabIndex = 2;
            this.fOSupdateBtn.Text = "更新";
            this.fOSupdateBtn.UseVisualStyleBackColor = true;
            this.fOSupdateBtn.Click += new System.EventHandler(this.fOSupdateBtn_Click);
            // 
            // fOSCancelBtn
            // 
            this.fOSCancelBtn.Location = new System.Drawing.Point(130, 393);
            this.fOSCancelBtn.Name = "fOSCancelBtn";
            this.fOSCancelBtn.Size = new System.Drawing.Size(88, 45);
            this.fOSCancelBtn.TabIndex = 3;
            this.fOSCancelBtn.Text = "取り消し";
            this.fOSCancelBtn.UseVisualStyleBackColor = true;
            this.fOSCancelBtn.Click += new System.EventHandler(this.fOSCancelBtn_Click);
            // 
            // fOSconfirmBtn
            // 
            this.fOSconfirmBtn.Location = new System.Drawing.Point(579, 393);
            this.fOSconfirmBtn.Name = "fOSconfirmBtn";
            this.fOSconfirmBtn.Size = new System.Drawing.Size(88, 45);
            this.fOSconfirmBtn.TabIndex = 4;
            this.fOSconfirmBtn.Text = "確定";
            this.fOSconfirmBtn.UseVisualStyleBackColor = true;
            this.fOSconfirmBtn.Click += new System.EventHandler(this.fOSconfirmBtn_Click);
            // 
            // fOSbackBtn
            // 
            this.fOSbackBtn.Location = new System.Drawing.Point(700, 393);
            this.fOSbackBtn.Name = "fOSbackBtn";
            this.fOSbackBtn.Size = new System.Drawing.Size(88, 45);
            this.fOSbackBtn.TabIndex = 5;
            this.fOSbackBtn.Text = "戻る";
            this.fOSbackBtn.UseVisualStyleBackColor = true;
            this.fOSbackBtn.Click += new System.EventHandler(this.fOSbackBtn_Click);
            // 
            // fOSDataGridview
            // 
            this.fOSDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fOSDataGridview.Location = new System.Drawing.Point(12, 50);
            this.fOSDataGridview.Name = "fOSDataGridview";
            this.fOSDataGridview.RowTemplate.Height = 24;
            this.fOSDataGridview.Size = new System.Drawing.Size(776, 337);
            this.fOSDataGridview.TabIndex = 6;
            // 
            // frmOrderStockCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fOSDataGridview);
            this.Controls.Add(this.fOSbackBtn);
            this.Controls.Add(this.fOSconfirmBtn);
            this.Controls.Add(this.fOSCancelBtn);
            this.Controls.Add(this.fOSupdateBtn);
            this.Controls.Add(this.fOSnamelabel);
            this.Controls.Add(this.fOSidlabel);
            this.Name = "frmOrderStockCreation";
            this.Text = "frmOrderStockCreation";
            ((System.ComponentModel.ISupportInitialize)(this.fOSDataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fOSidlabel;
        private System.Windows.Forms.Label fOSnamelabel;
        private System.Windows.Forms.Button fOSupdateBtn;
        private System.Windows.Forms.Button fOSCancelBtn;
        private System.Windows.Forms.Button fOSconfirmBtn;
        private System.Windows.Forms.Button fOSbackBtn;
        private System.Windows.Forms.DataGridView fOSDataGridview;
    }
}