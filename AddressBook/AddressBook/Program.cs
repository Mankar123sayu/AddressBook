using System;
using System.Net;

namespace AddressBook
{
    class program
    {
        public void Main(string[] args)
        {
            Contact contact = new Contact();
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
    }
}