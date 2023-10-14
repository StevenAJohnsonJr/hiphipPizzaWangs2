

using hiphopPizzaWangs2.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace hiphipPizzaWangs2.Models
{
    public class Order
    {
        public int? Id { get; set; }
        public int? OrderId { get; set; }
        public string? CustomerName { get; set; }
        public int? PaymentsId { get; set; }
        public DateTime? OrderDate { get; set; }
        [NotMapped]
        public string OrderDateFormatted => OrderDate?.ToShortDateString();
        public string? OrderStatus { get; set; }
        public double? TotalRev { get; set; }
        public double OrderPrice { get; set; }
        public double? Tip { get; set; }
        public bool? Like { get; set; }
        public List<Item>? Item { get; set; }
        public User? User { get; set; }
        public Payment? Payment { get; set; }
    }
}
