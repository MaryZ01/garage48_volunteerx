using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerX.Models
{
    public class Review
    {
        public int Id { get; set; }
        
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
