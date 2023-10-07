using hiphipPizzaWangs2.Models;
using hiphopPizzaWangs2.Models;

namespace hiphopPizzaWangs2.Models
{
    public class Payment
    {
        public int? Id { get; set; }
        public string? PaymentMethod { get; set; }
        public List<Order> Order { get; set; }
    }
}