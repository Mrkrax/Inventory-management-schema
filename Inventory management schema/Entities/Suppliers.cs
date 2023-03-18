namespace Inventory_management_schema.Entities
{
    public class Suppliers
    {
        public int Id { get; set; }
        public string NameSuppliers { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Products> Products { get; set; }
       

    }
}
