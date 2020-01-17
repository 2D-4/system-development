namespace habigisu
{
    partial class frmMain
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
            this.lblfMeid = new System.Windows.Forms.Label();
            this.lblfMAssigneid = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnOderStock = new System.Windows.Forms.Button();
            this.btnShipping = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnPassChange = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfMeid
            // 
            this.lblfMeid.AutoSize = true;
            this.lblfMeid.Location = new System.Drawing.Point(653, 9);
            this.lblfMeid.Name = "lblfMeid";
            this.lblfMeid.Size = new System.Drawing.Size(59, 15);
            this.lblfMeid.TabIndex = 0;
            this.lblfMeid.Text = "社員ID：";
            // 
            // lblfMAssigneid
            // 
            this.lblfMAssigneid.AutoSize = true;
            this.lblfMAssigneid.Location = new System.Drawing.Point(718, 9);
            this.lblfMAssigneid.Name = "lblfMAssigneid";
            this.lblfMAssigneid.Size = new System.Drawing.Size(55, 15);
            this.lblfMAssigneid.TabIndex = 1;
            this.lblfMAssigneid.Text = "000000";
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(156, 28);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(207, 69);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "商品管理";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(422, 28);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(207, 69);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "注文管理";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnOderStock
            // 
            this.btnOderStock.Location = new System.Drawing.Point(156, 137);
            this.btnOderStock.Name = "btnOderStock";
            this.btnOderStock.Size = new System.Drawing.Size(207, 69);
            this.btnOderStock.TabIndex = 4;
            this.btnOderStock.Text = "発注管理";
            this.btnOderStock.UseVisualStyleBackColor = true;
            this.btnOderStock.Click += new System.EventHandler(this.btnOderStock_Click);
            // 
            // btnShipping
            // 
            this.btnShipping.Location = new System.Drawing.Point(422, 137);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(207, 69);
            this.btnShipping.TabIndex = 5;
            this.btnShipping.Text = "出庫管理";
            this.btnShipping.UseVisualStyleBackColor = true;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(156, 241);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(207, 69);
            this.btnSales.TabIndex = 6;
            this.btnSales.Text = "売上管理";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(422, 241);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(207, 69);
            this.btnClient.TabIndex = 7;
            this.btnClient.Text = "顧客管理";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnPassChange
            // 
            this.btnPassChange.Location = new System.Drawing.Point(156, 345);
            this.btnPassChange.Name = "btnPassChange";
            this.btnPassChange.Size = new System.Drawing.Size(207, 69);
            this.btnPassChange.TabIndex = 8;
            this.btnPassChange.Text = "パスワード変更";
            this.btnPassChange.UseVisualStyleBackColor = true;
            this.btnPassChange.Click += new System.EventHandler(this.btnPassChange_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(581, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 63);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "終了";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPassChange);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnShipping);
            this.Controls.Add(this.btnOderStock);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.lblfMAssigneid);
            this.Controls.Add(this.lblfMeid);
            this.Name = "frmMain";
            this.Text = "ホーム画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfMeid;
        private System.Windows.Forms.Label lblfMAssigneid;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnOderStock;
        private System.Windows.Forms.Button btnShipping;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnPassChange;
        private System.Windows.Forms.Button btnExit;
    }
}