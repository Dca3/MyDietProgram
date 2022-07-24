using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDietProgram.Migrations
{
    public partial class refactor_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Infos_FoodId",
                table: "Infos",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Infos_MealId",
                table: "Infos",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_Infos_UserId",
                table: "Infos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Infos_Foods_FoodId",
                table: "Infos",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Infos_Meals_MealId",
                table: "Infos",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "MealId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Infos_Users_UserId",
                table: "Infos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Infos_Foods_FoodId",
                table: "Infos");

            migrationBuilder.DropForeignKey(
                name: "FK_Infos_Meals_MealId",
                table: "Infos");

            migrationBuilder.DropForeignKey(
                name: "FK_Infos_Users_UserId",
                table: "Infos");

            migrationBuilder.DropIndex(
                name: "IX_Infos_FoodId",
                table: "Infos");

            migrationBuilder.DropIndex(
                name: "IX_Infos_MealId",
                table: "Infos");

            migrationBuilder.DropIndex(
                name: "IX_Infos_UserId",
                table: "Infos");
        }
    }
}
