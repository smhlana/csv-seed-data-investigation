﻿// <auto-generated />
using System;
using ExcelSeedData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExcelSeedData.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211210144759_AgeRange")]
    partial class AgeRange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExcelSeedData.Data.Entities.Icd10", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AgeRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chapter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChapterDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icd103Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icd103CodeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icd10Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Number")
                        .HasColumnType("int");

                    b.Property<DateTime>("SaEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SaRevisionHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SaStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValidIcd10Asterix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValidIcd10ClinicalUse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValidIcd10Dagger")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValidIcd10Primary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValidIcd10Sequelae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WhoEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WhoFullDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoRevisionHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WhoStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Icd10Codes");

                    b.HasData(
                        new
                        {
                            Id = "bb314dc3-1d0e-4e70-b2d3-7fae76f09233",
                            Chapter = "Chapter 1",
                            Number = 1,
                            SaEndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SaStartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WhoEndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WhoStartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}