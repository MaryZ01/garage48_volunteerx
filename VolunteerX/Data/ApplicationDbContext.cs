using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VolunteerX.Models;

namespace VolunteerX.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<CriteriaOfVolunteer> CriteriaOfVolunteers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<SkillsOfVolunteer> SkillsOfVolunteers { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<TaskOfVolunteer> TaskOfVolunteers { get; set; }
        public DbSet<TypeOfProject> TypeOfProjects { get; set; }
        public DbSet<SectionOfProject> SectionOfProjects { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<InProject> InProjects { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
