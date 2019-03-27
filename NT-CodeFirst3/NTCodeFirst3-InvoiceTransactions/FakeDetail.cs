namespace NTCodeFirst3_InvoiceTransactions
{
    //Fatura Detayları kesinleşmeden önce görüp düzenleyebilmek için Invoice Detail tablosundaki kullanacağımız verilerle FakeDetail classını oluşturduk ve propertylerini tanımladık.
    internal class FakeDetail
    {
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal VATAmount { get; set; }
        public decimal AmountWithVAT { get; set; }
        public string Description { get; set; }
        public decimal TotalAmount { get; internal set; }
    }
}