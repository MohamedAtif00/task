﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using task.Data;

#nullable disable

namespace task.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20241024172049_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("task.Model.InvoiceDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("expiryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("lineNo")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("unitNo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("invoiceDetails");
                });

            modelBuilder.Entity("task.Model.Unit", b =>
                {
                    b.Property<int>("unitNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("unitNo"));

                    b.Property<string>("unitName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("unitNo");

                    b.ToTable("units");
                });
#pragma warning restore 612, 618
        }
    }
}