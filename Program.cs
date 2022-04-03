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
            Console.WriteLine("enter your choice");
            Console.WriteLine("\n 1 integer value");
            Console.WriteLine("\n 2 float value");
            Console.WriteLine("\n 3 string value");
            
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    int first, second, third;
                    Console.WriteLine("enter a first integer value");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter a second integer value");
                    second = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter a third integer value");
                    third = Convert.ToInt32(Console.ReadLine());
                    int maxvalue = findmaximum.FindMax(first, second, third);
                    Console.WriteLine($"Maxium integer of ({first},{second},{third}) is : {maxvalue}");
                    break;


              case 2:
                    float First, Second, Third;
                    Console.WriteLine("enter a first float value");
                    First = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter a second float value");
                    Second = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter a third float value");
                    Third = float.Parse(Console.ReadLine());
                    float floatmaxvalue = findmaximum.FindMax(First, Second, Third);
                    Console.WriteLine($"Maxium float of ({First},{Second},{Third}) is : {floatmaxvalue}");
                    break;

              case 3:
                    string First1, Second2, Third3;
                    Console.WriteLine("enter a first string value");
                    First1 = Console.ReadLine();
                    Console.WriteLine("enter a second string value");
                    Second2 = Console.ReadLine();
                    Console.WriteLine("enter a second string value");
                    Third3 = Console.ReadLine();
                    string strigmaxvalue = findmaximum.FindMax(First1, Second2, Third3);
                    Console.WriteLine($"Maximum string of ({First1},{Second2},{Third3}) is : {strigmaxvalue}");
                    break;
             default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }




            Console.ReadLine();

        }
    }
}
