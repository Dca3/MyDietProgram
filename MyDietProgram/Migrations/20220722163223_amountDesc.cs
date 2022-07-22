using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDietProgram.Migrations
{
    public partial class amountDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gram",
                table: "Foods");

            migrationBuilder.AddColumn<string>(
                name: "AmountDescription",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountDescription",
                table: "Foods");

            migrationBuilder.AddColumn<double>(
                name: "Gram",
                table: "Foods",
                type: "float",
                nullable: true);
        }
    }
}
