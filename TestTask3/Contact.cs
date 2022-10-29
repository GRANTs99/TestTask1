using System;
using System.Security.Cryptography;
using System.Text;

namespace TestTask3
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public override int GetHashCode()
        {
            return Name.Length;
        }
        public override string ToString()
        {
            return $"{Name} {Phone}";
        }
    }
}
