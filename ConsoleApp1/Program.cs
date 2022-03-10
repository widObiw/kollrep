using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] marks = new string[] { "2", "1", "2", "3", "1", "5" };

            Console.WriteLine(Class1.MinAVG(marks));
            Console.ReadKey();
            
        }
    }
}
