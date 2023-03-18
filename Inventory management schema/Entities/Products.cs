namespace Inventory_management_schema.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string NameProducts { get; set; }
        public int HowMany { get; set; }
        public int Price { get; set; }

        public int SuppliersId { get; set; }
        public Suppliers Suppliers { get; set; }

        public int OrdersId {get;set;}
        public Orders Orders { get; set; }

        public int StockId { get; set; }
        public Stock Stock { get; set; }
}
}

