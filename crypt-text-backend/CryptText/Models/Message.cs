using System;

namespace CryptText.Models
{
    public class Message
    {
        public User From { get; }

        public User To { get; }

        public DateTime TimeStamp { get; }

        public string Text { get; }

        public string Signature { get; }

        public bool Read { get; set; }

        public DateTime ReadTime { get; set; }
    }
}