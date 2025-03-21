﻿using System;
using Spectre.Console;
using Bogus;
using Bogus.DataSets;

namespace WorkerTable
{
    public class Program
    {
        //argumento recebido sera o numero de empregados na tabela
        private static void Main(string[] args)
        {
            int count = int.Parse(args[0]);
            Randomizer.Seed = new Random(count); //defir a seed

            Faker faker = new Faker("pt_PT"); //gerar dados atraves de faker em portugues

            var table = new Table();
            //tabela com 3 colunas para cada elemento
            table.AddColumn("ID");
            table.AddColumn(new TableColumn("Name").LeftAligned());
            table.AddColumn(new TableColumn("Job").LeftAligned());

            //para cada numbero criar uma linha na tabela
            for (int i = 0; i < count; i++)
            {
                Name name = faker.Name;
                table.AddRow($"{(i + 1)}", $"{name.FirstName()} {name.LastName()}", name.JobTitle());
            }
            //da print da tabela
            AnsiConsole.Write(table);
        }
    }
}
