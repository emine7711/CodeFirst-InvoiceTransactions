using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTCodeFirst3_InvoiceTransactions.Entities
{   //Products tablosu ve kolonları için Product classı ve propertyleri
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitID { get; set; }
        public virtual Unit units { get; set; }
        public virtual ICollection<InvoiceDetail> invoiceDetails { get; set; }
    }
}
