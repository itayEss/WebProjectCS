﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProjectCS.Models.Managment;

namespace WebProjectCS.Migrations
{
    [DbContext(typeof(ApplicationDbContextcs))]
    partial class ApplicationDbContextcsModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebProjectCS.Models.BlogItem", b =>
                {
                    b.Property<int>("BlogItemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConvID");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<int>("RelatedID");

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<int>("UID");

                    b.HasKey("BlogItemID");

                    b.ToTable("blogItem");
                });

            modelBuilder.Entity("WebProjectCS.Models.ConvBlogItem", b =>
                {
                    b.Property<int>("ConvBlogItemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConvCreatorName")
                        .IsRequired();

                    b.Property<string>("ConvName")
                        .IsRequired();

                    b.HasKey("ConvBlogItemID");

                    b.ToTable("ConvBlogItem");
                });

            modelBuilder.Entity("WebProjectCS.Models.Managment.UserAcccount", b =>
                {
                    b.Property<int>("UId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("UPriv");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("UId");

                    b.ToTable("userAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
