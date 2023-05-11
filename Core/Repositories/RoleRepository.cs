using DigitopiaQuest.Areas.Identity.Data;
using DigitopiaQuest.Data;
using Microsoft.AspNetCore.Identity;

namespace DigitopiaQuest.Core.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DigitopiaQuestContext _context;

        public RoleRepository(DigitopiaQuestContext context)
        {
            _context = context;
        }

        public ICollection<IdentityRole> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
