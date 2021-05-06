using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GYM.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Photo = table.Column<string>(type: "TEXT", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IDCard = table.Column<string>(type: "TEXT", nullable: true),
                    Barcode = table.Column<string>(type: "TEXT", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "ClientTicket",
                columns: table => new
                {
                    ClientTicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false),
                    Bought = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Barcode = table.Column<string>(type: "TEXT", nullable: true),
                    Entries = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    Valid = table.Column<bool>(type: "INTEGER", nullable: false),
                    FirstUse = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GymId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTicket", x => x.ClientTicketId);
                });

            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    EntriesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Barcode = table.Column<string>(type: "TEXT", nullable: true),
                    GymId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.EntriesId);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    GymId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.GymId);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    ValidDay = table.Column<string>(type: "TEXT", nullable: true),
                    ValidEntries = table.Column<string>(type: "TEXT", nullable: true),
                    Deleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    GymId = table.Column<int>(type: "INTEGER", nullable: false),
                    SHour = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FHour = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Daily = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketId);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Barcode", "Comment", "Email", "IDCard", "InsertDate", "IsDeleted", "Name", "Phone", "Photo" },
                values: new object[] { 1001, "123Admin12", "", "arnoldszasz06@gmail.com", "123456", new DateTime(2021, 5, 6, 22, 33, 5, 464, DateTimeKind.Local).AddTicks(7239), false, "Admin", "0749091739", "" });

            migrationBuilder.InsertData(
                table: "ClientTicket",
                columns: new[] { "ClientTicketId", "Barcode", "Bought", "ClientId", "Entries", "FirstUse", "GymId", "Price", "TicketId", "Valid" },
                values: new object[] { 1001, "123Admin12", new DateTime(2021, 5, 6, 22, 33, 5, 471, DateTimeKind.Local).AddTicks(9373), 1001, 0, new DateTime(2021, 5, 6, 22, 33, 5, 472, DateTimeKind.Local).AddTicks(1836), 1001, 15, 1001, true });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "EntriesId", "Barcode", "ClientId", "Date", "GymId", "TicketId" },
                values: new object[] { 1001, "123Admin12", 1001, new DateTime(2021, 5, 6, 22, 33, 5, 470, DateTimeKind.Local).AddTicks(4063), 1001, 1001 });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "GymId", "IsDeleted", "Name" },
                values: new object[] { 1001, false, "18 GYM Cipariu" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "TicketId", "Daily", "Deleted", "FHour", "GymId", "Name", "Price", "SHour", "ValidDay", "ValidEntries" },
                values: new object[] { 1001, "1", false, new DateTime(2021, 5, 6, 22, 33, 5, 471, DateTimeKind.Local).AddTicks(3767), 1001, "Daily", 15.0, new DateTime(2021, 5, 6, 22, 33, 5, 471, DateTimeKind.Local).AddTicks(3190), "30", "20" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "TicketId", "Daily", "Deleted", "FHour", "GymId", "Name", "Price", "SHour", "ValidDay", "ValidEntries" },
                values: new object[] { 1002, "1", false, new DateTime(2021, 5, 6, 22, 33, 5, 471, DateTimeKind.Local).AddTicks(5053), 1001, "Morning", 10.0, new DateTime(2021, 5, 6, 22, 33, 5, 471, DateTimeKind.Local).AddTicks(5023), "30", "30" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "ClientTicket");

            migrationBuilder.DropTable(
                name: "Entries");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
