﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial1.Data;

#nullable disable

namespace Parcial1.Migrations
{
    [DbContext(typeof(CursoContext))]
    [Migration("20230611002518_InitilCreate")]
    partial class InitilCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("CursoEstudiante", b =>
                {
                    b.Property<int>("CursosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EstudiantesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CursosId", "EstudiantesId");

                    b.HasIndex("EstudiantesId");

                    b.ToTable("CursoEstudiante");
                });

            modelBuilder.Entity("Parcial1.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Duracion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("Parcial1.Models.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApellidoAlumno")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CursoElegido")
                        .HasColumnType("TEXT");

                    b.Property<int>("Dni")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreAlumno")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("CursoEstudiante", b =>
                {
                    b.HasOne("Parcial1.Models.Curso", null)
                        .WithMany()
                        .HasForeignKey("CursosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Parcial1.Models.Estudiante", null)
                        .WithMany()
                        .HasForeignKey("EstudiantesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
