using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplikacja_GOT_PTTK.Migrations
{
    public partial class init11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PathModel_GeoPointModel_punktKoncGeoPointId",
                table: "PathModel");

            migrationBuilder.DropForeignKey(
                name: "FK_PathModel_GeoPointModel_punktPoczGeoPointId",
                table: "PathModel");

            migrationBuilder.DropIndex(
                name: "IX_PathModel_punktKoncGeoPointId",
                table: "PathModel");

            migrationBuilder.DropIndex(
                name: "IX_PathModel_punktPoczGeoPointId",
                table: "PathModel");

            migrationBuilder.DropColumn(
                name: "punktKoncGeoPointId",
                table: "PathModel");

            migrationBuilder.DropColumn(
                name: "punktPoczGeoPointId",
                table: "PathModel");

            migrationBuilder.AddColumn<string>(
                name: "punktKonc",
                table: "PathModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "punktPocz",
                table: "PathModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "punktKonc",
                table: "PathModel");

            migrationBuilder.DropColumn(
                name: "punktPocz",
                table: "PathModel");

            migrationBuilder.AddColumn<int>(
                name: "punktKoncGeoPointId",
                table: "PathModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "punktPoczGeoPointId",
                table: "PathModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PathModel_punktKoncGeoPointId",
                table: "PathModel",
                column: "punktKoncGeoPointId");

            migrationBuilder.CreateIndex(
                name: "IX_PathModel_punktPoczGeoPointId",
                table: "PathModel",
                column: "punktPoczGeoPointId");

            migrationBuilder.AddForeignKey(
                name: "FK_PathModel_GeoPointModel_punktKoncGeoPointId",
                table: "PathModel",
                column: "punktKoncGeoPointId",
                principalTable: "GeoPointModel",
                principalColumn: "GeoPointId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PathModel_GeoPointModel_punktPoczGeoPointId",
                table: "PathModel",
                column: "punktPoczGeoPointId",
                principalTable: "GeoPointModel",
                principalColumn: "GeoPointId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
