using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplikacja_GOT_PTTK.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GeoPointModel",
                columns: new[] { "GeoPointId", "Height", "Latitude", "Longitude", "Name", "PathModelPathId" },
                values: new object[,]
                {
                    { 3, "776", "50.91173", "15.28898", "Czerniawska Kopa", null },
                    { 4, "816", "50.82309", "15.51584", "Wysoka", null },
                    { 5, "699", "50.87182", "15.58584", "Bobrowe Skały", null },
                    { 6, "825", "50.84025", "15.56191", "Orle", null },
                    { 7, "675", "50.83227", "15.53487", "Sowiniec", null },
                    { 8, "408", "51.17568", "20.76652", "Altana", null },
                    { 9, "940", "50.78784", "15.51387", "Przełęcz Mokra", null },
                    { 10, "390", "51.06359", "20.68944", "Świnia Góra", null },
                    { 11, "1362", "50.79257", "15.51307", "Szrenica", null },
                    { 12, "1423", "50.75985", "15.68335", "Słonecznik", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GeoPointModel",
                keyColumn: "GeoPointId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GeoPointModel",
                keyColumn: "GeoPointId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GeoPointModel",
                keyColumn: "GeoPointId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GeoPointModel",
                keyColumn: "GeoPointId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GeoPointModel",
                keyColumn: "GeoPointId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GeoPointModel",
                keyColumn: "GeoPointId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GeoPointModel",
                keyColumn: "GeoPointId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GeoPointModel",
                keyColumn: "GeoPointId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GeoPointModel",
                keyColumn: "GeoPointId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GeoPointModel",
                keyColumn: "GeoPointId",
                keyValue: 12);
        }
    }
}
