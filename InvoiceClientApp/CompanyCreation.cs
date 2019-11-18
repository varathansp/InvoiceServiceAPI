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
    public partial class CompanyCreation : Form
    {
        public CompanyCreation()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49193/");
            client.DefaultRequestHeaders.Accept.Clear();
            var data = new { companyName = textName.Text, companyAddress = textAddress.Text };
            HttpResponseMessage response = await client.PostAsJsonAsync("api/Invoice/CreateCompany", data);
            if (response.IsSuccessStatusCode)
            {
                // Get the URI of the created resource.
                MessageBox.Show("Company ID is "+ await response.Content.ReadAsStringAsync());
            }
        }
    }
}
