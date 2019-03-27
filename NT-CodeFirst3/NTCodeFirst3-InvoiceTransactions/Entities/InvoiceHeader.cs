using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTCodeFirst3_InvoiceTransactions.Entities
{
    public class InvoiceHeader
    {   //InvoiceHeaders tablosu ve kolonları için InvoiceHeader classı ve propertyleri
        public InvoiceHeader()
        {
            this.invoiceDetails = new HashSet<InvoiceDetail>();
            this.InvoiceDate = DateTime.Now;
        }
        [Key]
        public int InvoiceID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int DeliveryNote { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer customers { get; set; }
        public virtual ICollection<InvoiceDetail> invoiceDetails { get; set; }
    }
}
