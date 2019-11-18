using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceClientApp
{
    public partial class InvoiceCreation : Form
    {
        public InvoiceCreation()
        {
            InitializeComponent();
        }

        private async void btnInvoiceCreate_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49193/");
            client.DefaultRequestHeaders.Accept.Clear();
            var data = new { companyID = textID.Text,customerID=textCustomerID.Text, shippingAddress = textAddress.Text };
            HttpResponseMessage response = await client.PutAsJsonAsync("api/Invoice/CreateInvoice", data);
            if (response.IsSuccessStatusCode)
            {
                // Get the URI of the created resource.
                MessageBox.Show("Invoice ID is " + await response.Content.ReadAsStringAsync());
            }
        }
    }
}
