namespace CryptText.Models
{
    public class User
    {
        public string Uuid { get; }

        public User(string uuid)
        {
            Uuid = uuid;
        }
    }
}