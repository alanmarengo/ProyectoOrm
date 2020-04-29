﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PORM;

namespace PORM.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PORM.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            ClienteID = 1,
                            Apellido = "Marengo",
                            Direccion = "154",
                            Dni = "4055585",
                            Nombre = "Alan",
                            Telefono = "55445454577"
                        },
                        new
                        {
                            ClienteID = 2,
                            Apellido = "Ayala",
                            Direccion = "155",
                            Dni = "40555598",
                            Nombre = "Maty",
                            Telefono = "545454554"
                        },
                        new
                        {
                            ClienteID = 3,
                            Apellido = "Julio",
                            Direccion = "156",
                            Dni = "5454545454",
                            Nombre = "Ema",
                            Telefono = "877878112"
                        },
                        new
                        {
                            ClienteID = 4,
                            Apellido = "Octavio",
                            Direccion = "157",
                            Dni = "875454",
                            Nombre = "Octavio",
                            Telefono = "989889889"
                        },
                        new
                        {
                            ClienteID = 5,
                            Apellido = "Cataneo",
                            Direccion = "158",
                            Dni = "87541",
                            Nombre = "David",
                            Telefono = "21221122"
                        },
                        new
                        {
                            ClienteID = 6,
                            Apellido = "Javier",
                            Direccion = "159",
                            Dni = "12112445",
                            Nombre = "Javier",
                            Telefono = "8877844"
                        });
                });

            modelBuilder.Entity("PORM.Producto", b =>
                {
                    b.Property<int>("ProductoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductoID");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            ProductoID = 1,
                            Codigo = "0054SS",
                            Marca = "Adidas",
                            Nombre = "zapatillas",
                            Precio = 12m
                        },
                        new
                        {
                            ProductoID = 2,
                            Codigo = "0054S1",
                            Marca = "Nike",
                            Nombre = "gorra",
                            Precio = 12m
                        },
                        new
                        {
                            ProductoID = 3,
                            Codigo = "0054S2",
                            Marca = "Rebook",
                            Nombre = "ojotas",
                            Precio = 12m
                        },
                        new
                        {
                            ProductoID = 4,
                            Codigo = "0054S3",
                            Marca = "Lecof",
                            Nombre = "buzo",
                            Precio = 12m
                        },
                        new
                        {
                            ProductoID = 5,
                            Codigo = "0054S4",
                            Marca = "Chester",
                            Nombre = "campera",
                            Precio = 12m
                        });
                });

            modelBuilder.Entity("PORM.Venta", b =>
                {
                    b.Property<int>("VentaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductoID")
                        .HasColumnType("int");

                    b.HasKey("VentaID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("ProductoID");

                    b.ToTable("Venta");

                    b.HasData(
                        new
                        {
                            VentaID = 1,
                            ClienteID = 1,
                            Fecha = new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            ProductoID = 2
                        },
                        new
                        {
                            VentaID = 2,
                            ClienteID = 2,
                            Fecha = new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            ProductoID = 1
                        },
                        new
                        {
                            VentaID = 3,
                            ClienteID = 3,
                            Fecha = new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            ProductoID = 4
                        },
                        new
                        {
                            VentaID = 4,
                            ClienteID = 4,
                            Fecha = new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            ProductoID = 5
                        },
                        new
                        {
                            VentaID = 5,
                            ClienteID = 5,
                            Fecha = new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            ProductoID = 3
                        });
                });

            modelBuilder.Entity("PORM.Venta", b =>
                {
                    b.HasOne("PORM.Cliente", "ClienteNavigator")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PORM.Producto", "ProductoNavigator")
                        .WithMany()
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
