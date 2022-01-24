using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplikacja_GOT_PTTK.Migrations
{
    public partial class init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeoPointModel_PathModel_PathModelPathId",
                table: "GeoPointModel");

            migrationBuilder.DropIndex(
                name: "IX_GeoPointModel_PathModelPathId",
                table: "GeoPointModel");

            migrationBuilder.DropColumn(
                name: "PointID",
                table: "PathModel");

            migrationBuilder.DropColumn(
                name: "PathModelPathId",
                table: "GeoPointModel");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "PointID",
                table: "PathModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PathModelPathId",
                table: "GeoPointModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GeoPointModel_PathModelPathId",
                table: "GeoPointModel",
                column: "PathModelPathId");

            migrationBuilder.AddForeignKey(
                name: "FK_GeoPointModel_PathModel_PathModelPathId",
                table: "GeoPointModel",
                column: "PathModelPathId",
                principalTable: "PathModel",
                principalColumn: "PathId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
