using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Books.API.Migrations
{
    /// <inheritdoc />
    public partial class newOld2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"), "Brasil", "Paulo Coelho" },
                    { new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"), "USA", "Glennon Doyle" },
                    { new Guid("34dfb30c-5ec4-11ee-8c99-0242ac120002"), "USA", "Toni Morrison" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("8e7e76fa-6095-11ee-8c99-0242ac120002"), "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna", "THINGS FALL APART" },
                    { new Guid("8e7e79b6-6095-11ee-8c99-0242ac120002"), "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna", "PRIDE AND PREJUDICE " },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9123"), "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna", "The Alchemist" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("34dfb30c-5ec4-11ee-8c99-0242ac120002"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e7e76fa-6095-11ee-8c99-0242ac120002"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e7e79b6-6095-11ee-8c99-0242ac120002"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9123"));
        }
    }
}
