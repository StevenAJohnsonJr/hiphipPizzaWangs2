

using hiphopPizzaWangs2.Models;

namespace hiphipPizzaWangs2.Models
{
    public class Order
    {
        public int? Id { get; set; }
        public int? OrderId { get; set; }
        public string? CustomerName { get; set; }
        public int? PaymentsId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? OrderStatus { get; set; }
        public string? TotalRev { get; set; }
        public int? Tip { get; set; }
        public bool? Like { get; set; }
        public List<Item>? Item { get; set; }
        public User? User { get; set; }
        public Payment? Payment { get; set; }
    }
}
