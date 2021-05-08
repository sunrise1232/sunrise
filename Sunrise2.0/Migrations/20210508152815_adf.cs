using Microsoft.EntityFrameworkCore.Migrations;

namespace Sunrise2._0.Migrations
{
    public partial class adf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceMultiplier",
                table: "Airlines");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Airlines",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Airlines");

            migrationBuilder.AddColumn<double>(
                name: "PriceMultiplier",
                table: "Airlines",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
