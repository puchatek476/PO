using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplikacja_GOT_PTTK.Migrations
{
    public partial class init112 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "punktPKGeoPointId",
                table: "PathModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "punktPPGeoPointId",
                table: "PathModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PathModel_punktPKGeoPointId",
                table: "PathModel",
                column: "punktPKGeoPointId");

            migrationBuilder.CreateIndex(
                name: "IX_PathModel_punktPPGeoPointId",
                table: "PathModel",
                column: "punktPPGeoPointId");

            migrationBuilder.AddForeignKey(
                name: "FK_PathModel_GeoPointModel_punktPKGeoPointId",
                table: "PathModel",
                column: "punktPKGeoPointId",
                principalTable: "GeoPointModel",
                principalColumn: "GeoPointId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PathModel_GeoPointModel_punktPPGeoPointId",
                table: "PathModel",
                column: "punktPPGeoPointId",
                principalTable: "GeoPointModel",
                principalColumn: "GeoPointId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PathModel_GeoPointModel_punktPKGeoPointId",
                table: "PathModel");

            migrationBuilder.DropForeignKey(
                name: "FK_PathModel_GeoPointModel_punktPPGeoPointId",
                table: "PathModel");

            migrationBuilder.DropIndex(
                name: "IX_PathModel_punktPKGeoPointId",
                table: "PathModel");

            migrationBuilder.DropIndex(
                name: "IX_PathModel_punktPPGeoPointId",
                table: "PathModel");

            migrationBuilder.DropColumn(
                name: "punktPKGeoPointId",
                table: "PathModel");

            migrationBuilder.DropColumn(
                name: "punktPPGeoPointId",
                table: "PathModel");
        }
    }
}
