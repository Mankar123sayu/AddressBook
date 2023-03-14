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
        public void EditContact()
        {
            Console.WriteLine("Enter option to Edit \n 1.FirstName \n 2. LastName \n 3.Address \n 4.City \n 5. State \n 6. ZIP \n 7.PhoneNumber \n 8. Email");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1: contact.FirstName = Console.ReadLine();
                    break;
                case 2: contact.LastName = Console.ReadLine();
                    break;
                case 3: contact.Address = Console.ReadLine();
                    break;
                case 4: contact.City = Console.ReadLine();
                    break;
                case 5: contact.State = Console.ReadLine();
                    break;
                case 6: contact.ZIP = Console.ReadLine();
                    break;
                case 7: contact.PhoneNumber= Console.ReadLine();
                    break;
                case 8: contact.Email = Console.ReadLine();
                    break;
                        

            }
        }
    }
}
 public void DeleteContact()
        {
            Console.WriteLine("Edit Name to Delete contact");
            String Name = Console.ReadLine();
            foreach (var data in addressBook)
            { 
                    if (data.FirstName.Equals(Name))
                    {
                    addressBook.Remove(data);
                    }
            }
        }
    }
}
