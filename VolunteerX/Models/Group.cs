using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerX.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int CountOfVolunteers { get; set; }
        public int MaxOfVolunteers { get; set; }
        public List<Volunteer> Volunteers { get; set; }
        public List<TaskOfVolunteer> TaskOfVolunteers { get; set; }
        public List<Message> Messages { get; set; }
    }
}
