﻿namespace habigisu
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
            this.fOSupdateBtn = new System.Windows.Forms.Button();
            this.fOSCancelBtn = new System.Windows.Forms.Button();
            this.fOSconfirmBtn = new System.Windows.Forms.Button();
            this.fOSbackBtn = new System.Windows.Forms.Button();
            this.fOSDataGridview = new System.Windows.Forms.DataGridView();
            this.fOStB1 = new System.Windows.Forms.TextBox();
            this.fOSupdatelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fOSDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // fOSidlabel
            // 
            this.fOSidlabel.AutoSize = true;
            this.fOSidlabel.Location = new System.Drawing.Point(712, 21);
            this.fOSidlabel.Name = "fOSidlabel";
            this.fOSidlabel.Size = new System.Drawing.Size(51, 15);
            this.fOSidlabel.TabIndex = 0;
            this.fOSidlabel.Text = "社員ID";
            // 
            // fOSupdateBtn
            // 
            this.fOSupdateBtn.Location = new System.Drawing.Point(124, 394);
            this.fOSupdateBtn.Name = "fOSupdateBtn";
            this.fOSupdateBtn.Size = new System.Drawing.Size(88, 45);
            this.fOSupdateBtn.TabIndex = 2;
            this.fOSupdateBtn.Text = "更新";
            this.fOSupdateBtn.UseVisualStyleBackColor = true;
            this.fOSupdateBtn.Click += new System.EventHandler(this.fOSupdateBtn_Click);
            // 
            // fOSCancelBtn
            // 
            this.fOSCancelBtn.Location = new System.Drawing.Point(12, 395);
            this.fOSCancelBtn.Name = "fOSCancelBtn";
            this.fOSCancelBtn.Size = new System.Drawing.Size(88, 45);
            this.fOSCancelBtn.TabIndex = 3;
            this.fOSCancelBtn.Text = "取り消し";
            this.fOSCancelBtn.UseVisualStyleBackColor = true;
            this.fOSCancelBtn.Click += new System.EventHandler(this.fOSCancelBtn_Click);
            // 
            // fOSconfirmBtn
            // 
            this.fOSconfirmBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.fOSconfirmBtn.Location = new System.Drawing.Point(584, 394);
            this.fOSconfirmBtn.Name = "fOSconfirmBtn";
            this.fOSconfirmBtn.Size = new System.Drawing.Size(88, 45);
            this.fOSconfirmBtn.TabIndex = 4;
            this.fOSconfirmBtn.Text = "確定";
            this.fOSconfirmBtn.UseVisualStyleBackColor = true;
            this.fOSconfirmBtn.Click += new System.EventHandler(this.fOSconfirmBtn_Click);
            // 
            // fOSbackBtn
            // 
            this.fOSbackBtn.Location = new System.Drawing.Point(700, 394);
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
            // fOStB1
            // 
            this.fOStB1.Location = new System.Drawing.Point(335, 406);
            this.fOStB1.Name = "fOStB1";
            this.fOStB1.Size = new System.Drawing.Size(100, 22);
            this.fOStB1.TabIndex = 7;
            // 
            // fOSupdatelabel
            // 
            this.fOSupdatelabel.AutoSize = true;
            this.fOSupdatelabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.fOSupdatelabel.Location = new System.Drawing.Point(244, 407);
            this.fOSupdatelabel.Name = "fOSupdatelabel";
            this.fOSupdatelabel.Size = new System.Drawing.Size(85, 17);
            this.fOSupdatelabel.TabIndex = 8;
            this.fOSupdatelabel.Text = "発注数量：";
            // 
            // frmOrderStockCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fOSupdatelabel);
            this.Controls.Add(this.fOStB1);
            this.Controls.Add(this.fOSDataGridview);
            this.Controls.Add(this.fOSbackBtn);
            this.Controls.Add(this.fOSconfirmBtn);
            this.Controls.Add(this.fOSCancelBtn);
            this.Controls.Add(this.fOSupdateBtn);
            this.Controls.Add(this.fOSidlabel);
            this.Name = "frmOrderStockCreation";
            this.Text = "frmOrderStockCreation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderStockCreation_FormClosing);
            this.Load += new System.EventHandler(this.frmOrderStockCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fOSDataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fOSidlabel;
        private System.Windows.Forms.Button fOSupdateBtn;
        private System.Windows.Forms.Button fOSCancelBtn;
        private System.Windows.Forms.Button fOSconfirmBtn;
        private System.Windows.Forms.Button fOSbackBtn;
        private System.Windows.Forms.DataGridView fOSDataGridview;
        private System.Windows.Forms.TextBox fOStB1;
        private System.Windows.Forms.Label fOSupdatelabel;
    }
}