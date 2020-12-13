using System.Collections.Generic;
using CryptText.Models;

namespace CryptText.Data.InMemory
{
    public class UserManager : IUserManager
    {
        private readonly Dictionary<string, User> users = new Dictionary<string, User>();

        public bool AddUser(User user)
        {
            return users.TryAdd(user.Uuid, user);
        }

        public bool DeleteUser(string uuid)
        {
            if (users.ContainsKey(uuid))
            {
                users.Remove(uuid);
                return true;
            }

            return false;
        }

        public User GetUser(string uuid)
        {
            try 
            {
                return users[uuid];
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateUser(User user)
        {
            var uuid = user.Uuid;

            if (users.ContainsKey(uuid))
            {
                users[uuid] = user;
                return true;
            }
            
            return false;
        }
    }
}