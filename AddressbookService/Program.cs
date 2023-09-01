using AddressBookService;
using System;
using System.Net;

namespace AddressBookService
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddressBook contact = new AddressBook()
            //{
            //    FirstName = "yuvan",
            //    LastName = "sara",
            //    Address = "KNRoad",
            //    City = "chennai",
            //    State = "Kerala",
            //    Zip = 123456,
            //    PhoneNumber = "1234567890",
            //    Email = "yuva@gmail.com"
            //};
            Operations operations = new Operations();
            //operations.AddContact(contact);
            //AddressBook contact1 = new AddressBook()
            //{
            //    FirstName = "yuvanthika",
            //    LastName = "sarathy",
            //    Address = "KNRoad",
            //    City = "chennai",
            //    State = "TN",
            //    Zip = 123456,
            //    PhoneNumber = "1234567890",
            //    Email = "yuva@gmail.com"
            //};
            //operations.UpdateContact(contact1);
            //operations.DeleteContact("yuva");
            //operations.City("chennai");
            //operations.State("TN");
            //operations.SizeByCity();
            //operations.SizeByState();
            operations.CountByType();
        }
    }
}