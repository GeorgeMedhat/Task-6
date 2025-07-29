using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "MasterSchema",
                table: "Categories",
                columns: new[] { "id", "catName", "catOrder", "isDeleted" },
                values: new object[,]
                {
                    { 1, "Category 1", 1, false },
                    { 2, "Category 2", 2, false },
                    { 3, "Category 3", 3, false },
                    { 4, "Category 4", 4, false },
                    { 5, "Category 5", 5, false },
                    { 6, "Category 6", 6, false },
                    { 7, "Category 7", 7, false },
                    { 8, "Category 8", 8, false },
                    { 9, "Category 9", 9, false },
                    { 10, "Category 10", 10, false }
                });

            migrationBuilder.InsertData(
                schema: "MasterSchema",
                table: "Products",
                columns: new[] { "id", "author", "categoryId", "description", "markedAsDeleted", "BookPrice", "title" },
                values: new object[,]
                {
                    { 1, "Author 1", 1, null, false, 11.5, "Product 1" },
                    { 2, "Author 2", 1, null, false, 22.0, "Product 2" },
                    { 3, "Author 3", 1, null, false, 32.5, "Product 3" },
                    { 4, "Author 4", 2, null, false, 12.5, "Product 4" },
                    { 5, "Author 5", 2, null, false, 23.0, "Product 5" },
                    { 6, "Author 6", 2, null, false, 33.5, "Product 6" },
                    { 7, "Author 7", 3, null, false, 13.5, "Product 7" },
                    { 8, "Author 8", 3, null, false, 24.0, "Product 8" },
                    { 9, "Author 9", 3, null, false, 34.5, "Product 9" },
                    { 10, "Author 10", 4, null, false, 14.5, "Product 10" },
                    { 11, "Author 11", 4, null, false, 25.0, "Product 11" },
                    { 12, "Author 12", 4, null, false, 35.5, "Product 12" },
                    { 13, "Author 13", 5, null, false, 15.5, "Product 13" },
                    { 14, "Author 14", 5, null, false, 26.0, "Product 14" },
                    { 15, "Author 15", 5, null, false, 36.5, "Product 15" },
                    { 16, "Author 16", 6, null, false, 16.5, "Product 16" },
                    { 17, "Author 17", 6, null, false, 27.0, "Product 17" },
                    { 18, "Author 18", 6, null, false, 37.5, "Product 18" },
                    { 19, "Author 19", 7, null, false, 17.5, "Product 19" },
                    { 20, "Author 20", 7, null, false, 28.0, "Product 20" },
                    { 21, "Author 21", 7, null, false, 38.5, "Product 21" },
                    { 22, "Author 22", 8, null, false, 18.5, "Product 22" },
                    { 23, "Author 23", 8, null, false, 29.0, "Product 23" },
                    { 24, "Author 24", 8, null, false, 39.5, "Product 24" },
                    { 25, "Author 25", 9, null, false, 19.5, "Product 25" },
                    { 26, "Author 26", 9, null, false, 30.0, "Product 26" },
                    { 27, "Author 27", 9, null, false, 40.5, "Product 27" },
                    { 28, "Author 28", 10, null, false, 20.5, "Product 28" },
                    { 29, "Author 29", 10, null, false, 31.0, "Product 29" },
                    { 30, "Author 30", 10, null, false, 41.5, "Product 30" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Products",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Categories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Categories",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Categories",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Categories",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Categories",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Categories",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Categories",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "MasterSchema",
                table: "Categories",
                keyColumn: "id",
                keyValue: 10);
        }
    }
}
