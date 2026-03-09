using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Trinity", "Neo", "Morpheus", "Smith" };
            Console.WriteLine(names[1] + "is 'The One'.");
        }
    }
}

