﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtualHosp.Context;

namespace VirtualHosp.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20211124211807_VirtualHosp.Context1")]
    partial class VirtualHospContext1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VirtualHosp.Clases.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CodigoPostal")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nacionalidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroDocumento")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("TipoDocumento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("VirtualHosp.Models.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("HorarioFinal")
                        .HasColumnType("real");

                    b.Property<float>("HorarioInicio")
                        .HasColumnType("real");

                    b.Property<int>("usuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("usuarioId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("VirtualHosp.Models.Medico", b =>
                {
                    b.HasBaseType("VirtualHosp.Clases.Usuario");

                    b.Property<int>("Especialidad")
                        .HasColumnType("int");

                    b.Property<int>("NumeroMatricula")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("VirtualHosp.Models.Paciente", b =>
                {
                    b.HasBaseType("VirtualHosp.Clases.Usuario");

                    b.Property<string>("AntecedentesMedicos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HistorialMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicamentos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlanMedico")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("VirtualHosp.Models.Consulta", b =>
                {
                    b.HasOne("VirtualHosp.Clases.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
