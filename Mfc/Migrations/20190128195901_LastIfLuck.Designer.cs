﻿// <auto-generated />
using Mfc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mfc.Migrations
{
    [DbContext(typeof(MfcContext))]
    [Migration("20190128195901_LastIfLuck")]
    partial class LastIfLuck
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mfc.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("NomeCurso");

                    b.Property<int>("TrabalhoId");

                    b.HasKey("Id");

                    b.HasIndex("TrabalhoId");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("Mfc.Models.Trabalho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeTrabalho");

                    b.HasKey("Id");

                    b.ToTable("Trabalho");
                });

            modelBuilder.Entity("Mfc.Models.Curso", b =>
                {
                    b.HasOne("Mfc.Models.Trabalho", "Trabalho")
                        .WithMany()
                        .HasForeignKey("TrabalhoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
