using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmniyatAirlines.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Nationality { get; set; }
        public string PassportNo { get; set; }
    }
}
