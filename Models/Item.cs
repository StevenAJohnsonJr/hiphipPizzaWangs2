using hiphopPizzaWangs2.Models;

namespace hiphipPizzaWangs2.Models
{
    public class Item
    {
        public int? Id { get; set; }
        public string? ItemName { get; set; }
        public string? ItemDescription { get; set; }
        public string? Price { get; set; }
        public int? OrderId { get; set; }
        public List<Order> Order { get; set; }
    }
}
