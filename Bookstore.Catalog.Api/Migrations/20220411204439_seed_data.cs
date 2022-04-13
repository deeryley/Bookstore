using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Catalog.Api.Migrations
{
    public partial class seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "Name" },
                values: new object[,]
                {
                    { 1, "Fantasy" },
                    { 2, "Technology" },
                    { 3, "Mystery" },
                    { 4, "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageID", "Name" },
                values: new object[,]
                {
                    { 1, "Bulgarian" },
                    { 2, "English" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageID",
                keyValue: 2);
        }
    }
}
