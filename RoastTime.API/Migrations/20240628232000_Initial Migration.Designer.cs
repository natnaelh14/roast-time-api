﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoastTime.API.Data;

#nullable disable

namespace RoastTime.API.Migrations
{
    [DbContext(typeof(RoastTimeDbContext))]
    [Migration("20240628232000_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RoastTime.API.Models.Domain.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaturants");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"),
                            Address = "8240 Fenton St, Silver Spring, MD 20910",
                            Category = "Coffee Shop",
                            Latitude = 38.997700000000002,
                            Longitude = -77.030600000000007,
                            Name = "Black Lion"
                        },
                        new
                        {
                            Id = new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                            Address = "918 Silver Spring Ave, Silver Spring, MD 20910",
                            Category = "Coffee Shop",
                            Latitude = 38.997700000000002,
                            Longitude = -77.030600000000007,
                            Name = "Kaldis Coffee"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
