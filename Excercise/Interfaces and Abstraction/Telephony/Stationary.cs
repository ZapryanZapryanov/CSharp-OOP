using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Stationary : IStationary
    {
        public void Calling(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
