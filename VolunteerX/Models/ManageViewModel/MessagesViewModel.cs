using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerX.Models.ManageViewModel
{
    public class MessagesViewModel
    {
        public Message Message { get; set; }
        public List<Message> Messages { get; set; }
        public List<Project> Projects { get; set; }
    }
}
