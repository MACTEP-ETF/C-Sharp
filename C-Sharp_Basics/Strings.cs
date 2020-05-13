using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Vladimirs";
            var lastName = "Fedorovics";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var names = new string[3] { "Jānis", "Vera", "Kārlis" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi Jānis
Look into the following paths: 
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
