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
            //int product = 1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    product = product * i;
            //}
            //    Console.WriteLine(product);

            //or
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);

            //FOREACH LOOP - used to iterate over a collection (ex. list or array)
            //You can think of the structure of a foreach loop as a statement:
            //For each item in the collection, do something
            //SETUP
            //foreach(datatype variable in collection
            //{
            //  do something
            //}

            //string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "June" };
            ////always start with the keyword foreach
            //foreach (string month in firstMonths)
            //{
            //    Console.WriteLine(month);
            //}
            //foreach loops allow the temporary variable to "know" to assign...
            //..itself to each element in the collection (like an array), one at a time
            //foreach loop will always go from beginning to end, no matter what
            //it counts the number of elements in the collection, and runs that many times

            //Create an array of 6 musicians (bands or solo artist)
            //Using a foreach loop, print each musician's name
            //string[] musicianNames = { "KDOT", "Weezer", "ALT-J", "Phantogram", "J.Cole", "RHCP" };
            //foreach (string artist in musicianNames)
            //{
            //    Console.WriteLine(artist);
            //}

            //WHILE LOOP: is used when you want a chunk of code to run only if a condition is met first.
            //While something is TRUE, do this thing.

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //while (firstName.ToUpper() == "FRANK" )
            //{
            //    Console.WriteLine("Dude, you are amazing.");
            //    break;
            //}

            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine().ToUpper();
            //while(playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            //DO-WHILE LOOP is similar to a While loop, however...
            //...the Do-While loop is used when you want a chunk of code to run..
            //...AT LEAST ONCE, but repeat only if the While condition is met
            //Structure
            //do
            //{
            //do something
            //}
            //while(condition);

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to my game!");
            //    //let's pretend the code for the game is here
            //    Console.WriteLine("Great Game!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine().ToUpper();
            //}
            //while (playAgain == "YES");

            //Ask the user for the class (in school) that they would like to add to their GPA calculation
            //Ask the user for the letter grade for the class (no + or -)
            //Ask the user if they have another class they would like to add to their GPA calculation
            //Using a Do-While Loop, repeat the code if the user says "YES"

            //string classGrade;
            //do
            //{
            //    Console.WriteLine("What class would you like to add to your GPA?");
            //    Console.ReadLine();
            //    Console.WriteLine("What was your letter grade in the class (no + or -)");
            //    Console.ReadLine();
            //    Console.WriteLine("Do you have another class you would like to add to your GPA? YES/NO");
            //    classGrade = Console.ReadLine().ToUpper();
            //}
            //while (classGrade == "YES");

            //NESTED LOOPS
            //Loop inside of another loop
            //The inner loop is executed more times than the outer loop
            //real life example - clock

            //Create a nested loop structure that prints:
            //1234
            //1234

            //for(int rows = 1; rows <= 2; rows++)
            //{
            //    for(int columns = 1; columns <= 4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}

            //Print a Triangle
            //Outer loop will go line by line
            //The inner loop will go over different elements in the line.
            //Result:
            //1
            //1 2
            //1 2 3 
            //1 2 3 4 ...

            //Console.WriteLine("How many rows do you want in your triangle?");
            //int n = int.Parse(Console.ReadLine());
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col + " ");
            //    }
            //    Console.WriteLine();
            //}

            //OR

            //for(int rows = 1; rows <= 4; rows++)
            //{
            //    for(int columns = 1; columns <= rows; columns++)
            //    {
            //        Console.Write(columns + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Remember that in FizzBuzz, if it is not a FizzBuzz, Fizz, or Buzz number
            //you print the number itself.
            //Console.WriteLine("Let's Play FizzBuzz!");
            //Console.WriteLine("Please enter your FIZZ number");
            //int fizz = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your BUZZ number");
            //int buzz = int.Parse(Console.ReadLine());
            //Console.WriteLine("What number would you like me to count to? (Pick a high one)");
            //int endNumber = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= endNumber; i++)
            //{
            //    if (i % fizz == 0 && i % buzz == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz!");
            //    }
            //    else if (i % fizz == 0)
            //    {
            //        Console.WriteLine("Fizz!");
            //    }
            //    else if (i % buzz == 0)
            //    {
            //        Console.WriteLine("Buzz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //create an array of lucky numbers (#s you like). using a foreach loop, print the following
            //Your Lucky Number is: #
            //Your Lucky Number is: # etc, etc
            //int[] luckyNumbers = { 4, 7, 11, 12, 57 };
            //foreach (int number in luckyNumbers)
            //{
            //    Console.WriteLine("Your Lucky Number is: " +  (number));
            //}

            //Write a program that prints a multiplication table (5 x 5, for example) using a nested loops.
            //int multNum = 1;

            //for (int i =1; i <= 5; i++)
            //{
            //    for (int j =1; j <= 5; j++)
            //    {
            //        Console.Write(multNum * j + " ");                 
            //    }
            //    multNum += 1;
            //    Console.WriteLine();
            //}
            //OR
            //int multNum = 1;
            //Console.WriteLine("Enter in your first number.");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter in your second number.");
            //int secondNumber = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= firstNumber; i++)
            //{
            //    for (int j = 1; j <= secondNumber; j++)
            //    {
            //        Console.Write(multNum * j + " ");
            //    }
            //    multNum += 1;
            //    Console.WriteLine();
            //}

            //Create an array of your favorite movies. Print out each movie in the list,.. 
            //..unless the move starts with a vowel. Hint : Research .startsWith()
            //string[] faveMovies = { "Star Wars", "Anchorman", "Avatar", "Serenity", "Super Troopers" };
            //foreach (string movie in faveMovies)
            //{
            //    if (movie.StartsWith("A"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("E"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("I"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("O"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("U"))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(movie);
            //    }
            //}

            //Write a console application that asks the user for an integer. If that integer is evenly divisible by 3,.. 
            //..then write “You Won!” If it isn’t, write “You Lost.” Keep asking them for a number (looping) until they win.
            //i know i need to ask user for integer, and get the input, and save it
           // Console.WriteLine("Please enter an integer (whole number).");
           // int userNumber = int.Parse(Console.ReadLine());

           // //"evenly divisible" is a good indicator of modulus
           // //we have to check if the input % 3 == 0
           // //we need a conditional and if the input % 3 == 0 we need to write "You Won!"
           // //and we need to exit the loop
           // //if their input % 3 is not equal to 0, we have to let them know "You Lost!"
           // //and ask for another integer. we repeat this, until they win.
           //while(userNumber % 3 != 0 )
           // {
           //     Console.WriteLine("You Lost!");
           //     Console.WriteLine("Please enter another integer.");
           //     userNumber = int.Parse(Console.ReadLine());
           // }
           // Console.WriteLine("You Won!");



        }
    }
}
