using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[1];
            Console.WriteLine("Adding new cars");

            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Enter manufactuer");
                Car c = new Car();
                c.Manufacturer = Console.ReadLine();
                Console.WriteLine("Enter model");
                c.Model = Console.ReadLine();
                Console.WriteLine("Enter price");
                c.Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter year");
                c.Year = Convert.ToInt32(Console.ReadLine());

                cars[i] = c;
            }


            Console.WriteLine("Displaying all cars:");
            for (int i=0;i<cars.Length;i++)
            {
                Console.WriteLine("Manufacturer: {0}, Model: {1}, Price: {2}, Year: {3}",cars[i].Manufacturer,cars[i].Model,cars[i].Price,cars[i].Year);
            }

            Console.WriteLine("Modify a car at a particular index");
            int modifyIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter manufactuer");
            cars[modifyIndex].Manufacturer = Console.ReadLine();
            Console.WriteLine("Enter model");
            cars[modifyIndex].Model = Console.ReadLine();
            Console.WriteLine("Enter price");
            cars[modifyIndex].Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter year");
            cars[modifyIndex].Year = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Search a car");
            int searchIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Manufacturer: {0}, Model: {1}, Price: {2}, Year: {3}", cars[searchIndex].Manufacturer, cars[searchIndex].Model, cars[searchIndex].Price, cars[searchIndex].Year);

            Console.WriteLine("Delete a car");
            Console.WriteLine("Which car do you want to delete?");
            int index = Convert.ToInt32(Console.ReadLine());

            for(int i = index; i < cars.Length-1; i++)
            {
                cars[i] = cars[i + 1];
            }

            
        }
    }
}
