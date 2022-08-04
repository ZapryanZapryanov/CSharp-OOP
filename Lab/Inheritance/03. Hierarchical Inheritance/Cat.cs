using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
   public class Cat : Animal
    {
        public virtual void Meow()
        {
            Console.WriteLine("meowing");
        }
    }
}
