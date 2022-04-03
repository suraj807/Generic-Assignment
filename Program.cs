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

            //Console.WriteLine("enter a first integer value");
            //int firstvalue = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter a second integer value");
            //int secondvalue = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter a third integer value");
            //int thirdvalue = Convert.ToInt32(Console.ReadLine());

            //int maxvalue = findmaximum.Findmaximuminteger(firstvalue, secondvalue, thirdvalue);
            //Console.WriteLine($"Maxium integer of ({firstvalue},{secondvalue},{thirdvalue}) is : {maxvalue}");


            Console.WriteLine("enter your choice");
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
                    int maxvalue = findmaximum.Findmaximuminteger(first, second, third);
                    Console.WriteLine($"Maxium integer of ({first},{second},{third}) is : {maxvalue}");
                    break;


                    case 2:
                    float First, Second, Third;
                    Console.WriteLine("enter a first integer value");
                    First = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter a second integer value");
                    Second = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter a third integer value");
                    Third = float.Parse(Console.ReadLine());
                    float floatmaxvalue = findmaximum.Findmaximumfloat(First, Second, Third);
                    Console.WriteLine($"Maxium float of ({First},{Second},{Third}) is : {floatmaxvalue}");
                    break;
            }




            Console.ReadLine();

        }
    }
}
