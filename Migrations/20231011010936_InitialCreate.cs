using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace hiphipPizzaWangs2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemName = table.Column<string>(type: "text", nullable: true),
                    ItemDescription = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: true),
                    OrderId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PaymentMethod = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uid = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: true),
                    CustomerName = table.Column<string>(type: "text", nullable: true),
                    PaymentsId = table.Column<int>(type: "integer", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    OrderStatus = table.Column<string>(type: "text", nullable: true),
                    TotalRev = table.Column<double>(type: "double precision", nullable: true),
                    Tip = table.Column<double>(type: "double precision", nullable: true),
                    Like = table.Column<bool>(type: "boolean", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    PaymentId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemOrder",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOrder", x => new { x.ItemId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_ItemOrder_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemOrder_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ItemDescription", "ItemName", "OrderId", "Price" },
                values: new object[,]
                {
                    { 1, "Choose any one topping to add to your already tasty pizza, and breadsticks on us!!", "Small 1 Topping Pizza", 1, 10.99 },
                    { 2, "Choose any two toppings to add to your already tasty pizza, and breadsticks on us!!", "Small 2 Topping Pizza", 2, 13.99 },
                    { 3, "Choose any one topping to add to your alreday tasty pizza, and breadsticks on us!!", "Medium 1 Topping Pizza", 3, 12.99 },
                    { 4, "Choose any two topping to add to your alreday tasty pizza, and breadsticks on us!!", "Medium 2 Topping Pizza", 4, 15.99 },
                    { 5, "Choose any one topping to add to your alreday tasty pizza, and breadsticks on us!!", "Large 1 Topping Pizza", 5, 14.99 },
                    { 6, "Choose any two topping to add to your alreday tasty pizza, and breadsticks on us!!", "Large 2 Topping Pizza", 6, 17.989999999999998 },
                    { 7, "Specialty pizzas are specally made from us to you.  So tell us what to put on it and we will put IT on you! Added bonus breadsticks on us!!", "Medium Specialty Pizza", 7, 16.989999999999998 },
                    { 8, "Specialty pizzas are specally made from us to you.  So tell us what to put on it and we will put IT on you! Added bonus breadsticks on us!!", "Large Specialty Pizza", 8, 18.989999999999998 },
                    { 9, "World class and world famous wings. Choose a flavor and monitor your behavior!!", "6p Wing ", 9, 7.9900000000000002 },
                    { 10, "World class and world famous wings. Choose a flavor and monitor your behavior!!", "7p Wing ", 10, 8.9900000000000002 },
                    { 11, "World class and world famous wings. Choose a flavor and monitor your behavior!!", "8p Wing ", 11, 9.9900000000000002 },
                    { 12, "World class and world famous wings. Choose a flavor and monitor your behavior!!", "10p Wing ", 12, 11.99 },
                    { 13, "World class and world famous wings. Choose a flavor and monitor your behavior!!", "12p Wing ", 13, 13.99 },
                    { 14, "World class and world famous wings. Choose a flavor and monitor your behavior!!", "14p Wing ", 14, 15.99 },
                    { 15, "World class and world famous wings. Choose a flavor and monitor your behavior!!", "16p Wing ", 15, 17.989999999999998 },
                    { 16, "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!", "6p Wing Combo ", 16, 10.99 },
                    { 17, "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!", "8p Wing Combo ", 17, 11.99 },
                    { 18, "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!", "10p Wing Combo ", 18, 13.99 },
                    { 19, "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!", "12p Wing Combo ", 19, 13.99 },
                    { 20, "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!", "14p Wing Combo ", 20, 17.989999999999998 },
                    { 21, "World class and world famous wings. Choose a flavor and monitor your behavior.  But this time we add homecut fries for you to savor!!", "16p Wing Combo ", 21, 19.989999999999998 },
                    { 22, "World class and world famous wings. Choose a flavor and monitor your behavior.  Platter dont matter!!", "50p Wing Platter ", 22, 45.990000000000002 },
                    { 23, "World class and world famous wings. Choose a flavor and monitor your behavior.  Platter dont matter!!", "100p Wing Combo ", 23, 85.989999999999995 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerName", "Like", "OrderDate", "OrderId", "OrderStatus", "PaymentId", "PaymentsId", "Tip", "TotalRev", "UserId" },
                values: new object[,]
                {
                    { 1, "Hungry Mann", true, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Pending", null, 1, 3.0, 20.989999999999998, null },
                    { 2, "Shorty Duwop", true, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Pending", null, 3, 5.0, 9099.0, null },
                    { 3, "Sherry Lovington", true, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "In-Progress", null, 4, 2.0, 20.989999999999998, null },
                    { 4, "Starving Joe", true, new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Completed", null, 5, 3.0, 16.989999999999998, null },
                    { 5, "Feed MeNow", true, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Pending", null, 2, 3.0, 20.989999999999998, null }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "PaymentMethod" },
                values: new object[,]
                {
                    { 1, "Visa" },
                    { 2, "MasterCard" },
                    { 3, "Discover Card" },
                    { 4, "PayPal" },
                    { 5, "ApplePay" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "OrderId", "PhoneNumber", "Uid" },
                values: new object[,]
                {
                    { 1, "jones@jones.com", "Trent", "Jones", 1, "6157523654", "ZjnYscBnyAOQCwSCi1NWLYjo6bs1" },
                    { 2, "jj123@nss.com", "John", "James", 2, "6157548796", "UniqueUidForJohn" },
                    { 3, "stron234@makeit.com", "Sam", "Tronset", 3, "8132547486", "UniqueUidForSam" },
                    { 4, "helpfulsusan9541@chsarp.com", "Susan", "McJohnny", 4, "2154526341", "UniqueUidForSusan" },
                    { 5, "bobk1ngs@betdes.com", "Bobby", "Castle", 5, "9872154897", "UniqueUidForBobby" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrder_OrderId",
                table: "ItemOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentId",
                table: "Orders",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemOrder");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
