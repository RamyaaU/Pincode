using System;

namespace Pincode
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to Pincode Validation!");
                Pattern pattern = new Pattern();
                Console.WriteLine("Enter you pincode");
                string pincode = Console.ReadLine();
                bool valid = pattern.validatePincode(pincode);
                Console.WriteLine(valid);
            }
        }
    }
}
   