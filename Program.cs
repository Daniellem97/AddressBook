using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    class Program
    {
        static List<Address> addressBook = new List<Address>();

        static void Main()
        {
            Address a1 = new Address("danielle", 23, "dawsons", "ardee", "louth", "ireland");
            Address a2 = new Address("daniel", 423, "belgard heights", "tallaght", "dublin", "ireland");

            addressBook.Add(a1);
            addressBook.Add(a2);

            Console.WriteLine("Welcome to your address book");
            while (true)
            {
 

                Console.WriteLine("Please select an option (1, 2 or 3): ");
                Console.WriteLine("1. Add an address");
                Console.WriteLine("2. Delete an address");
                Console.WriteLine("3. Search for an address");
                Console.WriteLine("4. View all addresses");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddAddress();
                        break;
                    case 2:
                        DeleteAddress();
                        break;
                    case 3:
                        SearchAddress();
                        break;
                    case 4:
                        ViewAllAddress();
                        break;
                    default:
                        break;
                }

            }
           
        }

        private static void ViewAllAddress()
        {
            foreach(Address a in addressBook) {
                Console.WriteLine(a.name + " " + a.houseNum + " " + a.lineOne + " " + a.town+ " " + a.county + " " + a.country);
            }
        }

        static Address SearchAddress()
        {
            Console.WriteLine("enter the name of the person");
            string name = Console.ReadLine();

            foreach (Address a in addressBook)
                if (a.name == name)
                    return a;

            return null;
        }

        static void DeleteAddress()
        {
            Address sa = SearchAddress();

            foreach (Address a in addressBook.ToList() )
            {
                if (a == sa) 
                {
                    Console.WriteLine(a.name + " " + a.houseNum + " " + a.lineOne + " " + a.town + " " + a.county + " " + a.country);
                    Console.WriteLine("press y to delete");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        addressBook.Remove(a);
                    }
                }
            }
        }

        static void AddAddress()
        {
            Console.WriteLine("please enter a name");
            string Name = Console.ReadLine();
            Console.WriteLine("please enter a house number");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter line one");
            string Line1 = Console.ReadLine();
            Console.WriteLine("please enter the Town");
            string Town = Console.ReadLine();
            Console.WriteLine("please enter the County");
            string County = Console.ReadLine();
            Console.WriteLine("please enter the Country");
            string Country = Console.ReadLine();

            Console.WriteLine( "address succesfully added");
            Console.WriteLine( Name + " " + Number + " " + Line1 + " " + Town + " " + County + " " + Country);
            Address a = new Address(Name,Number,Line1,Town,County,Country);
            addressBook.Add(a);
        }
    }
}
