using GYM.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Data.Database
{
    public class GymServices
    {

            #region Private members
            private GymDbContext dbContext;
            #endregion

            #region Constructor
            public GymServices(GymDbContext dbContext)
            {
                this.dbContext = dbContext;
            }
            #endregion

            #region Public methods

        //Client
            public async Task<List<Client>> GetClientAsync()
            {
                return await dbContext.Client.ToListAsync();
            }

            public async Task<Client> AddClientAsync(Client client)
            {
                try
                {
                    dbContext.Client.Add(client);
                    await dbContext.SaveChangesAsync();
                }
                catch (Exception)
                {
                    throw;
                }
                return client;
            }

            public async Task<Client> UpdateClientAsync(Client client)
            {
                try
                {
                    var ClienttExist = dbContext.Client.FirstOrDefault(p => p.ClientId == client.ClientId);
                    if (ClienttExist != null)
                    {
                        dbContext.Update(client);
                        await dbContext.SaveChangesAsync();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return client;
            }


            public async Task DeleteClientAsync(Client client)
            {
                try
                {
                    dbContext.Client.Remove(client);
                    await dbContext.SaveChangesAsync();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        //Entries
        public async Task<List<Entries>> GetEntriesAsync()
        {
            return await dbContext.Entries.ToListAsync();
        }

        public async Task<Entries> AddEntriesAsync(Entries entries)
        {
            try
            {
                dbContext.Entries.Add(entries);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return entries;
        }
        //Tickets
        public async Task<List<SeasonTicket>> GetTicketAsync()
        {
            return await dbContext.Ticket.ToListAsync();
        }

        public async Task<SeasonTicket> AddTicketAsync(SeasonTicket ticket)
        {
            try
            {
                dbContext.Ticket.Add(ticket);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return ticket;
        }

        public async Task<SeasonTicket> UpdateTicketAsync(SeasonTicket ticket)
        {
            try
            {
                var ticketExist = dbContext.Ticket.FirstOrDefault(p => p.TicketId == ticket.TicketId);
                if (ticketExist != null)
                {
                    dbContext.Update(ticket);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return ticket;
        }


        public async Task DeleteTicketAsync(SeasonTicket ticket)
        {
            try
            {
                dbContext.Ticket.Remove(ticket);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Room
        public async Task<List<Room>> GetRoomAsync()
        {
            return await dbContext.Room.ToListAsync();
        }

        //ClientTickets
        public async Task<List<ClientTickets>> GetClientTicketsAsync()
        {
            return await dbContext.ClientTicket.ToListAsync();
        }

        public async Task<ClientTickets> AddClientTicketsAsync(ClientTickets ticket)
        {
            try
            {
                dbContext.ClientTicket.Add(ticket);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return ticket;
        }

        public async Task<ClientTickets> UpdateClientTicketsAsync(ClientTickets ticket)
        {
            try
            {
                var tickettExist = dbContext.ClientTicket.FirstOrDefault(p => p.ClientTicketId == ticket.ClientTicketId);
                if (tickettExist != null)
                {
                    dbContext.Update(ticket);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return ticket;
        }


        public async Task DeleteClientTicketsAsync(ClientTickets ticket)
        {
            try
            {
                dbContext.ClientTicket.Remove(ticket);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }


        #endregion
    }
   
}
