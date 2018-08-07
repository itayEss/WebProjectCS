using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProjectCS.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UPriv",
                table: "userAccount",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UPriv",
                table: "userAccount");
        }
    }
}
