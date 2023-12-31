﻿// <auto-generated />
using System;
using Books.Api.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Books.API.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20231023135219_newOld3")]
    partial class newOld3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<Guid>("AuthorsId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BooksId")
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorBook");

                    b.HasData(
                        new
                        {
                            AuthorsId = new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"),
                            BooksId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9123")
                        },
                        new
                        {
                            AuthorsId = new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"),
                            BooksId = new Guid("8e7e76fa-6095-11ee-8c99-0242ac120002")
                        },
                        new
                        {
                            AuthorsId = new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"),
                            BooksId = new Guid("8e7e79b6-6095-11ee-8c99-0242ac120002")
                        },
                        new
                        {
                            AuthorsId = new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"),
                            BooksId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9123")
                        },
                        new
                        {
                            AuthorsId = new Guid("34dfb30c-5ec4-11ee-8c99-0242ac120002"),
                            BooksId = new Guid("8e7e76fa-6095-11ee-8c99-0242ac120002")
                        });
                });

            modelBuilder.Entity("Books.Api.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("34dfab3c-5ec4-11ee-8c99-0242ac120002"),
                            Country = "Brasil",
                            Name = "Paulo Coelho"
                        },
                        new
                        {
                            Id = new Guid("34dfaf74-5ec4-11ee-8c99-0242ac120002"),
                            Country = "USA",
                            Name = "Glennon Doyle"
                        },
                        new
                        {
                            Id = new Guid("34dfb30c-5ec4-11ee-8c99-0242ac120002"),
                            Country = "USA",
                            Name = "Toni Morrison"
                        });
                });

            modelBuilder.Entity("Books.Api.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9123"),
                            Description = "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna",
                            Title = "The Alchemist"
                        },
                        new
                        {
                            Id = new Guid("8e7e76fa-6095-11ee-8c99-0242ac120002"),
                            Description = "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna",
                            Title = "THINGS FALL APART"
                        },
                        new
                        {
                            Id = new Guid("8e7e79b6-6095-11ee-8c99-0242ac120002"),
                            Description = "Nullam justo nisi, sagittis nec mattis nec, tincidunt sit amet urna",
                            Title = "PRIDE AND PREJUDICE "
                        });
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("Books.Api.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Books.Api.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
