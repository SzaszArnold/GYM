using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Data.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public string Photo { get; set; }
        public DateTime InsertDate { get; set; }
        public string IDCard { get; set; }
        public string Barcode { get; set; }
        public string Comment { get; set; }
    }
}
