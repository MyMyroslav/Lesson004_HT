using System;

namespace Lesson004_HT_3_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            string n = Console.ReadLine();
            int num = int.Parse(n);
            if (((num & 1)==0)){
                bool parity = true;
                Console.WriteLine($"{num} is {parity}");
            }
            else
            {
                bool unparity = false;
                Console.WriteLine($"{num} is {unparity}");
            }
        }
    }
}
