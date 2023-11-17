﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tyuiu.oop.SalienkoMN.VyalikNA.NetCoreWebAppLib.Data;

#nullable disable

namespace tyuiu.oop.SalienkoMN.VyalikNA.NetCoreWebAppLib.Migrations
{
    [DbContext(typeof(tyuiuoopSalienkoMNVyalikNANetCoreWebAppLibContext))]
    [Migration("20231117181052_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("tyuiu.oop.SalienkoMN.VyalikNA.NetCoreWebAppLib.Models.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("People");
                });
#pragma warning restore 612, 618
        }
    }
}
