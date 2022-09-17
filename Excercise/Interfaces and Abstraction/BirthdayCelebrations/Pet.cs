
using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
   public class Pet : IBirthDate
    {
        public Pet(string name, string brithDate)
        {
            Name = name;
            BrithDate = brithDate;
        }

        public string Name { get; private set; }
        public string BrithDate { get; private set; }

    }
}
