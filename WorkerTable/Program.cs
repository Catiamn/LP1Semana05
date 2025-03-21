using System;
using Spectre.Console;
using Bogus;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
            Randommizer.Seed = new Random(int.Parse(args[0])) //def seed
            Faker false = new False(pt_PT) //gerar dados atraves de faker
        }
    }
}
