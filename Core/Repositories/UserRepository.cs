using DigitopiaQuest.Areas.Identity.Data;
using DigitopiaQuest.Data;

namespace DigitopiaQuest.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DigitopiaQuestContext _digitopiaQuestContext;

        public UserRepository(DigitopiaQuestContext digitopiaQuestContext)
        {
            _digitopiaQuestContext = digitopiaQuestContext;
        }

        public DigitopiaQuestUser GetUser(string id)
        {
            return _digitopiaQuestContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public DigitopiaQuestUser UpdateUser(DigitopiaQuestUser user)
        {
            _digitopiaQuestContext.Update(user);
            _digitopiaQuestContext.SaveChanges();

            return user;
        }

        ICollection<DigitopiaQuestUser> IUserRepository.GetUsers()
        {
            return _digitopiaQuestContext.Users.ToList();
        }
    }
}
