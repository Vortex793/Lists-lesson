using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Random generator = new Random();

            //List<string> names = new List<string> { "Trinity", "Neo", "Morpheus", "Cypher" };
            //Console.WriteLine(names[1] + "is 'The One'.");
            //Console.WriteLine(names[3] + "is the bad guy");
            //Console.WriteLine("There are " + names.Count + " names in my list.");
            //names[3] = "Agent Smith";
            //Console.WriteLine(names[3] + "is the bad guy.");
            //Console.ReadLine();

            //int randomIndex = generator.Next(0, names.Count);
            //Console.WriteLine("Random name: " + names[randomIndex]);


            //// Change the last name without hard coding an index number
            //names[names.Count - 1] = "Cypher";
            //Console.WriteLine(names[names.Count - 1] + " is another bad guy.");

            //// Random Challenge
            //Console.WriteLine();
            //Console.WriteLine("Here is a random name:");
            //Console.WriteLine(names[generator.Next(names.Count)]);
            //Console.WriteLine();

            //// Prints all elements no matter what the size of the array is
            //for (int i = 0; i < names.Count; i++)
            //{
            //    Console.WriteLine(i + ". " + names[i]);
            //}

            //// Prints all elements without using a loop
            //Console.WriteLine(string.Join(", ", names));

            List<int> numbers = new List<int>(); // Creates an empty List
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a number: ");


                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.ReadLine(); // Keeps the program from ending
            Console.WriteLine("The largest number is " + numbers.Max());
            Console.WriteLine("The smallest number is " + numbers.Min());
            Console.WriteLine("The sum is " + numbers.Sum());
            Console.WriteLine("The average is " + numbers.Average());

            // Loop through the List backwards challenge
            Console.WriteLine("Here are the numbers in reverse order:");
            for (int i = numbers.Count - 1; i >= 0; i--) // We start at the last index (Length-1) and end at zero.
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            
            int biggerThanFive = 0;
            // Loop through the array and only print values bigger than 5
            Console.WriteLine("Numbers larger than 5 are:");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 5)
                {
                    Console.Write(numbers[i] + " ");
                    biggerThanFive += 1;    // Counts the number of values bigger than 5 challenge
                }

            }
            Console.WriteLine();
            Console.WriteLine("There are " + biggerThanFive + " numbers larger than 5.");
        }
    }
}