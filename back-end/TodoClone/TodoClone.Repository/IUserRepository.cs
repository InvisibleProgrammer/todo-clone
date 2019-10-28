using TodoClone.Domain;

namespace TodoClone.Repository
{
    public interface IUserRepository
    {
        User GetUserById(int userId);
    }
}
