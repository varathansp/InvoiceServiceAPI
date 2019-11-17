using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InvoiceServiceAPI.Models;

namespace InvoiceServiceAPI.Controllers
{
    public class InvoiceController : ApiController
    {
        [AcceptVerbs("GET")]
        public string Get()
        {
            return "Hitting API";
        }
        // GET api/Invoice/companyId
        [AcceptVerbs("GET")]
       
        public IEnumerable<InvoiceInfo> GetCompanyInvoice(int id)
        {
            using (InvoiceDBEntities invoiceDBEntities = new InvoiceDBEntities())
            {
                invoiceDBEntities.Configuration.ProxyCreationEnabled = false;
               return invoiceDBEntities.InvoiceInfoes.Where(x=>x.CompanyID== id).ToList();
                
            }
        }


        // GET api/Invoice/invoiceId
   
        [AcceptVerbs("GET")]
        public InvoiceInfo GetInvoiceInfo(string id)
        {
            using (InvoiceDBEntities invoiceDBEntities = new InvoiceDBEntities())
            {
                invoiceDBEntities.Configuration.ProxyCreationEnabled = false;
                return invoiceDBEntities.InvoiceInfoes.Where(x => x.InvoiceID == id).SingleOrDefault();
            }
        }

        // POST api/values
        [HttpPost]
        [ActionName("CreateCompany")]
        public int CreateCompany([FromBody]ICompany company)
        {
            using (InvoiceDBEntities invoiceDBEntities = new InvoiceDBEntities())
            {
                ObjectParameter outParam = new ObjectParameter("newid", typeof(int));
                 invoiceDBEntities.CreateCompany(company.companyname, company.companyAddress, outParam);
                return (int)outParam.Value;
            }
                
        }
        [HttpPut]
        [ActionName("CreateInvoice")]
        public string CreateInvoice([FromBody]IInvoice invoice)
        {
            using (InvoiceDBEntities invoiceDBEntities = new InvoiceDBEntities())
            {
                ObjectParameter outParam = new ObjectParameter("newid", typeof(string));
                invoiceDBEntities.CreateInvoice(invoice.companyID, invoice.customerID, invoice.shippingAddress, outParam);
                return (string)outParam.Value;
            }

        }

    }
}
