using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerX.Models
{
    public enum TypeOfGender
    {
        Male = 0,
        Female = 1,
        None = 0
    }

    public class Volunteer
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public long ChatId { get; set; }
        public TypeOfGender Gender { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Rating { get; set; }
        public SkillsOfVolunteer SkillsOfVolunteer { get; set; }
        public string Resume { get; set; }
        public List<Review> Reviews { get; set; }
        public Project CurrentOfProject { get; set; }
        public List<Project> HistoryOfProjects { get; set; }
        public string Remark { get; set; }
    }
}
