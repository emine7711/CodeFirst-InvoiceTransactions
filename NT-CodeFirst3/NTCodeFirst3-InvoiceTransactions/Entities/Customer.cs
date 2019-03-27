using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTCodeFirst3_InvoiceTransactions.Entities
{   //Customers tablosu ve kolonları için Customer classı ve propertyleri
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public int CountyID { get; set; }
        public virtual County counties { get; set; }

    }
}
