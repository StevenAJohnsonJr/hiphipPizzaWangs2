using hiphipPizzaWangs2.Models;
using hiphopPizzaWangs2.Models;

namespace hiphopPizzaWangs2.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int OrderId { get; set; }
        public List<Order> Order { get; set; }

    }
}