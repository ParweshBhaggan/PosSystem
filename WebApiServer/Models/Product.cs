namespace WebApiServer.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public decimal Cost { get; set; }
        public decimal SalePriceBeforeTax { get; set; }
        public decimal Tax { get; set; }
        public decimal SalePrice { get; set; } //calculated with tax
        public int UnitOfMeasure { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Quantity { get; set; }

    }

  
}
