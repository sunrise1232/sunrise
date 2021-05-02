using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sunrise2._0.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Tours");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Airlines",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Airlines");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Tours",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
