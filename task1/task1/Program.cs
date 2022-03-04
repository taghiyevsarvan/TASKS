using System;

namespace task040322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 quvvet olub olmadiqi ve 2 ustu nece olduqu
            Console.WriteLine("Bir eded daxil edin: ");
            double n = Convert.ToDouble(Console.ReadLine());
            int sum = 0;
            if (n % 2 == 0)
            {
                while (n > 1)
                {
                    n = n / 2;
                    sum++;
                }
                if (n == 1)
                {
                    Console.WriteLine("2-nin quvvetidir : " + "2 ustu" + " " + sum);
                }
                else
                {
                    Console.WriteLine("2-nin quvveti deyil");
                }

            }
            else
            {
                Console.WriteLine("2-nin quvveti deyil");
            }
        }
    }
}
