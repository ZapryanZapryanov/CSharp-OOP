using System;
using System.Collections.Generic;

namespace _03._Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>();
          

            int count = 0;
            while (true)
            {
                try
                {

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (count == arr.Length)
                        {
                            break;
                        }
                        string[] elements = arr[count].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        string faces = elements[0];
                        string valid = elements[1];
                        //2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A
                        if (faces == "2" || faces == "3" || faces == "4"
                            || faces == "5" || faces == "6" || faces == "7"
                            || faces == "8" || faces == "9" || faces == "10"
                            || faces == "J" || faces == "Q" || faces == "K" || faces == "A")
                        {
                            if (valid == "S" || valid == "H" || valid == "D" || valid == "C")
                            {
                                string currValid = string.Empty;
                                if (valid == "S")
                                {
                                    currValid = "\u2660";
                                }
                                else if (valid == "H")
                                {
                                    currValid = "\u2665";
                                }
                                else if (valid == "D")
                                {
                                    currValid = "\u2666";
                                }
                                else if (valid == "C")
                                {
                                    currValid = "\u2663";
                                }
                                string card = faces + currValid;
                                list.Add(card);
                            }
                            else
                            {
                                count++;
                                throw new Exception("Invalid card!");
                            }
                        }
                        else
                        {
                            count++;
                            throw new Exception("Invalid card!");
                        }
                        count++;
                    }
                    break;
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
           
            foreach (var item in list)
            {
                Console.Write($"[{item}] ");
            }
            
        }
    }
}
