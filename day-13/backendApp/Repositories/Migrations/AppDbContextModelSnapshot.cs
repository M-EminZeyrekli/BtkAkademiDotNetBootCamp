﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.Concrete;

#nullable disable

namespace Repositories.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            FirstName = "İskender",
                            LastName = "Pala"
                        },
                        new
                        {
                            AuthorId = 2,
                            FirstName = "Ali",
                            LastName = "Şeriatı"
                        },
                        new
                        {
                            AuthorId = 3,
                            FirstName = "Ömer",
                            LastName = "Seyfettin"
                        });
                });

            modelBuilder.Entity("Entities.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AtCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(10m);

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AtCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 1,
                            Price = 120m,
                            Summary = "...",
                            Title = "Devlet"
                        },
                        new
                        {
                            Id = 2,
                            AtCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 1,
                            Price = 120m,
                            Summary = "...",
                            Title = "Nutuk"
                        },
                        new
                        {
                            Id = 3,
                            AtCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 2,
                            Price = 120m,
                            Summary = "...",
                            Title = "Vatan"
                        });
                });

            modelBuilder.Entity("Entities.Models.BookAuthor", b =>
                {
                    b.Property<int>("BookAuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookAuthorId"), 1L, 1);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.HasKey("BookAuthorId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthors");

                    b.HasData(
                        new
                        {
                            BookAuthorId = 1,
                            AuthorId = 1,
                            BookId = 1
                        },
                        new
                        {
                            BookAuthorId = 2,
                            AuthorId = 2,
                            BookId = 1
                        },
                        new
                        {
                            BookAuthorId = 3,
                            AuthorId = 3,
                            BookId = 1
                        },
                        new
                        {
                            BookAuthorId = 4,
                            AuthorId = 2,
                            BookId = 2
                        },
                        new
                        {
                            BookAuthorId = 5,
                            AuthorId = 3,
                            BookId = 2
                        },
                        new
                        {
                            BookAuthorId = 6,
                            AuthorId = 1,
                            BookId = 3
                        },
                        new
                        {
                            BookAuthorId = 7,
                            AuthorId = 2,
                            BookId = 3
                        },
                        new
                        {
                            BookAuthorId = 8,
                            AuthorId = 3,
                            BookId = 3
                        });
                });

            modelBuilder.Entity("Entities.Models.BookDetail", b =>
                {
                    b.Property<int>("BookDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookDetailId"), 1L, 1);

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPage")
                        .HasColumnType("int");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookDetailId");

                    b.HasIndex("BookId")
                        .IsUnique()
                        .HasFilter("[BookId] IS NOT NULL");

                    b.ToTable("BookDetails");

                    b.HasData(
                        new
                        {
                            BookDetailId = 1,
                            BookId = 1,
                            City = "Samsun",
                            Country = "Turkey",
                            ISBN = "1234-5456-1234",
                            Language = "Turkish",
                            NumberOfPage = 100,
                            Publisher = "Samsun University"
                        },
                        new
                        {
                            BookDetailId = 2,
                            BookId = 2,
                            City = "Ankara",
                            Country = "Turkey",
                            ISBN = "1234-5456-7891",
                            Language = "Turkish",
                            NumberOfPage = 150,
                            Publisher = "Gazi University"
                        },
                        new
                        {
                            BookDetailId = 3,
                            BookId = 3,
                            City = "İstanbul",
                            Country = "Turkey",
                            ISBN = "8741-5456-1234",
                            Language = "Turkish",
                            NumberOfPage = 78,
                            Publisher = "Yıldız Techincal University"
                        });
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Computer Science",
                            Description = "Computer Science description"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Network",
                            Description = "Network description"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Database",
                            Description = "Database description"
                        });
                });

            modelBuilder.Entity("Entities.Models.Book", b =>
                {
                    b.HasOne("Entities.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Models.BookAuthor", b =>
                {
                    b.HasOne("Entities.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entities.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Entities.Models.BookDetail", b =>
                {
                    b.HasOne("Entities.Models.Book", "Book")
                        .WithOne("BookDetail")
                        .HasForeignKey("Entities.Models.BookDetail", "BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Entities.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("Entities.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("BookDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
