using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceClientApp
{
    class IInvoice
    {
        public int CompanyID { get; set; }
        public string InvoiceID { get; set; }
        public int DateID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string CustomerID { get; set; }
        public string ShippingAddress { get; set; }
    }
}
