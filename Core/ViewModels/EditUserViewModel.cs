using DigitopiaQuest.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DigitopiaQuest.Core.ViewModels
{
    public class EditUserViewModel
    {
        public DigitopiaQuestUser User { get; set; }
        public IList<SelectListItem> Roles { get; set; }
    }
}

public class DigitopiaQuestRole : IdentityRole
{

}