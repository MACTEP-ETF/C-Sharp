using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vladimirs = new Person();
            Vladimirs.FirstName = "Vladimirs";
            Vladimirs.LastName = "Fedorovics";
            Vladimirs.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            System.Console.WriteLine(result);

        }
    }
}
