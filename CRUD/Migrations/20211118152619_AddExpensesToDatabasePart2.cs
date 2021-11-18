using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD.Migrations
{
    public partial class AddExpensesToDatabasePart2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Expenses");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Expenses");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Expenses",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
