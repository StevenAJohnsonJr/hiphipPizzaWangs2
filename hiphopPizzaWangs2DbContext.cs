using hiphipPizzaWangs2.Models;
using hiphopPizzaWangs2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace hiphipPizzaWangs2
{
    public class hiphopPizzaWangs2DbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Item>? Items { get; set; }
        public DbSet<Payment>? Payments { get; set; }

        public hiphopPizzaWangs2DbContext(DbContextOptions<hiphopPizzaWangs2DbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User {Id = 1, Uid = "ZjnYscBnyAOQCwSCi1NWLYjo6bs1", FirstName = "Trent", LastName = "Jones", OrderId = 1, PhoneNumber = "6157523654", Email = "jones@jones.com" },
                new User{Id = 2,  Uid = "UniqueUidForJohn", FirstName = "John", LastName = "James", OrderId = 2, PhoneNumber = "6157548796", Email = "jj123@nss.com" },
                new User{ Id = 3, Uid = "UniqueUidForSam", FirstName = "Sam", LastName = "Tronset", OrderId = 3, PhoneNumber = "8132547486", Email = "stron234@makeit.com" },
                new User {Id = 4 , Uid = "UniqueUidForSusan", FirstName = "Susan", LastName = "McJohnny", OrderId = 4, PhoneNumber = "2154526341", Email = "helpfulsusan9541@chsarp.com" },
                new User {Id = 5, Uid = "UniqueUidForBobby", FirstName = "Bobby", LastName = "Castle", OrderId = 5, PhoneNumber = "9872154897", Email = "bobk1ngs@betdes.com" }
            });

            modelBuilder.Entity<Item>().HasData(new Item[]
            {
                new Item {Id = 1, ItemName = "Small 1 Topping Pizza", Price = 10.99, OrderId = 1, ItemDescription = "Choose any one topping to add to your already tasty pizza, and breadsticks on us!!"},
                new Item {Id = 2, ItemName = "Small 2 Topping Pizza", Price = 13.99, OrderId = 2, ItemDescription = "Choose any two toppings to add to your already tasty pizza, and breadsticks on us!!"},
                new Item {Id = 3, ItemName = "Medium 1 Topping Pizza", Price = 12.99, OrderId = 3, ItemDescription = "Choose any one topping to add to your alreday tasty pizza, and breadsticks on us!!" },
                new Item { Id = 4, ItemName = "Medium 2 Topping Pizza", Price = 15.99, OrderId = 4, ItemDescription = "Choose any two topping to add to your alreday tasty pizza, and breadsticks on us!!" },
                new Item { Id = 5, ItemName = "Large 1 Topping Pizza", Price = 14.99, OrderId = 5, ItemDescription = "Choose any one topping to add to your alreday tasty pizza, and breadsticks on us!!" },
                new Item { Id = 6, ItemName = "Large 2 Topping Pizza", Price = 17.99, OrderId = 6, ItemDescription = "Choose any two topping to add to your alreday tasty pizza, and breadsticks on us!!" },
                new Item { Id = 7, ItemName = "Medium Specialty Pizza", Price = 16.99, OrderId = 7, ItemDescription = "Specialty pizzas are specally made from us to you.  So tell us what to put on it and we will put IT on you! Added bonus breadsticks on us!!" },
                new Item { Id = 8, ItemName = "Large Specialty Pizza", Price = 18.99, OrderId = 8, ItemDescription = "Specialty pizzas are specally made from us to you.  So tell us what to put on it and we will put IT on you! Added bonus breadsticks on us!!" },
                new Item { Id = 9, ItemName = "6p Wing ", Price = 7.99, OrderId = 9, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!" },
                new Item {Id = 10, ItemName = "7p Wing ", Price = 8.99, OrderId = 10, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!" },
                new Item { Id = 11, ItemName = "8p Wing ", Price = 9.99, OrderId = 11, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!" },
                new Item { Id = 12, ItemName = "10p Wing ", Price = 11.99, OrderId = 12, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!" },
                new Item{ Id = 13, ItemName = "12p Wing ", Price = 13.99, OrderId = 13, ItemDescription= "World class and world famous wings. Choose a flavor and monitor your behavior!!" },
                new Item { Id = 14, ItemName = "14p Wing ", Price = 15.99, OrderId = 14, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!" },
                new Item { Id = 15, ItemName = "16p Wing ", Price = 17.99, OrderId = 15, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!" },
                new Item { Id = 16, ItemName = "6p Wing Combo ", Price = 10.99, OrderId = 16, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!" },
                new Item { Id = 17, ItemName = "8p Wing Combo ", Price = 11.99, OrderId = 17, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!" },
                new Item { Id = 18, ItemName = "10p Wing Combo ", Price = 13.99, OrderId = 18, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!" },
                new Item { Id = 19, ItemName = "12p Wing Combo ", Price = 13.99, OrderId = 19, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!" },
                new Item { Id = 20, ItemName = "14p Wing Combo ", Price = 17.99, OrderId = 20, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!" },
                new Item { Id = 21, ItemName = "16p Wing Combo ", Price = 19.99, OrderId = 21, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!" },
                new Item { Id = 22, ItemName = "50p Wing Platter ", Price = 45.99, OrderId = 22, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  Platter dont matter!!" },
                new Item { Id = 23, ItemName = "100p Wing Combo ", Price = 85.99, OrderId = 23, ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  Platter dont matter!!" },            });

            modelBuilder.Entity<Order>().HasData(new Order[]
            {
                new Order {Id = 1, OrderId = 15, OrderPrice = 11.99, CustomerName = "Hungry Mann", OrderDate = new DateTime(2023, 6, 28), OrderStatus = "Pending", Tip = 3, PaymentsId = 1, TotalRev = 20.99, Like = true  },
                new Order {Id = 2, OrderId = 22, OrderPrice = 45.99, CustomerName = "Shorty Duwop", OrderDate = new DateTime(2023, 9, 08), OrderStatus = "Pending", Tip = 5, PaymentsId = 3, TotalRev = 90.99, Like = true  },
                new Order {Id = 3, OrderId = 8, OrderPrice = 18.99, CustomerName = "Sherry Lovington", OrderDate = new DateTime(2023, 2, 14), OrderStatus = "In-Progress", Tip = 2, PaymentsId = 4, TotalRev = 20.99, Like = true  },
                new Order {Id = 4, OrderId = 18, OrderPrice = 13.99, CustomerName = "Starving Joe", OrderDate = new DateTime(2023, 2, 23), OrderStatus = "Completed", Tip = 3, PaymentsId = 5, TotalRev = 16.99, Like = true  },
                new Order {Id = 5, OrderId = 6, OrderPrice = 17.99, CustomerName = "Feed MeNow", OrderDate = new DateTime(2023, 10, 2), OrderStatus = "Pending", Tip = 3, PaymentsId = 2, TotalRev = 20.99, Like = true  },
            });

            modelBuilder.Entity<Payment>().HasData(new Payment[]
            {
                new Payment {Id = 1, PaymentMethod = "Visa",},
                new Payment {Id = 2, PaymentMethod = "MasterCard",},
                new Payment {Id = 3, PaymentMethod = "Discover Card",},
                new Payment {Id = 4, PaymentMethod = "PayPal",},
                new Payment {Id = 5, PaymentMethod = "ApplePay",}
            });
        }
    }
}





