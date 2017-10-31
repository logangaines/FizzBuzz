using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        { 
            for (int i = 1; i <= 100; i++)
            {
                string results = "";

                if (i % 3 == 0)
                {
                    results = "Fizz";
                }
                if (i % 5 == 0)
                {
                    results = "Buzz";
                }
                if (i % 3 == 0 & i % 5 == 0)
                {
                    results = "FizzBuzz";
                }
                if (i % 3 != 0 & i % 5 != 0)
                {
                    results = i.ToString();
                }
                Thread.Sleep(100);

                Console.WriteLine(results);


            }
            Console.WriteLine("Way to go!");
            Console.ReadKey();
        }



    }
}