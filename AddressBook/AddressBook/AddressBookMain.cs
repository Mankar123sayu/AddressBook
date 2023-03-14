using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        Contact contact = new Contact();
        public void AddContact()
        {
            Console.WriteLine("Enter FirstName");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter ZIP");
            contact.ZIP = Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();

        }
        public void Display()
        {
            Console.WriteLine(contact.FirstName+"\n"+contact.LastName);
        }
    }
}
