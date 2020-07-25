using System.Collections.Generic;
using System;
using abstrato.Entities;

namespace abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();
            Console.Write("Enter the number of tax payers: ");
            int payers = int.Parse(Console.ReadLine());
            for(int i = 1; i <= payers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Anual Income: ");
                double renda = double.Parse(Console.ReadLine());
                if(type == 'i')
                {
                    Console.Write("Health expenditure: ");
                    double saude = double.Parse(Console.ReadLine());
                    list.Add(new PessoaFisica(nome, renda, saude));

                }else
                {
                    Console.Write("Number of employees: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, renda, funcionarios));
                }
            }

            Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach (Contribuinte contribuinte in list)
            {
                sum += contribuinte.Imposto();
                Console.WriteLine(contribuinte.Nome + ": $ " + contribuinte.Imposto().ToString("F2"));
            }
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2"));
        }
    }
}
