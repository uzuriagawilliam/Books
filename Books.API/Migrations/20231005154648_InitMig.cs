using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Books.API.Migrations
{
    /// <inheritdoc />
    public partial class InitMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BooksId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorsId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"), "Brasil", "Paulo Coelho" },
                    { new Guid("34dfae16-5ec4-11ee-8c99-0242ac120002"), "Israel", "Yuval Noah Harari" },
                    { new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"), "USA", "Glennon Doyle" },
                    { new Guid("34dfb30c-5ec4-11ee-8c99-0242ac120002"), "USA", "Toni Morrison" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("48754840-609b-11ee-8c99-0242ac120002"), "In quis purus facilisis, vehicula magna at, aliquam orci", "Beloved" },
                    { new Guid("48754afc-609b-11ee-8c99-0242ac120002"), "In quis purus facilisis, vehicula magna at, aliquam orci", "Beloved" },
                    { new Guid("48754f0c-609b-11ee-8c99-0242ac120002"), "Quisque iaculis lobortis porta", "A Brief History of Humankind" },
                    { new Guid("8e7e76fa-6095-11ee-8c99-0242ac120002"), "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna", "THINGS FALL APART" },
                    { new Guid("8e7e79b6-6095-11ee-8c99-0242ac120002"), "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna", "PRIDE AND PREJUDICE " },
                    { new Guid("8e7e7c4a-6095-11ee-8c99-0242ac120002"), "Quisque iaculis lobortis porta", "A Brief History of Humankind" },
                    { new Guid("8e7e82f8-6095-11ee-8c99-0242ac120002"), "Pellentesque vel suscipit metus.", "Untamed" },
                    { new Guid("8e7e841a-6095-11ee-8c99-0242ac120002"), "Pellentesque vel suscipit metus.", "Untamed" },
                    { new Guid("c19099ed-94db-44ba-885b-0ad7205d5e40"), "In quis purus facilisis, vehicula magna at, aliquam orci", "Beloved" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9123"), "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna", "The Alchemist" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Quisque iaculis lobortis porta", "A Brief History of Humankind" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Pellentesque vel suscipit metus.", "Untamed" }
                });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorsId", "BooksId" },
                values: new object[,]
                {
                    { new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"), new Guid("8e7e76fa-6095-11ee-8c99-0242ac120002") },
                    { new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"), new Guid("8e7e79b6-6095-11ee-8c99-0242ac120002") },
                    { new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9123") },
                    { new Guid("34dfae16-5ec4-11ee-8c99-0242ac120002"), new Guid("48754f0c-609b-11ee-8c99-0242ac120002") },
                    { new Guid("34dfae16-5ec4-11ee-8c99-0242ac120002"), new Guid("8e7e7c4a-6095-11ee-8c99-0242ac120002") },
                    { new Guid("34dfae16-5ec4-11ee-8c99-0242ac120002"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35") },
                    { new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"), new Guid("8e7e82f8-6095-11ee-8c99-0242ac120002") },
                    { new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"), new Guid("8e7e841a-6095-11ee-8c99-0242ac120002") },
                    { new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96") },
                    { new Guid("34dfb30c-5ec4-11ee-8c99-0242ac120002"), new Guid("48754840-609b-11ee-8c99-0242ac120002") },
                    { new Guid("34dfb30c-5ec4-11ee-8c99-0242ac120002"), new Guid("48754afc-609b-11ee-8c99-0242ac120002") },
                    { new Guid("34dfb30c-5ec4-11ee-8c99-0242ac120002"), new Guid("c19099ed-94db-44ba-885b-0ad7205d5e40") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
