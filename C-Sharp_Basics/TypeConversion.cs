using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to a boolean type.");
            }
            
            
            /*
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
            */

            //var number = "1234";
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);

            //int i = 1000;
            //byte b = (byte) i;
            //Console.WriteLine(b);
        }
    }
}
