using Xunit;
using CryptText.Data;
using CryptText.Models;

namespace CryptText.Tests
{
    public class UserManagerTest 
    {
        public void TestAddUser(IUserManager manager)
        {
            var user = new User("a24692d8-39d8-42d9-bcd3-e4fddfff9174");

            var success = manager.AddUser(user);
            var storedUser = manager.GetUser(user.Uuid);

            Assert.True(success);
            Assert.Equal(user, storedUser);
        }
    }
}