﻿// <auto-generated />
using System;
using CrazyBooks_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrazyBooks_DataAccess.Migrations
{
    [DbContext(typeof(CrazyBooksDbContext))]
    [Migration("20220616142834_AddAuthor_AuthorDetail")]
    partial class AddAuthor_AuthorDetail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrazyBooks_Models.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorDetail_Id")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorDetail_Id")
                        .IsUnique()
                        .HasFilter("[AuthorDetail_Id] IS NOT NULL");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.AuthorBook", b =>
                {
                    b.Property<int>("Author_Id")
                        .HasColumnType("int");

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.Property<int>("PCRoyalties")
                        .HasColumnType("int");

                    b.HasKey("Author_Id", "Book_Id");

                    b.HasIndex("Book_Id");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.AuthorDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Photo")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("AuthorDetail");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<bool>("Promo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Publisher_Id")
                        .HasColumnType("int");

                    b.Property<string>("Resume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Subject_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Publisher_Id");

                    b.HasIndex("Subject_Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PublisherSite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.Author", b =>
                {
                    b.HasOne("CrazyBooks_Models.Models.AuthorDetail", "AuthorDetail")
                        .WithOne("Author")
                        .HasForeignKey("CrazyBooks_Models.Models.Author", "AuthorDetail_Id");

                    b.Navigation("AuthorDetail");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.AuthorBook", b =>
                {
                    b.HasOne("CrazyBooks_Models.Models.Author", "Author")
                        .WithMany("AuthorsBooks")
                        .HasForeignKey("Author_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrazyBooks_Models.Models.Book", "Book")
                        .WithMany("AuthorsBooks")
                        .HasForeignKey("Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.Book", b =>
                {
                    b.HasOne("CrazyBooks_Models.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("Publisher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrazyBooks_Models.Models.Subject", "Subject")
                        .WithMany("Books")
                        .HasForeignKey("Subject_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.Author", b =>
                {
                    b.Navigation("AuthorsBooks");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.AuthorDetail", b =>
                {
                    b.Navigation("Author");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.Book", b =>
                {
                    b.Navigation("AuthorsBooks");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("CrazyBooks_Models.Models.Subject", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
