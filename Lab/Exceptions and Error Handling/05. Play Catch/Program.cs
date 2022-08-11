using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Play_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int count = 0;
            while (true)
            {
                if (count >= 3)
                {
                    break;
                }
                try
                {
                    while (true)
                    {
                        string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        if (elements[0] == "Replace")
                        {

                            int index = int.Parse(elements[1]);
                            if (index >= 0 && index < list.Count)
                            {
                                int newElement = int.Parse(elements[2]);
                                list.RemoveAt(index);
                                list.Insert(index, newElement);
                            }
                            else
                            {
                                throw new IndexOutOfRangeException("The index does not exist!");
                            }
                           
                        }
                        else if (elements[0] == "Print")
                        {
                            int start = int.Parse(elements[1]);
                            int end = int.Parse(elements[2]);
                            if (start >= 0 && start < list.Count && end >= 0 && end < list.Count)
                            {
                                for (int a = start; a <= end; a++)
                                {
                                    Console.Write($"{list[a]}, ");
                                }
                            }
                            else
                            {
                                throw new IndexOutOfRangeException("The index does not exist!");
                            }
                           
                        }
                        else if (elements[0] == "Show")
                        {
                            int index = int.Parse(elements[1]);
                            if (index >= 0 && index < list.Count)
                            {
                                Console.WriteLine(list[index]);
                            }
                            else
                            {
                                throw new IndexOutOfRangeException("The index does not exist!");
                            }

                        }
                    }

                }
                catch (IndexOutOfRangeException ax)
                {
                    count++;
                    Console.WriteLine(ax.Message);
                }
                catch (Exception)
                {
                    count++;
                    Console.WriteLine("The variable is not in the correct format!");
                }
            }

            Console.WriteLine(string.Join((", "), list));
        }
    }
}
