﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RickLocalization.Data.Context;

namespace RickLocalization.Data.Migrations
{
    [DbContext(typeof(RickLocalizationDbContext))]
    [Migration("20201026061712_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RickLocalization.Model.BrowsingHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DimensionFromId")
                        .HasColumnType("int");

                    b.Property<int>("DimensionToId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DimensionFromId");

                    b.HasIndex("DimensionToId");

                    b.ToTable("BrowsingHistory");
                });

            modelBuilder.Entity("RickLocalization.Model.Dimension", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dimension");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2020, 10, 26, 3, 17, 12, 20, DateTimeKind.Local).AddTicks(1285),
                            Description = "A Dimensão 35-C é um mundo muito colorido, cheio de um céu amarelo e criaturas bizarras e de aparência estranha. Vários planetas, um que lembra muito Saturno, parecem estar muito próximos da Terra desta dimensão, como são claramente visíveis durante o dia.",
                            Image = "",
                            Name = "35-C"
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2020, 10, 26, 3, 17, 12, 21, DateTimeKind.Local).AddTicks(2515),
                            Description = "A dimensão C-137 é um dos muitos universos no multiverso e no universo onde os Rick e Morty são frequentemente identificados como provenientes. Dado que Rick não lista seu genro adotivo Jerry como originário da mesma dimensão que ele, a dimensão C-137 é o universo em que a Terra foi invadida por Cronenbergs em \"Rick Potion # 9\".",
                            Image = "",
                            Name = "C-137"
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2020, 10, 26, 3, 17, 12, 21, DateTimeKind.Local).AddTicks(2546),
                            Description = "A dimensão C-132 é um dos muitos universos no multiverso e foi o universo em que Rick e Morty dos dois primeiros volumes da série de quadrinhos Rick e Morty foram considerados, que é separado da corrente principal de Rick e Morty , que é da Dimensão C-137 . A série mudaria o foco para Rick e Morty da Dimensão C-137 após a Edição # 10, com o destino da Dimensão C-132 sendo revelado entre as Questões # 12-14.",
                            Image = "",
                            Name = "C-132"
                        });
                });

            modelBuilder.Entity("RickLocalization.Model.BrowsingHistory", b =>
                {
                    b.HasOne("RickLocalization.Model.Dimension", "DimensionFrom")
                        .WithMany("BrowsingHistoriesFrom")
                        .HasForeignKey("DimensionFromId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RickLocalization.Model.Dimension", "DimensionTo")
                        .WithMany("BrowsingHistoriesTo")
                        .HasForeignKey("DimensionToId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
