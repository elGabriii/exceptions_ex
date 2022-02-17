using exception_ex.Entities;
using exception_ex.Entities.Exceptions;
using System;

namespace exception_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial balance: ");
                double ibalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine());

                Account acc = new Account(n, name, ibalance, limit);
                Console.WriteLine();
                Console.Write("Enter the amount to withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                acc.withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance);
            }

            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: "+e.Message);
            }
            catch(FormatException)
            {
                Console.WriteLine("expected a number");
            }

        }

    }
}
