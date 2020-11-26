using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDetailsDemo
{
    class Program
    {
        static List<Contact> list;

        static void Main(string[] args)
        {
            list = new List<Contact>();

            Console.WriteLine("Add contacts");
            for (int i=0;i<10;i++)
            {
                AddContact();
            }

            Console.WriteLine("Show all details");
            ShowAllDetails();


            Console.WriteLine("show particular contact details");
            DisplayContact();

            Console.WriteLine("Edit contact");
            EditContact();

        }

        static void AddContact()
        {
            Contact c = new Contact();
            
            Console.WriteLine("Enter contact no");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter contact name");
            string name = Console.ReadLine();


            Console.WriteLine("Enter cell no");
            string no = Console.ReadLine();

            c.ContactNo = id;
            c.ContactName = name;
            c.CellNo = no;

            list.Add(c);
        }

        static void EditContact()
        {
            Console.WriteLine("Enter index to search");
            int index = Convert.ToInt32(Console.ReadLine());

            Contact c = new Contact();

            Console.WriteLine("Enter contact no");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter contact name");
            string name = Console.ReadLine();


            Console.WriteLine("Enter cell no");
            string num = Console.ReadLine();

            c.ContactNo = no;
            c.ContactName = name;
            c.CellNo = num;

            list[index] = c;
        }


        static void ShowAllDetails()
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Contact No:{0} ",list[i].ContactNo);
                Console.WriteLine("Contact Name:{0} ",list[i].ContactName);
                Console.WriteLine("Contact Cell No:{0} ",list[i].CellNo);
            }
        }


        static void DisplayContact()
        {
            Console.WriteLine("Enter index to search");
            int index = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Details are");
            Console.WriteLine("Contact No:{0} ", list[index].ContactNo);
            Console.WriteLine("Contact Name:{0} ", list[index].ContactName);
            Console.WriteLine("Contact Cell No:{0} ", list[index].CellNo);

        }
    }
}
