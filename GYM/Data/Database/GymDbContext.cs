using GYM.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Data.Database
{
    public class GymDbContext : DbContext
    {

            #region Contructor
            public GymDbContext(DbContextOptions<GymDbContext> options)
                    : base(options)
            {

            }
            #endregion

            #region Public properties
            public DbSet<Client> Client { get; set; }
            public DbSet<Entries> Entries { get; set; }
            public DbSet<SeasonTicket> Ticket { get; set; }
            public DbSet<ClientTickets> ClientTicket { get; set; }
            public DbSet<Room> Room { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            modelBuilder.Entity<Client>().HasData(GetClients());
            modelBuilder.Entity<Entries>().HasData(GetEntries());
            modelBuilder.Entity<SeasonTicket>().HasData(GetTickets());
            modelBuilder.Entity<ClientTickets>().HasData(GetClientTickets());
            modelBuilder.Entity<Room>().HasData(GetRoom());
            base.OnModelCreating(modelBuilder);
            }
            #endregion


            #region Private methods
            private List<Client> GetClients()
            {
                return new List<Client>
    {
        new Client { ClientId = 1001, Name="Admin", Phone = "0749091739", Email="arnoldszasz06@gmail.com", IsDeleted=false,Photo="",InsertDate=DateTime.Now,IDCard="123456", Barcode="123Admin12",Comment=""}

    };
            }
        private List<SeasonTicket> GetTickets()
        {
            return new List<SeasonTicket>
    {
        new SeasonTicket {TicketId=1001, Name="Daily", Price=15.00, ValidDay="30", ValidEntries=20,Deleted=false,GymId=1001,SHour=DateTime.Now,FHour=DateTime.Now,Daily="1"},
        new SeasonTicket {TicketId=1002, Name="Morning", Price=10.00, ValidDay="30", ValidEntries=30,Deleted=false,GymId=1001,SHour=DateTime.Now,FHour=DateTime.Now,Daily="1"}

    };
        }
        private List<Entries> GetEntries()
        {
            return new List<Entries>
    {
        new Entries { EntriesId=1001, ClientId=1001,TicketId=1001,Date=DateTime.Now,Barcode="123Admin12",GymId=1001}
    };
        }
        private List<ClientTickets> GetClientTickets()
        {
            return new List<ClientTickets>
    {
        new ClientTickets { ClientTicketId=1001, ClientId=1001, TicketId=1001, Bought=DateTime.Now,Barcode="123Admin12", Entries=0, Price=15, Valid=true,FirstUse=DateTime.Now,GymId=1001}
    };
        }
        private List<Room> GetRoom()
        {
            return new List<Room>
    {
        new Room {GymId=1001, Name="18 GYM Cipariu", IsDeleted=false}
    };
        }
        #endregion

    }
}
