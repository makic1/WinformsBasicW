﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StageManagmentTwo;

#nullable disable

namespace StageManagmentTwo.Migrations
{
    [DbContext(typeof(DbContextStageManagmentTwo))]
    [Migration("20240913075813_First migration")]
    partial class Firstmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StageManagmentTwo.Entities.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("HashPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AccountId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("StageManagmentTwo.Entities.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"));

                    b.Property<int>("ArtistCategorie")
                        .HasColumnType("int");

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("StageManagmentTwo.Entities.Performance", b =>
                {
                    b.Property<int>("PerfomanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PerfomanceId"));

                    b.Property<DateTime>("EndPerformance")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("ProgramStageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SartPerformance")
                        .HasColumnType("datetime2");

                    b.HasKey("PerfomanceId");

                    b.HasIndex("ProgramStageId");

                    b.ToTable("Performances");
                });

            modelBuilder.Entity("StageManagmentTwo.Entities.ProgramStage", b =>
                {
                    b.Property<int>("ProgramStageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgramStageId"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<decimal?>("EndPaidEuro")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("PriceEuro")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("StartPaidEuro")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ProgramStageId");

                    b.HasIndex("ArtistId");

                    b.ToTable("ProgramStages");
                });

            modelBuilder.Entity("StageManagmentTwo.Entities.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"));

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("CustomerCategorie")
                        .HasColumnType("int");

                    b.Property<string>("CustomerCountry")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CustomerFirstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerLastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CustomerPLZ")
                        .HasColumnType("int");

                    b.Property<int?>("PayedPriceEuro")
                        .HasPrecision(10, 2)
                        .HasColumnType("int");

                    b.Property<int>("PerformancePerfomanceId")
                        .HasColumnType("int");

                    b.Property<int>("PriceEuro")
                        .HasPrecision(10, 2)
                        .HasColumnType("int");

                    b.Property<int>("ProgramStageId")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<int>("SeatRow")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("PerformancePerfomanceId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("StageManagmentTwo.Entities.Performance", b =>
                {
                    b.HasOne("StageManagmentTwo.Entities.ProgramStage", "ProgramStage")
                        .WithMany("Performances")
                        .HasForeignKey("ProgramStageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProgramStage");
                });

            modelBuilder.Entity("StageManagmentTwo.Entities.ProgramStage", b =>
                {
                    b.HasOne("StageManagmentTwo.Entities.Artist", "Artist")
                        .WithMany("ProgramStages")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("StageManagmentTwo.Entities.Ticket", b =>
                {
                    b.HasOne("StageManagmentTwo.Entities.Performance", "Performance")
                        .WithMany("Tickets")
                        .HasForeignKey("PerformancePerfomanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performance");
                });

            modelBuilder.Entity("StageManagmentTwo.Entities.Artist", b =>
                {
                    b.Navigation("ProgramStages");
                });

            modelBuilder.Entity("StageManagmentTwo.Entities.Performance", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("StageManagmentTwo.Entities.ProgramStage", b =>
                {
                    b.Navigation("Performances");
                });
#pragma warning restore 612, 618
        }
    }
}
