using System;

namespace Lesson004_HT_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double dblPayment = 1000;
            Console.WriteLine("Enter your experience in years:");
            string exp = Console.ReadLine();
            double dblExpTime = int.Parse(exp);
            if (dblExpTime >= 0 && dblExpTime < 5)
            {
                double dblPremium = (double)dblPayment * (10.0 / 100.0);
                Console.WriteLine($"Premium: {dblPremium}, Payment:{dblPremium + dblPayment}");
            }
           else if (dblExpTime >= 5 && dblExpTime < 10)
            {
                double dblPremium = (double)dblPayment * (15.0 / 100.0);
                Console.WriteLine($"Premium: {dblPremium}, Payment:{dblPremium + dblPayment}");
            }
            else if (dblExpTime >= 10 && dblExpTime < 15)
            {
                double dblPremium = (double)dblPayment * (25.0 / 100.0);
                Console.WriteLine($"Premium: {dblPremium}, Payment:{dblPremium + dblPayment}");
            }
            else if (dblExpTime >= 15 && dblExpTime < 20)
            {
                double dblPremium = (double)dblPayment * (35.0 / 100.0);
                Console.WriteLine($"Premium: {dblPremium}, Payment:{dblPremium + dblPayment}");
            }
            else if (dblExpTime >= 20 && dblExpTime < 25)
            {
                double dblPremium = (double)dblPayment * (45.0 / 100.0);
                Console.WriteLine($"Premium: {dblPremium}, Payment:{dblPremium + dblPayment}");
            }
            else if (dblExpTime >= 25)
            {
                double dblPremium = (double)dblPayment * (50.0 / 100.0);
                Console.WriteLine($"Premium: {dblPremium}, Payment:{dblPremium + dblPayment}");
            }
            else
            {
                Console.WriteLine("You entered wrong number");
            }

        }
    }
}
