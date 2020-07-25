using System;
using tratamento.Entities;
using tratamento.Entities.Exceptions;


namespace tratamento
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Enter account data");
                Console.Write("Number:");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder:");
                string holder = Console.ReadLine();
                Console.Write("Initial balance:");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("WithDraw limit:");
                double withdrawlimit = double.Parse(Console.ReadLine());
                Account acc = new Account(number, holder, balance, withdrawlimit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                acc.WithDraw(amount);
                Console.WriteLine("New balance: " + acc.Balance);
            }catch(DomainException e){
                Console.WriteLine("Error: " + e.Message);
            }catch(FormatException e){
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}
