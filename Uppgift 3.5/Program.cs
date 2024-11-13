using System;

namespace Uppgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tal 1:");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tal 2:");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraktion");
            Console.WriteLine("3.Multiplikation");
            Console.WriteLine("4.Division");
            int räknesätt = int.Parse(Console.ReadLine());

            if (räknesätt == 1)
            {
                Console.WriteLine(tal1 + tal2);
            }
            if (räknesätt == 2)
            {
                Console.WriteLine(tal1 - tal2);
            }
            if (räknesätt == 3)
            {
                Console.WriteLine(tal1 * tal2);
            }
            if (räknesätt == 4)
            {
                Console.WriteLine(tal1 / tal2);
            }
        }
    }
}