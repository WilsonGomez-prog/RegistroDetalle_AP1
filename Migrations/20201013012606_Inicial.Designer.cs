﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroDetalle_AP1.DAL;

namespace RegistroDetalle_AP1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20201013012606_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("RegistroDetalle_AP1.Entidades.Articulos", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<float>("Precio")
                        .HasColumnType("REAL");

                    b.HasKey("ArticuloId");

                    b.ToTable("Articulos");

                    b.HasData(
                        new
                        {
                            ArticuloId = 1,
                            Descripcion = "Libra Arroz",
                            Precio = 50f
                        },
                        new
                        {
                            ArticuloId = 2,
                            Descripcion = "Jabón",
                            Precio = 170f
                        },
                        new
                        {
                            ArticuloId = 3,
                            Descripcion = "Salami",
                            Precio = 100f
                        });
                });

            modelBuilder.Entity("RegistroDetalle_AP1.Entidades.Ordenes", b =>
                {
                    b.Property<int>("OrdenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("OrdenId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("RegistroDetalle_AP1.Entidades.OrdenesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArticuloId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Cantidad")
                        .HasColumnType("REAL");

                    b.Property<int>("OrdenId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Precio")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId");

                    b.ToTable("OrdenesDetalle");
                });

            modelBuilder.Entity("RegistroDetalle_AP1.Entidades.OrdenesDetalle", b =>
                {
                    b.HasOne("RegistroDetalle_AP1.Entidades.Ordenes", null)
                        .WithMany("Detalle")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
