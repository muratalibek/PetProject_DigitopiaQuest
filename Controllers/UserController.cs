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
            return View(data);
        }
    }
}
