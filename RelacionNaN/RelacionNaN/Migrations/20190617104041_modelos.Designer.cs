﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RelacionNaN.Migrations
{
    [DbContext(typeof(RelacionNaNContext))]
    [Migration("20190617104041_modelos")]
    partial class modelos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RelacionNaN.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.Property<string>("NumMatricula");

                    b.HasKey("Id");

                    b.ToTable("Alumno");
                });

            modelBuilder.Entity("RelacionNaN.Models.Examen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Asignatura");

                    b.Property<int>("Codigo");

                    b.HasKey("Id");

                    b.ToTable("Examen");
                });

            modelBuilder.Entity("RelacionNaN.Models.ExamenAlumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlumnoId");

                    b.Property<int>("ExamenId");

                    b.Property<double>("Nota");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("ExamenId");

                    b.ToTable("ExamenAlumno");
                });

            modelBuilder.Entity("RelacionNaN.Models.ExamenAlumno", b =>
                {
                    b.HasOne("RelacionNaN.Models.Alumno", "Alumno")
                        .WithMany("ExamenAlumnos")
                        .HasForeignKey("AlumnoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RelacionNaN.Models.Examen", "Examen")
                        .WithMany("ExamenAlumnos")
                        .HasForeignKey("ExamenId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
