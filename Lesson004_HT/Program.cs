using System;

namespace Lesson004_HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            string num = Console.ReadLine();
            int number = int.Parse(num);
            //100 (4) * 011 (3) = 0 --> Cтепінь
            if((number & (number - 1)) == 0){
                Console.WriteLine("It is pow of 2");
            }
            else
            {
                Console.WriteLine("It is not pow of 2");
            }
            
        }
    }
}
