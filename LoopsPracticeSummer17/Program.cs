﻿using System;
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

            ////creating for loop that counts from 50 to 100
            //for(int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //USING FOR LOOPS TO PRINT ELEMENTS OF AN ARRAY
            //string greeting = "My name is Little Bill.";
            ////The .Split method takes a string and turns it into an array of smaller...
            ////...strings (substrings). It defaults the split on spaces.
            //string[] wordsInGreeting = greeting.Split();
            //for(int i = 0; i < wordsInGreeting.Length; i ++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //}

            //Create an array called days with the elements Monday, Tuesday, and Wednesday.
            //Using a For Loop, print the elements of the day arrays.
            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //for(int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //Start with the string "Once upon a time" and create an array called..
            //string story = "Once upon a time.";
            ////..storyWords using the Split method. Reverse the order of the elements in..
            //string[] wordsInStory = story.Split();
            //Array.Reverse(wordsInStory);
            ////..the array and using a For Loop, print each word
            //for(int i = 0; i < wordsInStory.Length; i++)
            //{
            //    Console.WriteLine(wordsInStory[i]);
            //}

            //Add the product (multiplication) of 1 through 10, including 10, using a For Loop
            //Print the product to the screen.
            int product = 1;
            for (int i = 1; i <= 10; i++)
            {
                product = product * i;
            }
                Console.WriteLine(product);
            
            //or
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);
            //OR





        }
    }
}
