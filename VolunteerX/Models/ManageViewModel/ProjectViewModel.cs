using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolunteerX.Models;

namespace VolunteerX.Models.ProjectViewModel
{
    public class ProjectViewModel
    {
        public Group Group { get; set; }
        public Message Message { get; set; }
        public Project Project { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<Message> Messages { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}
