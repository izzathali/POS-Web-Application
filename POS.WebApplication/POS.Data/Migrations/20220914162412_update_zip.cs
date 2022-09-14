using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS.Data.Migrations
{
    public partial class update_zip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WithZip",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "WithZip",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
