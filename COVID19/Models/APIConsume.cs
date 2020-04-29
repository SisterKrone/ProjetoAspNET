using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
  
namespace APIConsume.Models
{
    public class Reservation
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public int Confirmed { get; set; }
        public int Deaths { get; set; }
        public int Recovered { get; set; }
        public int Active { get; set; }
        public string Date { get; set; }
    }
}