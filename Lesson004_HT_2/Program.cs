using System;

namespace Lesson004_HT_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter B:");
            string num2 = Console.ReadLine();
            int A = int.Parse(num1);
            int B = int.Parse(num2);
            int res = ~(A | B);
            Console.WriteLine("(A|B)`");
            Console.WriteLine($"{res}");
            int A_Invert = ~A;
            int B_Invert = ~B;
            int res2 = A_Invert & B_Invert;
            Console.WriteLine("De Morgan use: (A` & B`)");
            Console.WriteLine($"{res2}");

        }
    }
}
 