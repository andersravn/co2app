﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using co2app.Data;

#nullable disable

namespace co2app.Migrations
{
    [DbContext(typeof(FoodContext))]
    partial class FoodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("co2app.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<float>("EmissionAgriculture")
                        .HasColumnType("REAL");

                    b.Property<float>("EmissionFoodProcessing")
                        .HasColumnType("REAL");

                    b.Property<float>("EmissionILUC")
                        .HasColumnType("REAL");

                    b.Property<float>("EmissionPackaging")
                        .HasColumnType("REAL");

                    b.Property<float>("EmissionRetail")
                        .HasColumnType("REAL");

                    b.Property<float?>("EmissionTotal")
                        .HasColumnType("REAL");

                    b.Property<float>("EmissionTransport")
                        .HasColumnType("REAL");

                    b.Property<string>("ExternalId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryName");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("co2app.Models.FoodCategory", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("co2app.Models.Food", b =>
                {
                    b.HasOne("co2app.Models.FoodCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryName");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
