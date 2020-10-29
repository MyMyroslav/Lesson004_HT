using System;

namespace Lesson004_HT_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;
            x += y >> x++ * z;
            Console.WriteLine($"{x}");
            x = 5; y = 10; z = 15;
            z = ++x & y * 5;
            Console.WriteLine($"{z}");
            x = 5; y = 10; z = 15;
            y /= x + 5 | z;
            Console.WriteLine($"{y}");
            x = 5; y = 10; z = 15;
            z = x++ & y * 5;
            Console.WriteLine($"{z}");
            x = 5; y = 10; z = 15;
            x = y << x++ ^ z;
            Console.WriteLine($"{x}");

        }
    }
}
