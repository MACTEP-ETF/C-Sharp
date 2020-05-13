using System;

namespace ReferenceTypes_and_ValueTypes_2
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            /* Will print "1", variable number has a same name, but different location in a memory! 
             * Therefore for Increment method the scope is limited to it, and immediately had destroyed from a memory after execution.
             */

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
            /* Because it is a reference type – it's work like pointer in the C language! :) We just make a link to the object address, and don't copy it.
             */
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
