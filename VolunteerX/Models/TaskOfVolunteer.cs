using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerX.Models
{
    public enum TypeOfTask
    {
        None = 0,
        InProcess = 1,
        Done = 2
    }

    public class TaskOfVolunteer
    {
        public int Id { get; set; }

        public TypeOfTask Type { get; set; }
        public string Description { get; set; }
    }
}
