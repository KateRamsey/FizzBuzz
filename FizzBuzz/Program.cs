using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool FizzOrBuzz = false;
            for (int i = 1; i <= 100; i++)
            {
                if(i%3 == 0)
                {
                    Console.Write("Fizz");
                    FizzOrBuzz = true;
                }
                if(i%5 == 0)
                {
                    Console.Write("Buzz");
                    FizzOrBuzz = true;
                }
                if(!FizzOrBuzz)
                {
                    Console.Write(i);
                }
                FizzOrBuzz = false;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
