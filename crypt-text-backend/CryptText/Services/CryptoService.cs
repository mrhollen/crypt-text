using System.Security.Cryptography;
using System.Text;
using CryptText.Models;

namespace CryptText.Services
{
    public class CryptoService
    {
        public Hash GetHash(string input)
        {
            using (var hash = SHA256.Create()) 
            {
                return new Hash(hash.ComputeHash(Encoding.ASCII.GetBytes(input)));
            }
        }
    }
}