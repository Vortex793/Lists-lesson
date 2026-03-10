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

            Random generator = new Random();

            List<string> names = new List<string> { "Trinity", "Neo", "Morpheus", "Cypher" };
            Console.WriteLine(names[1] + "is 'The One'.");
            Console.WriteLine(names[3] + "is the bad guy");
            Console.WriteLine("There are " + names.Count + " names in my list.");
            names[3] = "Agent Smith";
            Console.WriteLine(names[3] + "is the bad guy.");
            Console.ReadLine();
            
            int randomIndex = generator.Next(0, names.Count);
            Console.WriteLine("Random name: " + names[randomIndex]);


            //number in the square brackets is reffering to which part of the list 
            //2. Console.Writeline
            //
        }
    }
}

