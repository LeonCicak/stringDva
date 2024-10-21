using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi niz znakova");
            string input = Console.ReadLine();
            string output = input.Replace(" ", "_");
            Console.WriteLine("Rezultat " + output);
            Console.ReadLine();



        }
    }
}
