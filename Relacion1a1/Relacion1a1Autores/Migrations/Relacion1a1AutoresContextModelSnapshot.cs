﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Relacion1a1Autores.Migrations
{
    [DbContext(typeof(Relacion1a1AutoresContext))]
    partial class Relacion1a1AutoresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Relacion1a1Autores.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nacionalidad");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("Relacion1a1Autores.Models.Biografia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutorId");

                    b.Property<DateTime>("FechaEdicion");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("AutorId")
                        .IsUnique();

                    b.ToTable("Biografia");
                });

            modelBuilder.Entity("Relacion1a1Autores.Models.Biografia", b =>
                {
                    b.HasOne("Relacion1a1Autores.Models.Autor", "Autor")
                        .WithOne("Biografia")
                        .HasForeignKey("Relacion1a1Autores.Models.Biografia", "AutorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
