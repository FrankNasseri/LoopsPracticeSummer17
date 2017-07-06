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
            //...AT LEAST ONCE, but repeat onlyif the While condition is met
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




        }
    }
}
