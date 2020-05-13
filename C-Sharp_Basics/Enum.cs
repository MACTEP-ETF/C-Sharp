using System;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1, //Sepratate by comma
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); //Represents method by ID number

            Console.WriteLine(method.ToString()); //Print name of shippingMethod

            var methodName = "RegularAirMail";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); //Parse string to an enumeration
            Console.WriteLine(shippingMethod);
        }
    }
}
