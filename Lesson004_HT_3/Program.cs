using System;

namespace Lesson004_HT_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            string n = Console.ReadLine();
            int num = int.Parse(n);
    
            if (IsOdd(num))
            {
                Console.WriteLine("It is parity");
            }
            else
            {
               
                Console.WriteLine("It is not parity");
            }


        }

        private static bool IsOdd(int num)
        {
            return num % 2 == 0;
        }
    }
}
