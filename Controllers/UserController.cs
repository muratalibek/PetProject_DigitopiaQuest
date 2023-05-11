using DigitopiaQuest.Areas.Identity.Data;
using DigitopiaQuest.Core.Repositories;
using DigitopiaQuest.Core.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DigitopiaQuest.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<DigitopiaQuestUser> _signInManager;
        public UserController(IUnitOfWork unitOfWork, SignInManager<DigitopiaQuestUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            var users = _unitOfWork.User.GetUsers();
            return View(users);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var user = _unitOfWork.User.GetUser(id);
            var roles = _unitOfWork.Role.GetRoles();

            var userRoles = await _signInManager.UserManager.GetRolesAsync(user);

            var roleItems = roles.Select(role => 
                new SelectListItem(
                    role.Name, 
                    role.Id, 
                userRoles.Any(ur => ur.Contains(role.Name)))).ToList();

            var vm = new EditUserViewModel
            {
                User = user,
                Roles = roleItems
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> OnPostAsync(EditUserViewModel data)
        {
            var user = _unitOfWork.User.GetUser(data.User.Id);
            if(user == null)
            {
                return NotFound();
            }

            var userRolesInDb = await _signInManager.UserManager.GetRolesAsync(user);
            //Loop through the roles in ViewModel
            //Check if the Role is Assigned in DB
            //If assigned -> do something
            //if not assigned -> add role

            //var rolesToAdd = new List<string>();
            //var rolesToRemove = new List<string>();

            foreach(var role in data.Roles)
            {
                var assignedInDb = userRolesInDb.FirstOrDefault(ur => ur == role.Text);
                if (role.Selected)
                {
                    if(assignedInDb == null)
                    {
                        //rolesToAdd.Add(role.Text);
                        await _signInManager.UserManager.AddToRoleAsync(user, role.Text);
                        //Add the Role
                    }
                }
                else
                {
                    if(assignedInDb  != null)
                    {
                        //rolesToRemove.Add(role.Text);
                        await _signInManager.UserManager.RemoveFromRoleAsync(user, role.Text);
                        //Remove the role
                    }
                }
            }
            //if (rolesToAdd.Any())
            //{
            //    await _signInManager.UserManager.AddToRoleAsync(user, rolesToAdd);
            //}
            //if (rolesToRemove.Any())
            //{
            //    await _signInManager.UserManager.RemoveFromRoleAsync(user, rolesToRemove);
            //}

            user.FirstNameOfUser = data.User.FirstNameOfUser;
            user.LastNameOfUser = data.User.LastNameOfUser;
            user.Email = data.User.Email;

            _unitOfWork.User.UpdateUser(user);

            return RedirectToAction("Edit", new {id = user.Id});
        }
    }
}
