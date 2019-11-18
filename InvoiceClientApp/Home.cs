using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceClientApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnCompanyCreation_Click(object sender, EventArgs e)
        {
            CompanyCreation companyCreation = new CompanyCreation();
            companyCreation.Show();
        }

        private void btnInvoiceCreation_Click(object sender, EventArgs e)
        {
            InvoiceCreation invoiceCreation = new InvoiceCreation();
            invoiceCreation.Show();
        }

        private void btnGetInvoice_Click(object sender, EventArgs e)
        {
            GetInvoice getInvoice = new GetInvoice();
            getInvoice.Show();
        }

        private void btnGetCompanyInvoice_Click(object sender, EventArgs e)
        {
            CompanyInvoices companyInvoices = new CompanyInvoices();
            companyInvoices.Show();
        }
    }
}
