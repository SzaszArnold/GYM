 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Data.Models
{
    public class ClientTickets
    {
        [Key]
        public int ClientTicketId { get; set; }
        public int ClientId { get; set; }
        public int TicketId { get; set; }
        public DateTime Bought { get; set; }
        public string Barcode { get; set; }
        public int Entries { get; set; }
        public double Price { get; set; }
        public bool Valid { get; set; }
        public DateTime FirstUse { get; set; }
        public int GymId { get; set; }
    }
}
