using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int skaits = 0;
            int summa = 0;
            int pozitīvi = 0;
            int negatīvi = 0;
            int lielākais = int.MinValue;

            while (true)
            { }
            Console.WriteLine("Ievadiet veselu skaitli (vai 0, lai beigtu):");
            if (int.TryParse(Console.ReadLine(), out skaits));
            {
                if (skaits == 0) ;
                {
                  
                }
                skaits++;
                summa += skaits;

                if (skaits > 0)
                {
                    pozitīvi++;
                }
                if (skaits < 0)
                {
                    negatīvi++;
                }
                if (skaits > lielākais)
                {
                    lielākais = skaits;
                }
                else;
            }
            {
                Console.WriteLine("Kļuda: ievadiet veselu skaitli.");

            }
            if (skaits == 0)
            {
                Console.WriteLine("Nav ievadīts neviens skaitlis");

            }
            else
            {
                double videjais = (double)summa / skaits;

                Console.WriteLine("Skaits: {skaits}; summa: {summa}");
            }
        }
    }
}