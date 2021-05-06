using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Data.Models
{
    public class Room
    {
        [Key]
        public int GymId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

    }
}

