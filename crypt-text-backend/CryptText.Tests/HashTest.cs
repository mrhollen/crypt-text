using System;
using CryptText.Models;
using Xunit;

namespace CryptText.Tests
{
    public class HashTest
    {
        [Fact]
        public void Equals_CanGetEquals()
        {
            var hashA = new Hash(0x0, 0x1, 0x2, 0x3);
            var hashB = new Hash(0x0, 0x1, 0x2, 0x3);

            var areEqual = hashA == hashB;
            var areNotEqual = hashA != hashB;

            Assert.True(areEqual);
            Assert.False(areNotEqual);
        }

        [Fact]
        public void Equals_CanGetNotEquals()
        {
            var hashA = new byte[]{0x0, 0x1, 0x2, 0x3};
            var hashB = new byte[]{0x0, 0x1, 0xF, 0x3};

            var areEqual = hashA == hashB;
            var areNotEqual = hashA != hashB;

            Assert.False(areEqual);
            Assert.True(areNotEqual);
        }

        [Fact]
        public void Constructor_CanConstructWithByteParams()
        {
            var hash = new Hash(0xff, 0x55, 0x11);

            Assert.Equal(hash.rawValue[0], 0xff);
            Assert.Equal(hash.rawValue[1], 0x55);
            Assert.Equal(hash.rawValue[2], 0x11);
        }

        [Fact]
        public void Constructor_CanConstructWithString()
        {
            var hash = new Hash("61e2f5ad1114475b38e9");

            var expectedHash = new Hash(0x61, 0xe2, 0xf5, 0xad, 0x11, 0x14, 0x47, 0x5b, 0x38, 0xe9);

            Assert.Equal(hash, expectedHash);
        }
    }
}
