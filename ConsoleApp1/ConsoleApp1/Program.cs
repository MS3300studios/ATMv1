using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMLibrary;

namespace ATMv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1000, "1234");
            Console.WriteLine(acc1.ToString()); 
        }
    }
}
