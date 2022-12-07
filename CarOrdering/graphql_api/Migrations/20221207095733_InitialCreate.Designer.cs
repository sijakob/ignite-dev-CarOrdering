﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using graphql_api.Data;

#nullable disable

namespace graphql_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221207095733_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("graphql_api.Models.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CarModelId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PaintId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RimId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TyreId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2c63f40d-cc3c-478f-9bd9-5f2b8c1dd056"),
                            CarModelId = new Guid("80e1c416-16d4-4184-9e61-4a4ed37ee531"),
                            PaintId = new Guid("fb21d80f-4abb-4204-bb1f-c7eed67b6891"),
                            RimId = new Guid("675a34de-3ced-4bb9-ad56-8dcca1726f64"),
                            TyreId = new Guid("28356cba-5e0a-4a80-b7e3-bcda3832a8ac")
                        },
                        new
                        {
                            Id = new Guid("d8c1ce85-abfe-4cf1-816a-067812fad36e"),
                            CarModelId = new Guid("29818ee9-5e10-4b89-84ff-0b680562aa6c"),
                            PaintId = new Guid("2b45123f-4a91-4b0d-9de1-4e397826aa3f"),
                            RimId = new Guid("4d0a8e9d-0e70-456d-bcbe-02498c273606"),
                            TyreId = new Guid("f24a6e6a-d7b5-410c-81d3-110410b1c654")
                        },
                        new
                        {
                            Id = new Guid("dc6e6363-30d4-4d5e-83ea-4d7ef8cb462a"),
                            CarModelId = new Guid("5678e537-dc28-41a8-a9c3-affb412a7d78"),
                            PaintId = new Guid("fb21d80f-4abb-4204-bb1f-c7eed67b6891"),
                            RimId = new Guid("4d0a8e9d-0e70-456d-bcbe-02498c273606"),
                            TyreId = new Guid("28356cba-5e0a-4a80-b7e3-bcda3832a8ac")
                        });
                });

            modelBuilder.Entity("graphql_api.Models.CarModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("ModelYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CarModels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80e1c416-16d4-4184-9e61-4a4ed37ee531"),
                            ModelYear = 2020,
                            Name = "XC90"
                        },
                        new
                        {
                            Id = new Guid("29818ee9-5e10-4b89-84ff-0b680562aa6c"),
                            ModelYear = 2021,
                            Name = "S90"
                        },
                        new
                        {
                            Id = new Guid("5678e537-dc28-41a8-a9c3-affb412a7d78"),
                            ModelYear = 2018,
                            Name = "V60"
                        });
                });

            modelBuilder.Entity("graphql_api.Models.Paint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PaintType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Paints");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fb21d80f-4abb-4204-bb1f-c7eed67b6891"),
                            Color = "Midnight Blue",
                            PaintType = 0
                        },
                        new
                        {
                            Id = new Guid("2b45123f-4a91-4b0d-9de1-4e397826aa3f"),
                            Color = "Space Black",
                            PaintType = 1
                        });
                });

            modelBuilder.Entity("graphql_api.Models.Rims", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Rims");

                    b.HasData(
                        new
                        {
                            Id = new Guid("675a34de-3ced-4bb9-ad56-8dcca1726f64"),
                            Name = "Dragmaster",
                            Size = 18
                        },
                        new
                        {
                            Id = new Guid("4d0a8e9d-0e70-456d-bcbe-02498c273606"),
                            Name = "Occult",
                            Size = 19
                        });
                });

            modelBuilder.Entity("graphql_api.Models.Tyres", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SeasonType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Tyres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("28356cba-5e0a-4a80-b7e3-bcda3832a8ac"),
                            Manufacturer = "Michelin",
                            SeasonType = 0
                        },
                        new
                        {
                            Id = new Guid("f24a6e6a-d7b5-410c-81d3-110410b1c654"),
                            Manufacturer = "Continental",
                            SeasonType = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
