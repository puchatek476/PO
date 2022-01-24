using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplikacja_GOT_PTTK.Migrations
{
    public partial class init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PointID",
                table: "PathModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointID",
                table: "PathModel");
        }
    }
}
