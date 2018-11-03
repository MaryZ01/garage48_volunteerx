using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerX.Models
{
    public class Promotion
    {
        public int Id { get; set; }

        public bool PaymentOfRoad { get; set; }
        public bool PaymentOfAccommodation { get; set; }
        public bool PaymentOfFood { get; set; }
        public bool Reward { get; set; }
    }
}
