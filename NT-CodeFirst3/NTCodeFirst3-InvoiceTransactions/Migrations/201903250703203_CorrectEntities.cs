namespace NTCodeFirst3_InvoiceTransactions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectEntities : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.InvoiceDetails", "ProductID");
            AddForeignKey("dbo.InvoiceDetails", "ProductID", "dbo.Products", "ProductID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceDetails", "ProductID", "dbo.Products");
            DropIndex("dbo.InvoiceDetails", new[] { "ProductID" });
        }
    }
}
// <add name="INVOICECONTEXT" connectionString="data source=.;initial catalog=INVOICECONTEXT;UID=wissen;PWD=456789;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />