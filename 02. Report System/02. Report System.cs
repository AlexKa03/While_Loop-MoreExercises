using System;
using System.Transactions;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyCharity = double.Parse(Console.ReadLine());

            int counter = 1;
            string command = Console.ReadLine();

            double total = 0.00;
            double moneyCash = 0.00;
            double moneyCard = 0.00;
            int cashCounter = 0;
            int cardCounter = 0;

            while (command != "End")
            {
                double transaction = double.Parse(command);

                if (counter % 2 == 1)
                {
                    if (transaction <= 100)
                    {
                        moneyCash += transaction;
                        total += transaction;
                        cashCounter++;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                else
                {
                    if (transaction >= 10)
                    {
                        moneyCard += transaction;
                        total += transaction;
                        cardCounter++;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }

                counter++;

                if (total >= moneyCharity)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            else
            {
                Console.WriteLine($"Average CS: {moneyCash / cashCounter:f2}");
                Console.WriteLine($"Average CC: {moneyCard / cardCounter:f2}");
            }
        }
    }
}
