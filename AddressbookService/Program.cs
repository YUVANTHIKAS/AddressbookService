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
            //operations.CountByType();
            //operations.CountByType();
            //operations.CreateAddPerson();
            //AddressBook contact2 = new AddressBook()
            //{
            //    Id = 6,
            //    Type = "2"
            //};
            //operations.AddPersonValues(contact2);
            List<AddressBook> list = new List<AddressBook>();
            list.Add(new AddressBook()
            {
                FirstName = "yuva",
                LastName = "sara",
                Address = "KNRoad",
                City = "chennai",
                State = "germany",
                Zip = 123456,
                PhoneNumber = "10234568889",
                Email = "yuva@gmail.com"
            });
            list.Add(new AddressBook()
            {
                FirstName = "saral",
                LastName = "Rosi",
                Address = "Annikkanadu",
                City = "vnroad",
                State = "Kerala",
                Zip = 123456,
                PhoneNumber = "1023499789",
                Email = "saral@gmail.com"
            });
            list.Add(new AddressBook()
            {
                FirstName = "sarathy",
                LastName = "subu",
                Address = "poomagalroad",
                City = "Pathanamthitta",
                State = "andhra",
                Zip = 123000,
                PhoneNumber = "10000056789",
                Email = "subu@gmail.com"
            });
            list.Add(new AddressBook()
            {
                FirstName = "sound",
                LastName = "R",
                Address = "nehrunagar",
                City = "vellore",
                State = "Kerala",
                Zip = 123406,
                PhoneNumber = "1023996789",
                Email = "sound@gmail.com"
            });
            list.Add(new AddressBook()
            {
                FirstName = "miami",
                LastName = "u",
                Address = "kunnoor",
                City = "ooty",
                State = "TN",
                Zip = 123456,
                PhoneNumber = "10003456789",
                Email = "miamiS@gmail.com"
            });
            operations.UsingWithThread(list);
            operations.UsingWithoutThread(list);
        }
    }
}