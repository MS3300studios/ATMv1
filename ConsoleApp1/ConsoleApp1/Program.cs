using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 acc1 = new Class1(1000, "1234");
            Console.WriteLine(acc1.ToString()); 
        }
    }
}
