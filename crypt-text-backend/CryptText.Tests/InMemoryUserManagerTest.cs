using CryptText.Data;
using Xunit;

namespace CryptText.Tests
{
    public class InMemoryUserManagerTest : UserManagerTest
    {
        private IUserManager manager = new CryptText.Data.InMemory.UserManager();
        
        [Fact]
        public void CanAddUser()
        {
            TestAddUser(manager);
        }
    }
}