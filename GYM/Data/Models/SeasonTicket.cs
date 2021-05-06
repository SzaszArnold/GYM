using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Data.Models
{
    public class SeasonTicket
    {
        [Key]
        public int TicketId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ValidDay { get; set; }
        public string ValidEntries { get; set; }
        public bool Deleted { get; set; }
        public int GymId { get; set; }
        public DateTime SHour { get; set; }
        public DateTime FHour { get; set; }
        public string Daily { get; set; }
    }
}
