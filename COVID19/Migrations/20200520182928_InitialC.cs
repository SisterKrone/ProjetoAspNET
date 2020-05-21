using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID19.Migrations
{
    public partial class InitialC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkImage",
                table: "Tips",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkImage",
                table: "Tips");
        }
    }
}
