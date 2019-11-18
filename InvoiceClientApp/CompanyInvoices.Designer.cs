namespace InvoiceClientApp
{
    partial class CompanyInvoices
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
            this.textID = new System.Windows.Forms.TextBox();
            this.btnGetInvoices = new System.Windows.Forms.Button();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(191, 25);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 1;
            // 
            // btnGetInvoices
            // 
            this.btnGetInvoices.Location = new System.Drawing.Point(350, 23);
            this.btnGetInvoices.Name = "btnGetInvoices";
            this.btnGetInvoices.Size = new System.Drawing.Size(75, 23);
            this.btnGetInvoices.TabIndex = 2;
            this.btnGetInvoices.Text = "Get Invoices";
            this.btnGetInvoices.UseVisualStyleBackColor = true;
            this.btnGetInvoices.Click += new System.EventHandler(this.btnGetInvoices_Click);
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(77, 80);
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.Size = new System.Drawing.Size(556, 228);
            this.dataGridViewInvoices.TabIndex = 3;
            // 
            // CompanyInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 336);
            this.Controls.Add(this.dataGridViewInvoices);
            this.Controls.Add(this.btnGetInvoices);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Name = "CompanyInvoices";
            this.Text = "CompanyInvoices";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button btnGetInvoices;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
    }
}