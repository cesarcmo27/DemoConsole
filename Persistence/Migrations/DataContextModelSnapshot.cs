﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Domain.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Domain.OrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdProducto")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Domain.Site", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WebSites");
                });

            modelBuilder.Entity("Domain.OrderDetail", b =>
                {
                    b.HasOne("Domain.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Domain.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
