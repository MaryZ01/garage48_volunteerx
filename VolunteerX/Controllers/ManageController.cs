using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VolunteerX.Models;
using VolunteerX.Models.ManageViewModel;
using VolunteerX.Models.ProjectViewModel;
using VolunteerX.Services;

namespace VolunteerX.Controllers
{
    public class ManageController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IGenericRepository<ApplicationUser> _usersRepository;
        private readonly IGenericRepository<Project> _projectsRepository;
        private readonly IGenericRepository<SectionOfProject> _sectionsRepository;
        private readonly IGenericRepository<TypeOfProject> _typesRepository;

        public ManageController(
            UserManager<ApplicationUser> userManager,
            IGenericRepository<ApplicationUser> usersRepository,
            IGenericRepository<Project> projectsRepository,
            IGenericRepository<SectionOfProject> sectionsRepository,
            IGenericRepository<TypeOfProject> typesRepository)
        {
            _userManager = userManager;
            _usersRepository = usersRepository;
            _projectsRepository = projectsRepository;
            _sectionsRepository = sectionsRepository;
            _typesRepository = typesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ApplicationUser user = await _userManager.GetUserAsync(User);

            IndexViewModel model = new IndexViewModel
            {
                Projects = _projectsRepository.Get(x => x.UserId == user.Id) ?? Enumerable.Empty<Project>(),
                SectionsOfProject = _sectionsRepository.Get() ?? Enumerable.Empty<SectionOfProject>(),
                TypesOfProject = _typesRepository.Get() ?? Enumerable.Empty<TypeOfProject>(),
                FiltersOfState = new List<string> { "У виконанні", "Завершенно" }
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult MainVolunteers(string manageProjectId)
        {
            ProjectViewModel model = new ProjectViewModel
            {
                Project = _projectsRepository.Get(x => x.Id == int.Parse(manageProjectId)).FirstOrDefault()
            };

            return View(model);
        }
    }
}