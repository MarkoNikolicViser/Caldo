using Microsoft.EntityFrameworkCore.Migrations;

namespace Caldo.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "PizzaId",
                keyValue: 8,
                column: "SlikaUrl",
                value: "\\Images\\Menu\\pica8.jpg");

            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "PizzaId",
                keyValue: 9,
                column: "SlikaUrl",
                value: "\\Images\\Menu\\pica9.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "PizzaId",
                keyValue: 8,
                column: "SlikaUrl",
                value: "Images/Menu/pica8.jpg");

            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "PizzaId",
                keyValue: 9,
                column: "SlikaUrl",
                value: "Images/Menu/pica9.jpg");
        }
    }
}
