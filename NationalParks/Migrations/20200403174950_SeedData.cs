using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Campgrounds", "City", "ClimbingRoutes", "Description", "GeneralStores", "Name", "State" },
                values: new object[] { 2, 3, "Three Rivers", 1, "It's ancient", 4, "Sequoia National Park", "CA" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Campgrounds", "City", "ClimbingRoutes", "Description", "GeneralStores", "Name", "State" },
                values: new object[] { 3, 9, "Yosemite National Park", 1348, "I met my friend Sam here", 8, "Yosemite National Park", "CA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);
        }
    }
}
