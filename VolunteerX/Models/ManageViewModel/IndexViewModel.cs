using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerX.Models.ManageViewModel
{
    public class IndexViewModel
    {
        public Project Project { get; set; }
        public IEnumerable<TypeOfProject> TypesOfProject { get; set; }
        public IEnumerable<SectionOfProject> SectionsOfProject { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<string> FiltersOfState { get; set; }
    }
}
