using System;
using System.Collections.Generic;

namespace _06._Money_Transactions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            Dictionary<int, double> dcg = new Dictionary<int, double>();
            for (int i = 0; i < elements.Length; i++)
            {
                string[] curr = elements[i].Split("-", StringSplitOptions.RemoveEmptyEntries);
                int first = int.Parse(curr[0]);
                double second = double.Parse(curr[1]);
                dcg.Add(first, second);
            }
            while (input != "End")
            {
                string[] element = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int first = int.Parse(element[1]);
                double sum = double.Parse(element[2]);
                if (dcg.ContainsKey(first))
                {
                    if (element[0] == "Deposit")
                    {


                        dcg[first] += sum;

                    }
                    else if (element[0] == "Withdraw")
                    {
                        if (dcg[first] < sum)
                        {
                            Console.WriteLine("Insufficient balance!");
                            Console.WriteLine("Enter another command");
                            input = Console.ReadLine();
                            continue;
                        }
                        dcg[first] -= sum;
                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");
                        Console.WriteLine("Enter another command");
                        input = Console.ReadLine();
                        continue;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid account!");
                    Console.WriteLine("Enter another command");
                    input = Console.ReadLine();
                    continue;
                }
                double suma = dcg[first];
                Console.WriteLine($"Account {first} has new balance: {suma:f2}");
                Console.WriteLine("Enter another command");

                input = Console.ReadLine();
            }
        }
    }
}
