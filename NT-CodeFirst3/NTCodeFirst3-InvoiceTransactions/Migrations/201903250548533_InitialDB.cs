namespace NTCodeFirst3_InvoiceTransactions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CityID);
            
            CreateTable(
                "dbo.Counties",
                c => new
                    {
                        CountyID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CountyID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .Index(t => t.CityID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Address = c.String(),
                        CountyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.Counties", t => t.CountyID, cascadeDelete: true)
                .Index(t => t.CountyID);
            
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VATAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AmountWithVAT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => new { t.InvoiceID, t.ProductID })
                .ForeignKey("dbo.InvoiceHeaders", t => t.InvoiceID, cascadeDelete: true)
                .Index(t => t.InvoiceID);
            
            CreateTable(
                "dbo.InvoiceHeaders",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        InvoiceDate = c.DateTime(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeliveryNote = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductCode = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Units", t => t.UnitID, cascadeDelete: true)
                .Index(t => t.UnitID);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        UnitID = c.Int(nullable: false, identity: true),
                        UnitName = c.String(),
                    })
                .PrimaryKey(t => t.UnitID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "UnitID", "dbo.Units");
            DropForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.InvoiceHeaders");
            DropForeignKey("dbo.InvoiceHeaders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Customers", "CountyID", "dbo.Counties");
            DropForeignKey("dbo.Counties", "CityID", "dbo.Cities");
            DropIndex("dbo.Products", new[] { "UnitID" });
            DropIndex("dbo.InvoiceHeaders", new[] { "CustomerID" });
            DropIndex("dbo.InvoiceDetails", new[] { "InvoiceID" });
            DropIndex("dbo.Customers", new[] { "CountyID" });
            DropIndex("dbo.Counties", new[] { "CityID" });
            DropTable("dbo.Units");
            DropTable("dbo.Products");
            DropTable("dbo.InvoiceHeaders");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.Customers");
            DropTable("dbo.Counties");
            DropTable("dbo.Cities");
        }
    }
}
