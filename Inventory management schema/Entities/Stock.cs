namespace Inventory_management_schema.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int AmountProduct { get; set; }

        public List<Products> Products { get; set; }



    }
}
