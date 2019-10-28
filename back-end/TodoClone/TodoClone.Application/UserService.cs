using TodoClone.Repository;

namespace TodoClone.Application
{
    public sealed class UserService : IUserService
    {
        IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Register(string userName, string password)
        {
            // Do nothing
        }
    }
}
