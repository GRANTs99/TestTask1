using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask3
{
    public class HashTable
    {
        private Item[] items;

        public HashTable(int size)
        {
            items = new Item[size];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item(i);
            }
        }
        public void Add(Contact contact)
        {
            var key = GetHash(contact);
            items[key].Nodes.Add(contact);
        }
        public void Delete(Contact contact)
        {
            var key = GetHash(contact);
            items[key].Nodes.Remove(contact);
        }
        public Contact Search(Contact contact)
        {
            var key = GetHash(contact);
            return items[key].Nodes.FirstOrDefault(p => p.Name == contact.Name);
        }
        private int GetHash(Contact contact)
        {
            return contact.GetHashCode() % items.Length;
        }
    }
}
