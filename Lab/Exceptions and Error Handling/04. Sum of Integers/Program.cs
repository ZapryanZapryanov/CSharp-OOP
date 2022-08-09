using System;

namespace _04._Sum_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string currElement = string.Empty;
            int sum = 0;
            int count = 0;
            while (true)
            {
                try
                {
                    for (int i = 0; i < elements.Length; i++)
                    {
                        if (elements.Length == count)
                        {
                            break;
                        }
                        currElement = elements[count];
                        int element = int.Parse(elements[count]);
                        sum += element;
                        Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
                        count++;
                    }
                    break;
                }
                catch (FormatException)
                {
                    count++;
                    Console.WriteLine($"The element '{currElement}' is in wrong format!");
                    Console.WriteLine($"Element '{currElement}' processed - current sum: {sum}");
                }
                catch (OverflowException)
                {
                    count++;
                    Console.WriteLine($"The element '{currElement}' is out of range!");
                    Console.WriteLine($"Element '{currElement}' processed - current sum: {sum}");
                }
            }
            
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
