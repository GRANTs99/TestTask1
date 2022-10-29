using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask3
{
    public class Item
    {
        public int Key { get; set; }
        public List<Contact> Nodes { get; set; }

        public Item(int key)
        {
            Key = key;
            Nodes = new List<Contact>();
        }
    }
}
