using System;

namespace _03._Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int counterC = 0;
            int counterO = 0;
            int counterN = 0;
            string current = "";
            string endCurrent = "";

            while (command != "End")
            {
                if (command == "c")
                {
                    counterC++;
                    if (counterC >= 2)
                    {
                        current += command;
                    }
                }
                else if (command == "o")
                {
                    counterO++;
                    if (counterO >= 2)
                    {
                        current += command;
                    }
                }
                else if (command == "n")
                {
                    counterN++;
                    if (counterN >= 2)
                    {
                        current += command;
                    }
                }
                else
                {
                    for (char letter = 'a'; letter <= 'z'; letter++)
                    {
                        string check = letter + "";
                        if (command == check)
                        {
                            current += command;
                            break;
                        }
                    }
                    for (char letter = 'A'; letter <= 'Z'; letter++)
                    {
                        string check = letter + "";
                        if (command == check)
                        {
                            current += command;
                            break;
                        }
                    }
                }

                if (counterC >= 1 && counterO >= 1 && counterN >= 1)
                {
                    current = current + " ";
                    endCurrent += current;
                    counterC = 0;
                    counterO = 0;
                    counterN = 0;
                    current = "";
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(endCurrent);
        }
    }
}
