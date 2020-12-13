using System;
using System.Linq;
using System.Text;

namespace CryptText.Models
{
    public class Hash
    {
        public byte[] rawValue { get; }

        public override bool Equals(object obj)
        {
            var value = obj as Hash;
            return rawValue.ToString() == value.rawValue.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(Hash valueA, Hash valueB)
        {
            return valueA.Equals(valueB);
        }

        public static bool operator !=(Hash valueA, Hash valueB)
        {
            return !valueA.Equals(valueB);
        }

        public Hash(params byte[] data) 
        {
            this.rawValue = data;
        }

        public Hash(string input)
        {
            rawValue = Enumerable.Range(0, input.Length)
                        .Where(x => x % 2 == 0)
                        .Select(x => Convert.ToByte(input.Substring(x, 2), 16))
                        .ToArray();
        }
    }
}