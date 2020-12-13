using CryptText.Models;

namespace CryptText.Data
{
    public interface IUserManager
    {
        User GetUser(string uuid);

        bool AddUser(User user);

        bool UpdateUser(User user);

        bool DeleteUser(string uuid);
    }
}