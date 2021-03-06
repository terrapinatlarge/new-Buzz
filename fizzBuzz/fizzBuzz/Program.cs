﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


/*  Matthew Hanna 8/18/2016
 
        A simple solution to the classic problem. for values that are deviable by three, they will be 
         replaced by fizz, values deviable by five will replaced by buzz, and any number that satisfies
         both conditions will be replaced by FizBuzz
     */

namespace fizzBuzz
{
    class Program
    { 
        public static void Main(string[] args)
        {


            IEnumerable<int> seq = Enumerable.Range(1, 100); //getting the sequence of numbers.

            foreach (int element in seq)
            {
                bool fizz = element % 3 == 0; //declaring variables here to ensure proper scope.
                bool buzz = element % 5 == 0;

                if (fizz && buzz == true)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (buzz == true)
                {
                    Console.WriteLine("buzz");
                }

                else if (fizz  == true)
                {
                    Console.WriteLine("fizz");
                }

                else if (fizz || buzz != true)
                {
                    Console.WriteLine(element);
                }
            }

            Console.WriteLine(seq);
            Console.ReadLine(); //Used only to view the final results.

        }
    }
}
