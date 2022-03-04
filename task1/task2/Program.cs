using System;

namespace task2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // daxil edilen cumledeki herifin sayi
            Console.WriteLine("metn veya cumleni daxil edin: ");
            string metin = Console.ReadLine();
            Console.WriteLine("axtarilacaq herifi daxil edin: ");
            string herf = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (herf.Contains(metin[i]))
                {
                    sum++;
                }
            }
            Console.WriteLine("yuxaridaki ifadede toplam " + sum + " dene " + herf + " herfi var");
            Console.ReadLine();
        }
    }
}
