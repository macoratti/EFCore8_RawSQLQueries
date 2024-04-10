﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mvc_SqlRaw.Context;

#nullable disable

namespace Mvc_SqlRaw.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240408122056_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mvc_SqlRaw.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlunoId"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("DataMatricula")
                        .HasColumnType("date");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlunoId");

                    b.HasIndex("CursoId");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            Ativo = true,
                            Cidade = "Santos",
                            CursoId = 1,
                            DataMatricula = new DateOnly(2024, 2, 14),
                            Nome = "João"
                        },
                        new
                        {
                            AlunoId = 2,
                            Ativo = true,
                            Cidade = "Guarujá",
                            CursoId = 1,
                            DataMatricula = new DateOnly(2024, 2, 10),
                            Nome = "Maria"
                        },
                        new
                        {
                            AlunoId = 3,
                            Ativo = false,
                            Cidade = "Guarujá",
                            CursoId = 2,
                            DataMatricula = new DateOnly(2024, 1, 24),
                            Nome = "Pedro"
                        },
                        new
                        {
                            AlunoId = 4,
                            Ativo = true,
                            Cidade = "Bertioga",
                            CursoId = 2,
                            DataMatricula = new DateOnly(2024, 3, 5),
                            Nome = "Ana"
                        },
                        new
                        {
                            AlunoId = 5,
                            Ativo = true,
                            Cidade = "Santos",
                            CursoId = 3,
                            DataMatricula = new DateOnly(2024, 2, 10),
                            Nome = "Carlos"
                        },
                        new
                        {
                            AlunoId = 6,
                            Ativo = false,
                            Cidade = "Bertioga",
                            CursoId = 3,
                            DataMatricula = new DateOnly(2024, 3, 7),
                            Nome = "Mariana"
                        },
                        new
                        {
                            AlunoId = 7,
                            Ativo = true,
                            Cidade = "Santos",
                            CursoId = 4,
                            DataMatricula = new DateOnly(2024, 1, 30),
                            Nome = "Lucas"
                        },
                        new
                        {
                            AlunoId = 8,
                            Ativo = true,
                            Cidade = "Santos",
                            CursoId = 4,
                            DataMatricula = new DateOnly(2024, 2, 11),
                            Nome = "Juliana"
                        },
                        new
                        {
                            AlunoId = 9,
                            Ativo = false,
                            Cidade = "Peruíbe",
                            CursoId = 1,
                            DataMatricula = new DateOnly(2024, 3, 9),
                            Nome = "Rodrigo"
                        },
                        new
                        {
                            AlunoId = 10,
                            Ativo = true,
                            Cidade = "Santos",
                            CursoId = 2,
                            DataMatricula = new DateOnly(2024, 1, 30),
                            Nome = "Fernanda"
                        });
                });

            modelBuilder.Entity("Mvc_SqlRaw.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly?>("Inicio")
                        .HasColumnType("date");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Inicio = new DateOnly(2024, 3, 1),
                            Nome = "Inglês"
                        },
                        new
                        {
                            Id = 2,
                            Inicio = new DateOnly(2024, 3, 2),
                            Nome = "Matemática"
                        },
                        new
                        {
                            Id = 3,
                            Inicio = new DateOnly(2024, 3, 1),
                            Nome = "Ciências"
                        },
                        new
                        {
                            Id = 4,
                            Inicio = new DateOnly(2024, 3, 1),
                            Nome = "Química"
                        },
                        new
                        {
                            Id = 5,
                            Inicio = new DateOnly(2024, 6, 2),
                            Nome = "Música"
                        });
                });

            modelBuilder.Entity("Mvc_SqlRaw.Models.Aluno", b =>
                {
                    b.HasOne("Mvc_SqlRaw.Models.Curso", "Curso")
                        .WithMany("Alunos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("Mvc_SqlRaw.Models.Curso", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
