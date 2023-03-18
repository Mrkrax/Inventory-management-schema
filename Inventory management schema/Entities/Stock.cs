namespace Inventory_management_schema.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public string NameStock { get; set; }
        public List<Products> Products { get; set; }



    }
}
