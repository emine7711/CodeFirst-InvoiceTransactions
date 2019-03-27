using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTCodeFirst3_InvoiceTransactions.Entities
{   //InvoiceDetails tablosu ve kolonları için InvoiceDetail classı ve propertyleri data annotation verilerek tanımlandı
    public class InvoiceDetail
    {
        [Key]
        [Column(Order=0)]
        public int InvoiceID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal VATAmount { get; set; }
        public decimal AmountWithVAT { get; set; }
        public string Description { get; set; }

        public virtual Product products { get; set; }
        public virtual InvoiceHeader invoiceHeaders { get; set; }
    }
}
