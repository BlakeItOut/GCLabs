using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone6.Migrations
{
    public partial class UpdateDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todo",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Todo",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
