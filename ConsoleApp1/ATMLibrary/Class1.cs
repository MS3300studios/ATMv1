using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibrary
{
    public class Class1
    {
        //fields and data
        private double balance;
        public double Balance
        {
            get { return balance; }
            set
            {
                value = balance;
            }
        }
        private string pin;
        public string Pin
        {
            get { return pin; }
            set
            {
                value = pin;
            }
        }


        //Constructors
        public Class1()
        {
            balance = 1000;
            pin = "1234";
        }
        public Class1(double bal, string pinnr)
        {
            balance = bal;
            pin = pinnr;
        }


        public override string ToString()
        {
            return $"account with balance: {balance} pin: {pin}";
        }

        //class methods


    }
}
