using Microsoft.AspNetCore.Identity;

namespace DigitopiaQuest.Core.Repositories
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}
