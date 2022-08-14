using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
          

            try
            {

                int number = Convert.ToInt32(Console.ReadLine());
                double root = 1;
                int i = 0;
                if (number < 0)
                {
                    throw new Exception("Invalid number.");
                }
                while (true)
                {
                    i = i + 1;
                    root = (number / root + root) / 2;
                    if (i == number + 1) { break; }
                }
                Console.WriteLine((int)root);
                Console.WriteLine("Goodbye.");
            }
            catch (Exception ax)
            {

                Console.WriteLine(ax.Message);
                Console.WriteLine("Goodbye.");
            }
            

           
        }
    }
}
