namespace InvoiceClientApp
{
    partial class Home
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
            this.btnInvoiceCreation = new System.Windows.Forms.Button();
            this.btnCompanyCreation = new System.Windows.Forms.Button();
            this.btnGetInvoice = new System.Windows.Forms.Button();
            this.btnGetCompanyInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInvoiceCreation
            // 
            this.btnInvoiceCreation.Location = new System.Drawing.Point(78, 148);
            this.btnInvoiceCreation.Name = "btnInvoiceCreation";
            this.btnInvoiceCreation.Size = new System.Drawing.Size(118, 23);
            this.btnInvoiceCreation.TabIndex = 0;
            this.btnInvoiceCreation.Text = "Invoice Creation";
            this.btnInvoiceCreation.UseVisualStyleBackColor = true;
            this.btnInvoiceCreation.Click += new System.EventHandler(this.btnInvoiceCreation_Click);
            // 
            // btnCompanyCreation
            // 
            this.btnCompanyCreation.Location = new System.Drawing.Point(78, 58);
            this.btnCompanyCreation.Name = "btnCompanyCreation";
            this.btnCompanyCreation.Size = new System.Drawing.Size(118, 23);
            this.btnCompanyCreation.TabIndex = 1;
            this.btnCompanyCreation.Text = "Company Creation";
            this.btnCompanyCreation.UseVisualStyleBackColor = true;
            this.btnCompanyCreation.Click += new System.EventHandler(this.btnCompanyCreation_Click);
            // 
            // btnGetInvoice
            // 
            this.btnGetInvoice.Location = new System.Drawing.Point(240, 58);
            this.btnGetInvoice.Name = "btnGetInvoice";
            this.btnGetInvoice.Size = new System.Drawing.Size(115, 23);
            this.btnGetInvoice.TabIndex = 2;
            this.btnGetInvoice.Text = "Get Invoice";
            this.btnGetInvoice.UseVisualStyleBackColor = true;
            this.btnGetInvoice.Click += new System.EventHandler(this.btnGetInvoice_Click);
            // 
            // btnGetCompanyInvoice
            // 
            this.btnGetCompanyInvoice.Location = new System.Drawing.Point(240, 148);
            this.btnGetCompanyInvoice.Name = "btnGetCompanyInvoice";
            this.btnGetCompanyInvoice.Size = new System.Drawing.Size(115, 23);
            this.btnGetCompanyInvoice.TabIndex = 3;
            this.btnGetCompanyInvoice.Text = "Get Company Ivoice";
            this.btnGetCompanyInvoice.UseVisualStyleBackColor = true;
            this.btnGetCompanyInvoice.Click += new System.EventHandler(this.btnGetCompanyInvoice_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 253);
            this.Controls.Add(this.btnGetCompanyInvoice);
            this.Controls.Add(this.btnGetInvoice);
            this.Controls.Add(this.btnCompanyCreation);
            this.Controls.Add(this.btnInvoiceCreation);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInvoiceCreation;
        private System.Windows.Forms.Button btnCompanyCreation;
        private System.Windows.Forms.Button btnGetInvoice;
        private System.Windows.Forms.Button btnGetCompanyInvoice;
    }
}

