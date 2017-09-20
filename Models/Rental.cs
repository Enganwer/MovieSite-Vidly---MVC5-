using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Vidly.Models
{
    public class Rental
    {
        public int id { get; set; }
        public DateTime DataRented { get; set; }

        public DateTime? DataReturned { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public Movie Movie { get; set; }

        
    }
}