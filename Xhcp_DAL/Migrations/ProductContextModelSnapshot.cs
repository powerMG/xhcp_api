﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Xhcp_DAL;

namespace Xhcp_DAL.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Xhcp_Entity.Table.FoodCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryDoc");

                    b.Property<string>("CategoryImg")
                        .IsRequired();

                    b.Property<string>("CategoryName")
                        .IsRequired();

                    b.Property<int>("CategoryPid");

                    b.Property<int>("CategoryType");

                    b.Property<string>("CategoryUrl");

                    b.Property<DateTime>("CreteTime");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("FoodCategory");
                });

            modelBuilder.Entity("Xhcp_Entity.Table.FoodInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreteTime");

                    b.Property<string>("FoodAuthor")
                        .IsRequired();

                    b.Property<string>("FoodDoc")
                        .IsRequired();

                    b.Property<string>("FoodEffect")
                        .IsRequired();

                    b.Property<string>("FoodImg")
                        .IsRequired();

                    b.Property<string>("FoodIngredientId")
                        .IsRequired();

                    b.Property<string>("FoodNotice");

                    b.Property<string>("FoodPracticeId")
                        .IsRequired();

                    b.Property<string>("FoodTitle")
                        .IsRequired();

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("FoodInfo");
                });

            modelBuilder.Entity("Xhcp_Entity.Table.FoodIngredient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreteTime");

                    b.Property<string>("IngredientDosage")
                        .IsRequired();

                    b.Property<string>("IngredientName")
                        .IsRequired();

                    b.Property<int>("IngredientTagId");

                    b.Property<int>("IngredientType");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("FoodIngredient");
                });

            modelBuilder.Entity("Xhcp_Entity.Table.FoodPractice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreteTime");

                    b.Property<string>("PracticeDoc");

                    b.Property<string>("PracticeImg")
                        .IsRequired();

                    b.Property<string>("PracticeName")
                        .IsRequired();

                    b.Property<string>("PracticeNum")
                        .IsRequired();

                    b.Property<int>("PracticeType");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("FoodPractice");
                });

            modelBuilder.Entity("Xhcp_Entity.Table.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Category");

                    b.Property<DateTime>("CreteTime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<decimal>("Discount");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Xhcp_Entity.Table.UserInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Category");

                    b.Property<DateTime>("CreteTime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("Role");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<int>("Status");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Userinfo");
                });
#pragma warning restore 612, 618
        }
    }
}
