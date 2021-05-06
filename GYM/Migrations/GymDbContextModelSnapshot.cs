﻿// <auto-generated />
using System;
using GYM.Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GYM.Migrations
{
    [DbContext(typeof(GymDbContext))]
    partial class GymDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("GYM.Data.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Barcode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("IDCard")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .HasColumnType("TEXT");

                    b.HasKey("ClientId");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            ClientId = 1001,
                            Barcode = "123Admin12",
                            Comment = "",
                            Email = "arnoldszasz06@gmail.com",
                            IDCard = "123456",
                            InsertDate = new DateTime(2021, 5, 6, 22, 33, 5, 464, DateTimeKind.Local).AddTicks(7239),
                            IsDeleted = false,
                            Name = "Admin",
                            Phone = "0749091739",
                            Photo = ""
                        });
                });

            modelBuilder.Entity("GYM.Data.Models.ClientTickets", b =>
                {
                    b.Property<int>("ClientTicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Barcode")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Bought")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Entries")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FirstUse")
                        .HasColumnType("TEXT");

                    b.Property<int>("GymId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TicketId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Valid")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClientTicketId");

                    b.ToTable("ClientTicket");

                    b.HasData(
                        new
                        {
                            ClientTicketId = 1001,
                            Barcode = "123Admin12",
                            Bought = new DateTime(2021, 5, 6, 22, 33, 5, 471, DateTimeKind.Local).AddTicks(9373),
                            ClientId = 1001,
                            Entries = 0,
                            FirstUse = new DateTime(2021, 5, 6, 22, 33, 5, 472, DateTimeKind.Local).AddTicks(1836),
                            GymId = 1001,
                            Price = 15,
                            TicketId = 1001,
                            Valid = true
                        });
                });

            modelBuilder.Entity("GYM.Data.Models.Entries", b =>
                {
                    b.Property<int>("EntriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Barcode")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("GymId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TicketId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntriesId");

                    b.ToTable("Entries");

                    b.HasData(
                        new
                        {
                            EntriesId = 1001,
                            Barcode = "123Admin12",
                            ClientId = 1001,
                            Date = new DateTime(2021, 5, 6, 22, 33, 5, 470, DateTimeKind.Local).AddTicks(4063),
                            GymId = 1001,
                            TicketId = 1001
                        });
                });

            modelBuilder.Entity("GYM.Data.Models.Room", b =>
                {
                    b.Property<int>("GymId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("GymId");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            GymId = 1001,
                            IsDeleted = false,
                            Name = "18 GYM Cipariu"
                        });
                });

            modelBuilder.Entity("GYM.Data.Models.SeasonTicket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Daily")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FHour")
                        .HasColumnType("TEXT");

                    b.Property<int>("GymId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("SHour")
                        .HasColumnType("TEXT");

                    b.Property<string>("ValidDay")
                        .HasColumnType("TEXT");

                    b.Property<string>("ValidEntries")
                        .HasColumnType("TEXT");

                    b.HasKey("TicketId");

                    b.ToTable("Ticket");

                    b.HasData(
                        new
                        {
                            TicketId = 1001,
                            Daily = "1",
                            Deleted = false,
                            FHour = new DateTime(2021, 5, 6, 22, 33, 5, 471, DateTimeKind.Local).AddTicks(3767),
                            GymId = 1001,
                            Name = "Daily",
                            Price = 15.0,
                            SHour = new DateTime(2021, 5, 6, 22, 33, 5, 471, DateTimeKind.Local).AddTicks(3190),
                            ValidDay = "30",
                            ValidEntries = "20"
                        },
                        new
                        {
                            TicketId = 1002,
                            Daily = "1",
                            Deleted = false,
                            FHour = new DateTime(2021, 5, 6, 22, 33, 5, 471, DateTimeKind.Local).AddTicks(5053),
                            GymId = 1001,
                            Name = "Morning",
                            Price = 10.0,
                            SHour = new DateTime(2021, 5, 6, 22, 33, 5, 471, DateTimeKind.Local).AddTicks(5023),
                            ValidDay = "30",
                            ValidEntries = "30"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
