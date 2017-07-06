using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPracticeSummer17
{
    class Program
    {
        static void Main(string[] args)
        {
            //when would you use a loop?
            //why would you use a loop?
            //Nested Loops
            //Infinite Loops
            //Keywords break and continue

            //For Loop
            //can be used for both counting and or ...
            //ITERATING through an array (or other collection type)
            //Looks like this:
            //for(initializer; condition; updater)
            //{
            //      Do something
            //}

            //example of For Loop
            //for(int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //creating for loop that counts from 50 to 100
            for(int i = 50; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
