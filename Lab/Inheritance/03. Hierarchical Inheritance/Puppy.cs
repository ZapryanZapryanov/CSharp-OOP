using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
   public class Puppy : Dog
    {
        public virtual void Weep()
        {
            Console.WriteLine("weeping");
        }
             
    }
}
