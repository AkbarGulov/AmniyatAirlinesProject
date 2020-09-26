using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmniyatAirlines.Models
{
    public class Flight
    {
        [Key]
        public int Id { get; set; } 
        public int From { get; set; }
        public int To { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int AirplaneId { get; set; }


    }
}
