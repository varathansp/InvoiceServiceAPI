using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceServiceAPI.Models
{
    public class IInvoice
    {
        public int companyID { get; set; }
        public string customerID { get; set; }
        public string shippingAddress { get; set; }
    }
}