using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmniyatAirlines.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public char SeatType { get; set; }
        public double Price { get; set; }
        public string SeatNumber { get; set; }

    }
}
