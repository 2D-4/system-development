namespace habigisu
{
    partial class frmOrderCreation
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
            this.fOCDataGridView = new System.Windows.Forms.DataGridView();
            this.fOCBackBtn = new System.Windows.Forms.Button();
            this.fOCSaveBtn = new System.Windows.Forms.Button();
            this.fOCDeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fOCDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "注文内容一覧";
            // 
            // fOCDataGridView
            // 
            this.fOCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fOCDataGridView.Location = new System.Drawing.Point(1, 52);
            this.fOCDataGridView.Name = "fOCDataGridView";
            this.fOCDataGridView.RowTemplate.Height = 24;
            this.fOCDataGridView.Size = new System.Drawing.Size(795, 357);
            this.fOCDataGridView.TabIndex = 1;
            // 
            // fOCBackBtn
            // 
            this.fOCBackBtn.Location = new System.Drawing.Point(697, 415);
            this.fOCBackBtn.Name = "fOCBackBtn";
            this.fOCBackBtn.Size = new System.Drawing.Size(99, 32);
            this.fOCBackBtn.TabIndex = 2;
            this.fOCBackBtn.Text = "戻る";
            this.fOCBackBtn.UseVisualStyleBackColor = true;
            this.fOCBackBtn.Click += new System.EventHandler(this.fOCBackBtn_Click);
            // 
            // fOCSaveBtn
            // 
            this.fOCSaveBtn.Location = new System.Drawing.Point(586, 415);
            this.fOCSaveBtn.Name = "fOCSaveBtn";
            this.fOCSaveBtn.Size = new System.Drawing.Size(105, 32);
            this.fOCSaveBtn.TabIndex = 3;
            this.fOCSaveBtn.Text = "保存";
            this.fOCSaveBtn.UseVisualStyleBackColor = true;
            this.fOCSaveBtn.Click += new System.EventHandler(this.fOCSaveBtn_Click);
            // 
            // fOCDeleteBtn
            // 
            this.fOCDeleteBtn.Location = new System.Drawing.Point(1, 415);
            this.fOCDeleteBtn.Name = "fOCDeleteBtn";
            this.fOCDeleteBtn.Size = new System.Drawing.Size(103, 32);
            this.fOCDeleteBtn.TabIndex = 4;
            this.fOCDeleteBtn.Text = "取り消し";
            this.fOCDeleteBtn.UseVisualStyleBackColor = true;
            this.fOCDeleteBtn.Click += new System.EventHandler(this.fOCDeleteBtn_Click);
            // 
            // frmOrderCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fOCDeleteBtn);
            this.Controls.Add(this.fOCSaveBtn);
            this.Controls.Add(this.fOCBackBtn);
            this.Controls.Add(this.fOCDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "frmOrderCreation";
            this.Text = "注文書作成画面";
            this.Load += new System.EventHandler(this.frmOrderCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fOCDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView fOCDataGridView;
        private System.Windows.Forms.Button fOCBackBtn;
        private System.Windows.Forms.Button fOCSaveBtn;
        private System.Windows.Forms.Button fOCDeleteBtn;
    }
}