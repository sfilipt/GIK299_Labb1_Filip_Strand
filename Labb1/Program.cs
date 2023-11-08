using System;
namespace Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in namnet på en familjemedlem: ");
            string? name1 = Console.ReadLine();
            Console.WriteLine($"Skriv in åldern på {name1}: ");
            float age1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in namnet på en till familjemedlem: ");
            string? name2 = Console.ReadLine();
            Console.WriteLine($"Skriv in åldern på {name2}: ");
            float age2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in namnet på en tredje familjemedlem: ");
            string? name3 = Console.ReadLine();
            Console.WriteLine($"Skriv in åldern på {name3}: ");
            float age3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in namnet på en fjärde familjemedlem: ");
            string? name4 = Console.ReadLine();
            Console.WriteLine($"Skriv in åldern på {name4}: ");
            float age4 = float.Parse(Console.ReadLine());
            float sum = age1 + age2 + age3 + age4;
            Console.WriteLine($"Sammanlagd ålder för dina familjemedlemmar är: {sum}");
            Console.WriteLine($"Medelåldern för dina familjemedlemmar är: {sum / 4:#.##}");
            Console.ReadKey();
        }
    }
}


