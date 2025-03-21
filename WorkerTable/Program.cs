using System;
using Spectre.Console;
using Bogus;

namespace WorkerTable
{
    public class Program
    {
        //argumento recebido sera o numero de empregados
        private static void Main(string[] args)
        {
        int count = int.Parse(args[0]);
            Randomizer.Seed = new Random(count); //defir a seed

            Faker faker = new Faker("pt_PT"); //gerar dados atraves de faker

            var table = new Table();
            table.AddColumn("ID");
            table.AddColumn(new TableColumn("Nome").LeftAligned());
            table.AddColumn(new TableColumn("Job").LeftAligned());
        }
    }
}
