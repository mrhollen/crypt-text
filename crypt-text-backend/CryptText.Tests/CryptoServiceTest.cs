using CryptText.Models;
using CryptText.Services;
using Xunit;

namespace CryptText.Tests
{
    public class CryptoServiceTest
    {
        private CryptoService service = new CryptoService();

        [Theory,
        InlineData("House of Doom", "61e2f5ad1114475b38e9e190a4a78302a8cf05e66b7a7344427f0781145a9a11"),
        InlineData("Hello World", "a591a6d40bf420404a011733cfb7b190d62c65bf0bcda32b57b277d9ad9f146e")]
        public void ComputerHash_CanHashString(string stringToHash, string expectedHashString)
        {
            var expectedHash = new Hash(expectedHashString);

            var hash = service.GetHash(stringToHash);

            Assert.Equal(expectedHash, hash);
        }

        [Fact]
        public void ComputeHash_HashIsConsistent()
        {
            var stringToHash = "Hello World";

            var hashA = service.GetHash(stringToHash);
            var hashB = service.GetHash(stringToHash);

            Assert.Equal(hashA, hashB);
        }
    }
}