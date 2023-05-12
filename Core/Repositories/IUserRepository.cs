using DigitopiaQuest.Areas.Identity.Data;
using DigitopiaQuest.Core.Repositories;

namespace DigitopiaQuest.Core.Repositories
{
    public interface IUserRepository
    {
        ICollection<DigitopiaQuestUser> GetUsers();
        DigitopiaQuestUser GetUser(string id);
        DigitopiaQuestUser UpdateUser(DigitopiaQuestUser user);
    }
}
