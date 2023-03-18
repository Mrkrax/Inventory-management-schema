namespace Inventory_management_schema.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public string NameOrders { get; set; }
        public DateTime DateOrders { get; set; }
        public int Amount { get; set; }

        public List<Products> Products { get; set; }

    }
}
