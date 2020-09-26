using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmniyatAirlines.Models
{
    public class Airplane
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int BSeatCount { get; set; }
        public int ESeatCount { get; set; }
    }
}
