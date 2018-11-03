using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerX.Models
{
    public class CriteriaOfVolunteer
    {
        public int Id { get; set; }

        public int Age { get; set; }
        public TypeOfGender Gender { get; set; }
        public int Rating { get; set; }
        public SkillsOfVolunteer SkillsOfVolunteer { get; set; }
    }
}
