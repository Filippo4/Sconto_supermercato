using System;

namespace Serra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indicare la temperatura della serra!");
            int temperatura = int.Parse(Console.ReadLine());
            if (temperatura <= 5)
            {
                Console.WriteLine($"la temeraturea è {temperatura},perciò il livello di pericolo è alto");
            }else if (temperatura > 5 && temperatura <= 18)
            {
                Console.WriteLine($"la temeraturea è {temperatura},perciò il livello di pericolo è medio");
            }else if ( temperatura > 18)
                Console.WriteLine($"la temeraturea è {temperatura},perciò il livello di pericolo è basso");
            Console.ReadLine();
        }
    }
}
