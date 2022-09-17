using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthDate> collection = new List<IBirthDate>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split();
                if (info[0] == "Citizen")
                {
                    string name = info[1];
                    int age = int.Parse(info[2]);
                    string id = info[3];
                    string birthDate = info[4];
                    IBirthDate citizen = new Citizens(id, name, age, birthDate);
                    collection.Add(citizen);
                }
                else if (info[0] == "Pet")
                {
                    string name = info[1];
                    string birthDate = info[2];
                    IBirthDate pet = new Pet(name, birthDate);
                    collection.Add(pet);
                }
              
             
                input = Console.ReadLine();
            }
            string idToCheck = Console.ReadLine();

            foreach (var item in collection)
            {
                if (item.BrithDate.EndsWith(idToCheck))
                {
                    Console.WriteLine(item.BrithDate);
                }
            }
        }
    }
}
