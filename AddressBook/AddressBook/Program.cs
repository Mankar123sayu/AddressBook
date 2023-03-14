using System;
namespace AddressBook
{
    class program
    {
        public void Main(string[] args)
        {
            AddressBookMain addressbookMain = new AddressBookMain();
            for (int i = 0; i < 3; i++)
            {
                AddressBook.AddContact();
            }
            addressBook.AddContact();
            //addressBook.EditContact();
            //addressBook.Display();
            addressBook.EditContact();
            addressBook.Display();
        }
    }
}
