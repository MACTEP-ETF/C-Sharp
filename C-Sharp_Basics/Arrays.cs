using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new int[3];
            number[0] = 1;

            Console.WriteLine(number[0]); //will print "1"
            Console.WriteLine(number[1]); //will print "0"
            Console.WriteLine(number[2]); //will print "0"

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Janis", "Modris", "Jana" };
            Console.WriteLine("{0}, {1}, {2}", names[0], names[1], names[2]);
        }
    }
}
