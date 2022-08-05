using System;

namespace CustomRandomList
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("pesho");
            list.Add("gosho");
            list.RandomString();
           
        }
    }
}
