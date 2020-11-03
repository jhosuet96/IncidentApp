﻿// <auto-generated />
using System;
using IncidentApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IncidentApp.Model.Migrations
{
    [DbContext(typeof(IncidentAppContext))]
    [Migration("20201102231921_Config_FluentApi_Model.1")]
    partial class Config_FluentApi_Model1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IncidentApp.Model.Model.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Borrado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("CreadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Estatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 11, 2, 19, 19, 20, 954, DateTimeKind.Local).AddTicks(2376));

                    b.Property<int>("ModificadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("DepartamentoId");

                    b.HasIndex("CreadoPor");

                    b.HasIndex("ModificadoPor");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("IncidentApp.Model.Model.HistorialIncidente", b =>
                {
                    b.Property<int>("HistorialIncidenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Borrado")
                        .HasColumnType("bit");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Estatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IncidenteId")
                        .HasColumnType("int");

                    b.Property<int>("ModificadoPor")
                        .HasColumnType("int");

                    b.HasKey("HistorialIncidenteId");

                    b.HasIndex("CreadoPor");

                    b.HasIndex("IncidenteId");

                    b.HasIndex("ModificadoPor");

                    b.ToTable("HistorialIncidente");
                });

            modelBuilder.Entity("IncidentApp.Model.Model.Incidente", b =>
                {
                    b.Property<int>("IncidenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Borrado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("CoemntarioCierrre")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("CreadoPor")
                        .HasColumnType("int");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Estatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<DateTime>("FechaCierre")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 11, 2, 19, 19, 21, 1, DateTimeKind.Local).AddTicks(1213));

                    b.Property<int>("ModificadoPor")
                        .HasColumnType("int");

                    b.Property<int>("PrioridadId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("UsuarioAsignadoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioReportaId")
                        .HasColumnType("int");

                    b.HasKey("IncidenteId");

                    b.HasIndex("CreadoPor");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("ModificadoPor");

                    b.HasIndex("PrioridadId");

                    b.HasIndex("UsuarioAsignadoId");

                    b.HasIndex("UsuarioReportaId");

                    b.ToTable("Incidente");
                });

            modelBuilder.Entity("IncidentApp.Model.Model.Prioridad", b =>
                {
                    b.Property<int>("PrioridadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Borrado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("CreadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Estatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 11, 2, 19, 19, 20, 996, DateTimeKind.Local).AddTicks(3311));

                    b.Property<int>("ModificadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("SlaId")
                        .HasColumnType("int");

                    b.HasKey("PrioridadId");

                    b.HasIndex("CreadoPor");

                    b.HasIndex("ModificadoPor");

                    b.HasIndex("SlaId");

                    b.ToTable("Prioridad");
                });

            modelBuilder.Entity("IncidentApp.Model.Model.Puesto", b =>
                {
                    b.Property<int>("PuestoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Borrado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("CreadoPor")
                        .HasColumnType("int");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Estatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 11, 2, 19, 19, 20, 956, DateTimeKind.Local).AddTicks(3206));

                    b.Property<int>("ModificadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("PuestoId");

                    b.HasIndex("CreadoPor");

                    b.HasIndex("ModificadoPor");

                    b.ToTable("Puesto");
                });

            modelBuilder.Entity("IncidentApp.Model.Model.Sla", b =>
                {
                    b.Property<int>("SlaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Borrado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("CantdadHoras")
                        .HasColumnType("int");

                    b.Property<int>("CreadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Estatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 11, 2, 19, 19, 20, 994, DateTimeKind.Local).AddTicks(3158));

                    b.Property<int>("ModificadoPor")
                        .HasColumnType("int");

                    b.HasKey("SlaId");

                    b.HasIndex("CreadoPor");

                    b.HasIndex("ModificadoPor");

                    b.ToTable("Sla");
                });

            modelBuilder.Entity("IncidentApp.Model.Model.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("Borrado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("CreadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Estatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 11, 2, 19, 19, 20, 960, DateTimeKind.Local).AddTicks(8625));

                    b.Property<int>("ModificadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("PuestoID")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("IncidentApp.Model.Model.Departamento", b =>
                {
                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioC")
                        .WithMany("DepartamentosC")
                        .HasForeignKey("CreadoPor");

                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioM")
                        .WithMany("DepartamentosM")
                        .HasForeignKey("ModificadoPor")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("IncidentApp.Model.Model.HistorialIncidente", b =>
                {
                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioC")
                        .WithMany("HistorialIncidentesC")
                        .HasForeignKey("CreadoPor");

                    b.HasOne("IncidentApp.Model.Model.Incidente", "Incidente")
                        .WithMany()
                        .HasForeignKey("IncidenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioM")
                        .WithMany("HistorialIncidentesM")
                        .HasForeignKey("ModificadoPor")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("IncidentApp.Model.Model.Incidente", b =>
                {
                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioC")
                        .WithMany("IncidentesC")
                        .HasForeignKey("CreadoPor");

                    b.HasOne("IncidentApp.Model.Model.Departamento", "Departamento")
                        .WithMany("Incidentes")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioM")
                        .WithMany("IncidentesM")
                        .HasForeignKey("ModificadoPor")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IncidentApp.Model.Model.Prioridad", "Prioridad")
                        .WithMany("Incidentes")
                        .HasForeignKey("PrioridadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioA")
                        .WithMany("IncidentesA")
                        .HasForeignKey("UsuarioAsignadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioR")
                        .WithMany("IncidentesR")
                        .HasForeignKey("UsuarioReportaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("IncidentApp.Model.Model.Prioridad", b =>
                {
                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioC")
                        .WithMany("PrioridadesC")
                        .HasForeignKey("CreadoPor");

                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioM")
                        .WithMany("PrioridadesM")
                        .HasForeignKey("ModificadoPor")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IncidentApp.Model.Model.Sla", "Sla")
                        .WithMany("Prioridades")
                        .HasForeignKey("SlaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("IncidentApp.Model.Model.Puesto", b =>
                {
                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioC")
                        .WithMany("PuestosC")
                        .HasForeignKey("CreadoPor");

                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioM")
                        .WithMany("PuestosM")
                        .HasForeignKey("ModificadoPor")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("IncidentApp.Model.Model.Sla", b =>
                {
                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioC")
                        .WithMany("SlasC")
                        .HasForeignKey("CreadoPor");

                    b.HasOne("IncidentApp.Model.Model.Usuario", "UsuarioM")
                        .WithMany("SlasM")
                        .HasForeignKey("ModificadoPor")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
