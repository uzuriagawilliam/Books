using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Books.API.Migrations
{
    /// <inheritdoc />
    public partial class newOld3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorsId", "BooksId" },
                values: new object[,]
                {
                    { new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"), new Guid("8e7e76fa-6095-11ee-8c99-0242ac120002") },
                    { new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9123") },
                    { new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"), new Guid("8e7e79b6-6095-11ee-8c99-0242ac120002") },
                    { new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9123") },
                    { new Guid("34dfb30c-5ec4-11ee-8c99-0242ac120002"), new Guid("8e7e76fa-6095-11ee-8c99-0242ac120002") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"), new Guid("8e7e76fa-6095-11ee-8c99-0242ac120002") });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9123") });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"), new Guid("8e7e79b6-6095-11ee-8c99-0242ac120002") });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9123") });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { new Guid("34dfb30c-5ec4-11ee-8c99-0242ac120002"), new Guid("8e7e76fa-6095-11ee-8c99-0242ac120002") });
        }
    }
}
