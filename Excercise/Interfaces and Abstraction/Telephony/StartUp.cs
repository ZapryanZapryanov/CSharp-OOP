using System;
using System.Linq;

namespace Telephony
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumber = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] webSite = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            IStationary stationary = new Stationary();
            ISmartphone smart = new Smartphone();
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                bool flag = false;
                foreach (var item in phoneNumber[i])
                {
                    if (!char.IsDigit(item))
                    {
                        flag = true;
                        Console.WriteLine("Invalid number!");
                        break;
                    }
                }
                if (flag)
                {
                    continue;
                }
                else if (phoneNumber[i].Length == 7)
                {
                    stationary.Calling(phoneNumber[i]);
                }
                else if (phoneNumber[i].Length == 10)
                {
                    smart.Calling(phoneNumber[i]);
                }

            }
            for (int i = 0; i < webSite.Length; i++)
            {
                bool flag = false;
                foreach (var item in webSite[i])
                {
                    if (char.IsDigit(item))
                    {
                        Console.WriteLine("Invalid URL!");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    continue;
                }
                else if (true)
                {
                    smart.Browsing(webSite[i]);
                }
            }
            
        }
    }
}
