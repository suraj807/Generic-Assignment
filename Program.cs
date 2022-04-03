using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nwelcome to Generic value");

            Console.WriteLine("enter a first integer value");
            int firstvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second integer value");
            int secondvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a third integer value");
            int thirdvalue = Convert.ToInt32(Console.ReadLine());
            int maxvalue = findmaximum.Findmaximuminteger(firstvalue, secondvalue, thirdvalue);
            Console.WriteLine($"Maxium integer of ({firstvalue},{secondvalue},{thirdvalue}) is : {maxvalue}");

            Console.ReadLine();

        }
    }
}
