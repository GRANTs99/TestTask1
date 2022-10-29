using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask3
{
    public class ContactManager
    {
        private HashTable HashTable;

        public ContactManager(int size)
        {
            HashTable = new HashTable(size);
        }
        public Contact FindContact(string name)
        {
            var contact = new Contact { Name = name};
            return HashTable.Search(contact);
        }
        public void AddContact(string name, string phone)
        {
            var contact = new Contact { Name = name, Phone = phone };
            HashTable.Add(contact);
        }
        public void DeleteContact(string name)
        {
            var contact = FindContact(name);
            HashTable.Delete(contact);
        }
        public void UpdateContact(string name, string phone)
        {
            DeleteContact(name);
            AddContact(name, phone);   
        }
    }
}
