using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hiphipPizzaWangs2.Migrations
{
    public partial class _3rdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                column: "OrderId",
                value: 23);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                column: "OrderId",
                value: 17);
        }
    }
}
