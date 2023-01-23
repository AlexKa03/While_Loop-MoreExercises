using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottlesDetergent = int.Parse(Console.ReadLine());          

            int plates = 0;
            int pots = 0;

            int counter = 1;
            int detergentMls = bottlesDetergent * 750;

            while (detergentMls >= 0)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                int dishes = int.Parse(command);

                if (counter % 3 != 0)
                {
                    plates += dishes;
                    detergentMls -= dishes * 5;
                }
                else
                {
                    pots += dishes;
                    detergentMls -= dishes * 15;
                }

                counter++;
            }

            if (detergentMls < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergentMls)} ml. more necessary!");
            }
            else
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{plates} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentMls} ml.");
            }
        }
    }
}
