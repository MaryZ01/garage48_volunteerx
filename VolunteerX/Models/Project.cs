﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerX.Models
{
    public enum StateOfProject
    {
        None = 0,
        InProcess = 1,
        Done = 2
    }

    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CountOfVolunteers { get; set; }
        public DateTime DateOfProject { get; set; }
        public string LocationOfProject { get; set; }
        public TypeOfProject TypeOfProject { get; set; }
        public SectionOfProject SectionOfProject { get; set; }
        public CriteriaOfVolunteer CriteriaOfVolunteer { get; set; }
        public Promotion Promotions { get; set; }
        public ApplicationUser User { get; set; }
        public List<Volunteer> InProject { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Group> Groups { get; set; }
        public StateOfProject State { get; set; }
    }
}
