﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using hiphipPizzaWangs2;

#nullable disable

namespace hiphipPizzaWangs2.Migrations
{
    [DbContext(typeof(hiphopPizzaWangs2DbContext))]
    [Migration("20231007022902_3rdCreate")]
    partial class _3rdCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("hiphipPizzaWangs2.Models.Item", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("ItemDescription")
                        .HasColumnType("text");

                    b.Property<string>("ItemName")
                        .HasColumnType("text");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<string>("Price")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemDescription = "Choose any one topping to add to your already tasty pizza, and breadsticks on us!!",
                            ItemName = "Small 1 Topping Pizza",
                            OrderId = 1,
                            Price = "10.99"
                        },
                        new
                        {
                            Id = 2,
                            ItemDescription = "Choose any two toppings to add to your already tasty pizza, and breadsticks on us!!",
                            ItemName = "Small 2 Topping Pizza",
                            OrderId = 2,
                            Price = "13.99"
                        },
                        new
                        {
                            Id = 3,
                            ItemDescription = "Choose any one topping to add to your alreday tasty pizza, and breadsticks on us!!",
                            ItemName = "Medium 1 Topping Pizza",
                            OrderId = 3,
                            Price = "12.99"
                        },
                        new
                        {
                            Id = 4,
                            ItemDescription = "Choose any two topping to add to your alreday tasty pizza, and breadsticks on us!!",
                            ItemName = "Medium 2 Topping Pizza",
                            OrderId = 4,
                            Price = "15.99"
                        },
                        new
                        {
                            Id = 5,
                            ItemDescription = "Choose any one topping to add to your alreday tasty pizza, and breadsticks on us!!",
                            ItemName = "Large 1 Topping Pizza",
                            OrderId = 5,
                            Price = "14.99"
                        },
                        new
                        {
                            Id = 6,
                            ItemDescription = "Choose any two topping to add to your alreday tasty pizza, and breadsticks on us!!",
                            ItemName = "Large 2 Topping Pizza",
                            OrderId = 6,
                            Price = "17.99"
                        },
                        new
                        {
                            Id = 7,
                            ItemDescription = "Specialty pizzas are specally made from us to you.  So tell us what to put on it and we will put IT on you! Added bonus breadsticks on us!!",
                            ItemName = "Medium Specialty Pizza",
                            OrderId = 7,
                            Price = "16.99"
                        },
                        new
                        {
                            Id = 8,
                            ItemDescription = "Specialty pizzas are specally made from us to you.  So tell us what to put on it and we will put IT on you! Added bonus breadsticks on us!!",
                            ItemName = "Large Specialty Pizza",
                            OrderId = 8,
                            Price = "18.99"
                        },
                        new
                        {
                            Id = 9,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!",
                            ItemName = "6p Wing ",
                            OrderId = 9,
                            Price = "7.99"
                        },
                        new
                        {
                            Id = 10,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!",
                            ItemName = "7p Wing ",
                            OrderId = 10,
                            Price = "8.99"
                        },
                        new
                        {
                            Id = 11,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!",
                            ItemName = "8p Wing ",
                            OrderId = 11,
                            Price = "9.99"
                        },
                        new
                        {
                            Id = 12,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!",
                            ItemName = "10p Wing ",
                            OrderId = 12,
                            Price = "11.99"
                        },
                        new
                        {
                            Id = 13,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!",
                            ItemName = "12p Wing ",
                            OrderId = 13,
                            Price = "13.99"
                        },
                        new
                        {
                            Id = 14,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!",
                            ItemName = "14p Wing ",
                            OrderId = 14,
                            Price = "15.99"
                        },
                        new
                        {
                            Id = 15,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior!!",
                            ItemName = "16p Wing ",
                            OrderId = 15,
                            Price = "17.99"
                        },
                        new
                        {
                            Id = 16,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!",
                            ItemName = "6p Wing Combo ",
                            OrderId = 16,
                            Price = "10.99"
                        },
                        new
                        {
                            Id = 17,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!",
                            ItemName = "8p Wing Combo ",
                            OrderId = 17,
                            Price = "11.99"
                        },
                        new
                        {
                            Id = 18,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!",
                            ItemName = "10p Wing Combo ",
                            OrderId = 18,
                            Price = "13.99"
                        },
                        new
                        {
                            Id = 19,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!",
                            ItemName = "12p Wing Combo ",
                            OrderId = 19,
                            Price = "13.99"
                        },
                        new
                        {
                            Id = 20,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!",
                            ItemName = "14p Wing Combo ",
                            OrderId = 20,
                            Price = "17.99"
                        },
                        new
                        {
                            Id = 21,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!",
                            ItemName = "16p Wing Combo ",
                            OrderId = 21,
                            Price = "19.99"
                        },
                        new
                        {
                            Id = 22,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  Platter dont matter!!",
                            ItemName = "50p Wing Platter ",
                            OrderId = 22,
                            Price = "45.99"
                        },
                        new
                        {
                            Id = 23,
                            ItemDescription = "World class and world famous wings. Choose a flavor and monitor your behavior.  Platter dont matter!!",
                            ItemName = "100p Wing Combo ",
                            OrderId = 23,
                            Price = "85.99"
                        });
                });

            modelBuilder.Entity("hiphipPizzaWangs2.Models.Order", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("CustomerName")
                        .HasColumnType("text");

                    b.Property<bool?>("Like")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("text");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("integer");

                    b.Property<int?>("PaymentsId")
                        .HasColumnType("integer");

                    b.Property<int?>("Tip")
                        .HasColumnType("integer");

                    b.Property<string>("TotalRev")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerName = "Hungry Mann",
                            Like = true,
                            OrderDate = new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 15,
                            OrderStatus = "Pending",
                            PaymentsId = 1,
                            Tip = 3,
                            TotalRev = "2099"
                        },
                        new
                        {
                            Id = 2,
                            CustomerName = "Shorty Duwop",
                            Like = true,
                            OrderDate = new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 22,
                            OrderStatus = "Pending",
                            PaymentsId = 3,
                            Tip = 5,
                            TotalRev = "9099"
                        },
                        new
                        {
                            Id = 3,
                            CustomerName = "Sherry Lovington",
                            Like = true,
                            OrderDate = new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 8,
                            OrderStatus = "In-Progress",
                            PaymentsId = 4,
                            Tip = 2,
                            TotalRev = "2099"
                        },
                        new
                        {
                            Id = 4,
                            CustomerName = "Starving Joe",
                            Like = true,
                            OrderDate = new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 18,
                            OrderStatus = "Completed",
                            PaymentsId = 5,
                            Tip = 3,
                            TotalRev = "1699"
                        },
                        new
                        {
                            Id = 5,
                            CustomerName = "Feed MeNow",
                            Like = true,
                            OrderDate = new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 6,
                            OrderStatus = "Pending",
                            PaymentsId = 2,
                            Tip = 3,
                            TotalRev = "2099"
                        });
                });

            modelBuilder.Entity("hiphopPizzaWangs2.Models.Payment", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PaymentMethod = "Visa"
                        },
                        new
                        {
                            Id = 2,
                            PaymentMethod = "MasterCard"
                        },
                        new
                        {
                            Id = 3,
                            PaymentMethod = "Discover Card"
                        },
                        new
                        {
                            Id = 4,
                            PaymentMethod = "PayPal"
                        },
                        new
                        {
                            Id = 5,
                            PaymentMethod = "ApplePay"
                        });
                });

            modelBuilder.Entity("hiphopPizzaWangs2.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "ZjnYscBnyAOQCwSCi1NWLYjo6bs1",
                            Email = "jones@jones.com",
                            FirstName = "Trent",
                            LastName = "Jones",
                            OrderId = 1,
                            PhoneNumber = "6157523654"
                        },
                        new
                        {
                            Id = "UniqueUidForJohn",
                            Email = "jj123@nss.com",
                            FirstName = "John",
                            LastName = "James",
                            OrderId = 2,
                            PhoneNumber = "6157548796"
                        },
                        new
                        {
                            Id = "UniqueUidForSam",
                            Email = "stron234@makeit.com",
                            FirstName = "Sam",
                            LastName = "Tronset",
                            OrderId = 3,
                            PhoneNumber = "8132547486"
                        },
                        new
                        {
                            Id = "UniqueUidForSusan",
                            Email = "helpfulsusan9541@chsarp.com",
                            FirstName = "Susan",
                            LastName = "McJohnny",
                            OrderId = 4,
                            PhoneNumber = "2154526341"
                        },
                        new
                        {
                            Id = "UniqueUidForBobby",
                            Email = "bobk1ngs@betdes.com",
                            FirstName = "Bobby",
                            LastName = "Castle",
                            OrderId = 5,
                            PhoneNumber = "9872154897"
                        });
                });

            modelBuilder.Entity("ItemOrder", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.HasKey("ItemId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("ItemOrder");
                });

            modelBuilder.Entity("hiphipPizzaWangs2.Models.Order", b =>
                {
                    b.HasOne("hiphopPizzaWangs2.Models.Payment", "Payment")
                        .WithMany("Order")
                        .HasForeignKey("PaymentId");

                    b.HasOne("hiphopPizzaWangs2.Models.User", "User")
                        .WithMany("Order")
                        .HasForeignKey("UserId");

                    b.Navigation("Payment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ItemOrder", b =>
                {
                    b.HasOne("hiphipPizzaWangs2.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hiphipPizzaWangs2.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("hiphopPizzaWangs2.Models.Payment", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("hiphopPizzaWangs2.Models.User", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
