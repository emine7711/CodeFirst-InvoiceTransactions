namespace NTCodeFirst3_InvoiceTransactions
{
    using NTCodeFirst3_InvoiceTransactions.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class INVOICECONTEXT : DbContext
    {
        public INVOICECONTEXT()
            : base("name=INVOICECONTEXT")
        {
        }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<InvoiceHeader> InvoiceHeaders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
    }
}