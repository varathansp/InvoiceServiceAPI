namespace InvoiceClientApp
{
    partial class InvoiceCreation
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
            this.btnInvoiceCreate = new System.Windows.Forms.Button();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shipping Address";
            // 
            // btnInvoiceCreate
            // 
            this.btnInvoiceCreate.Location = new System.Drawing.Point(201, 222);
            this.btnInvoiceCreate.Name = "btnInvoiceCreate";
            this.btnInvoiceCreate.Size = new System.Drawing.Size(133, 23);
            this.btnInvoiceCreate.TabIndex = 3;
            this.btnInvoiceCreate.Text = "Create";
            this.btnInvoiceCreate.UseVisualStyleBackColor = true;
            this.btnInvoiceCreate.Click += new System.EventHandler(this.btnInvoiceCreate_Click);
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(201, 168);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(133, 20);
            this.textAddress.TabIndex = 4;
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(201, 102);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(133, 20);
            this.textCustomerID.TabIndex = 5;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(201, 40);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(133, 20);
            this.textID.TabIndex = 6;
            // 
            // InvoiceCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 287);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textCustomerID);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.btnInvoiceCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceCreation";
            this.Text = "InvoiceCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInvoiceCreate;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.TextBox textID;
    }
}