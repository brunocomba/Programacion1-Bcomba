﻿// <auto-generated />
using Back.ConeccionBD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230926015615_Migracion3")]
    partial class Migracion3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Back.Clases.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Back.Clases.Cuenta_Bancaria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<decimal>("NroCuenta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Cuentas_Bancarias");
                });

            modelBuilder.Entity("Back.Clases.Tarjeta_Credito", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<decimal>("LimiteCredito")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MontoDeuda")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NroTarjeta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SaldoDisponible")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Tarjetas_Credito");
                });

            modelBuilder.Entity("Back.Clases.Cuenta_Bancaria", b =>
                {
                    b.HasOne("Back.Clases.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Back.Clases.Tarjeta_Credito", b =>
                {
                    b.HasOne("Back.Clases.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
