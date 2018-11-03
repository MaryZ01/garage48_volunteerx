using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolunteerX.Models;

namespace VolunteerX.Data
{
    public static class ApplicationDbContextSeed
    {
        public static async Task EnsureSeedData(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (applicationDbContext.TypeOfProjects.Count() == 0)
            {
                List<TypeOfProject> typeOfProjects = new List<TypeOfProject>
                {
                    new TypeOfProject
                    {
                        Name = "Урядовий проект"
                    },
                    new TypeOfProject
                    {
                        Name = "Комерційний проект"
                    },
                    new TypeOfProject
                    {
                        Name = "Некомерційний проект"
                    },
                    new TypeOfProject
                    {
                        Name = "Громадський проект"
                    },
                    new TypeOfProject
                    {
                        Name = "Індивідуальний проект"
                    }
                };

                applicationDbContext.AddRange(typeOfProjects);
            }

            if (applicationDbContext.SectionOfProjects.Count() == 0)
            {
                List<SectionOfProject> sectionOfProjects = new List<SectionOfProject>
                {
                    new SectionOfProject
                    {
                        Name = "Інформаційні технології"
                    },
                    new SectionOfProject
                    {
                        Name = "Спорт"
                    },
                    new SectionOfProject
                    {
                        Name = "Психологія"
                    },
                    new SectionOfProject
                    {
                        Name = "Екологія"
                    }
                };

                applicationDbContext.AddRange(sectionOfProjects);
            }

            applicationDbContext.SaveChanges();
        }
    }
}
