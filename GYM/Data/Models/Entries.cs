using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Data.Models
{
    public class Entries
    {
        [Key]
        public int EntriesId { get; set; }
        public int ClientId { get; set; }
        public int TicketId { get; set; }
        public DateTime Date { get; set; }
        public string Barcode { get; set; }
        public int GymId { get; set; }
    }
}
