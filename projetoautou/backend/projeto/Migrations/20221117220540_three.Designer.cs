﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Site;

#nullable disable

namespace projeto.Migrations
{
    [DbContext(typeof(BaseDeDados))]
    [Migration("20221117220540_three")]
    partial class three
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Site.Colaborador", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cargo")
                        .HasColumnType("TEXT");

                    b.Property<string>("departamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<long>("matricula")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("sobrenome")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Colaborador");
                });

            modelBuilder.Entity("Site.Contador", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("idColaborador")
                        .HasColumnType("INTEGER");

                    b.Property<long>("idReacoes")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Contador");
                });

            modelBuilder.Entity("Site.Reacoes", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("colaboracao")
                        .HasColumnType("INTEGER");

                    b.Property<long>("excelenteTrabalho")
                        .HasColumnType("INTEGER");

                    b.Property<long>("like")
                        .HasColumnType("INTEGER");

                    b.Property<long>("orgulho")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Reacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
