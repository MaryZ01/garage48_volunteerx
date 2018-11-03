using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using VolunteerX.Models;
using VolunteerX.Models.AccountViewModels;
using VolunteerX.Models.ManageViewModel;
using VolunteerX.Models.ProjectViewModel;
using VolunteerX.Services;

namespace VolunteerX.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IGenericRepository<Project> _projectsRepository;
        private readonly IGenericRepository<Group> _groupsRepository;
        private readonly IGenericRepository<TaskOfVolunteer> _tasksRepository;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IGenericRepository<Project> projectsRepository,
            IGenericRepository<Group> groupsRepository,
            IGenericRepository<TaskOfVolunteer> tasksRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _projectsRepository = projectsRepository;
            _groupsRepository = groupsRepository;
            _tasksRepository = tasksRepository;
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Manage");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { Name = model.Name, Surname = model.Surname, UserName = model.Email, Email = model.Email, PhoneNumber = model.PhoneNumber};
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Index", "Manage");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpPost]
        public IActionResult TaskRegister(ProjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                TaskOfVolunteer task = new TaskOfVolunteer
                {
                    Description = model.Task.Description,
                    GroupId = model.Task.GroupId,
                    Type = TypeOfTask.None
                };

                _tasksRepository.Create(task);
            }

            return RedirectToAction("Groups", "Manage", new { manageProjectId = model.ProjectId });
        }

        [HttpPost]
        public IActionResult GroupRegister(ProjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                Group group = new Group
                {
                    Name = model.Group.Name,
                    Description = model.Group.Description,
                    MaxOfVolunteers = model.Group.MaxOfVolunteers,
                    ProjectId = model.ProjectId
                };

                _groupsRepository.Create(group);
            }

            return RedirectToAction("Groups", "Manage", new { manageProjectId = model.ProjectId });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProjectRegister(IndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);

                Project project = new Project
                {
                    Name = model.Project.Name,
                    Description = model.Project.Description,
                    State = StateOfProject.None,
                    DateOfStartProject = model.Project.DateOfStartProject,
                    DateOfEndProject = model.Project.DateOfEndProject,
                    TypeOfProject = model.Project.TypeOfProject,
                    SectionOfProject = model.Project.SectionOfProject,
                    UserId = user.Id
                };

                _projectsRepository.Create(project);
            }

            return RedirectToAction("Index", "Manage");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ProjectRemove(string manageProjectId)
        {
            Project project = _projectsRepository.Get(x => x.Id == int.Parse(manageProjectId)).FirstOrDefault();
            _projectsRepository.Remove(project);

            return RedirectToAction("Index", "Manage");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Option()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Option(OptionViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.GetUserAsync(User);

                if (model.Email != null)
                {
                    user.Email = model.Email;
                    user.UserName = model.Email;
                }

                if(model.PhoneNumber != null)
                {
                    user.PhoneNumber = model.PhoneNumber;
                }

                if(model.Name != null)
                {
                    user.Name = model.Name;
                }

                if(model.Surname != null)
                {
                    user.Surname = model.Surname;
                }

                if (model.NewPassword != null)
                {
                    await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                }

                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("Option", "Account");
        }
    }
}
