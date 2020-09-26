using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmniyatAirlines.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int FlightId { get; set; }
        public int TicketId { get; set; }
        public DateTime Time { get; set; }
    }
}
