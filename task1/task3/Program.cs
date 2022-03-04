using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir array verilir həmin array içərisində 3-ə bölünən ədədlərin cəmi tapılır
            Console.Write("arrayin index sayini girin : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[n];
            int sum = 0;
            Console.WriteLine("arraya daxil edilecek reqemleri yazin : ");
            for (int i = 0; i < n; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("arrayda 3-e bolunenler: ");
            for (int i = 0; i < number.Length; i++)
            {
                if(number[i] % 3 == 0)
                {
                    Console.Write(number[i]+" ");
                    sum=number[i]+sum;
                }
            }
            Console.WriteLine("\nArrayda 3-e bolunen ededlerin cemi : " + sum);
            Console.ReadKey();
        }
    }
}
