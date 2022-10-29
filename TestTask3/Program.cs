using TestTask3;
var contactManager = new ContactManager(20);
while (true)
{
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Find");
    Console.WriteLine("3 - Delete");
    Console.WriteLine("4 - Update");
    int n = int.Parse(Console.ReadLine());
    string name;
    string phone;
    Contact contact;
    switch (n)
    {
        case 1:
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Phone:");
            phone = Console.ReadLine();
            contactManager.AddContact(name, phone);
            break;
        case 2:
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            contact = contactManager.FindContact(name);
            if (contact == null)
            {
                Console.WriteLine("Not exist");
            }
            else
            {
                Console.WriteLine($"Phone: {contact.Phone}");
            }
            break;
        case 3:
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            contactManager.DeleteContact(name);
            break;
        case 4:
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Phone:");
            phone = Console.ReadLine();
            contactManager.UpdateContact(name, phone);
            break;
        default:
            Console.WriteLine("Incorrect number");
            break;

    }
}
