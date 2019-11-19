using Newtonsoft.Json;
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
    public partial class GetInvoice : Form
    {
        public GetInvoice()
        {
            InitializeComponent();
        }

        private async void btnGetInvoice_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49193/");
            client.DefaultRequestHeaders.Accept.Clear();
            //var data = new { id =textID.Text};
            HttpResponseMessage response = await client.GetAsync("api/Invoice/GetInvoiceInfo/" + textID.Text);
            if (response.IsSuccessStatusCode)
            {
                // Get the URI of the created resource.
                string result=await response.Content.ReadAsStringAsync();
                IInvoice businessunits = JsonConvert.DeserializeObject<IInvoice>(result);
                lblCompanyID.Text = businessunits.CompanyID.ToString();
                lblCustomerID.Text = businessunits.CustomerID;
                lblDate.Text = businessunits.InvoiceDate.ToString();
                lblAddress.Text = businessunits.ShippingAddress;
            }
        }
    }
}
