using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibrary
{
    public class Account
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
        private double newbalance;
        public double Newbalance
        {
            get { return newbalance; }
            set
            {
                value = newbalance;
            }
        }
        private double userinput;
        public double Userinput
        {
            get { return userinput; }
            set
            {
                value = userinput;
            }
        }



        //Constructors
        public Account()
        {
            balance = 1000;
            pin = "1234";
        }
        public Account(double bal, string pinnr)
        {
            balance = bal;
            pin = pinnr;
        }


        public override string ToString()
        {
            return $"account with balance: {balance} pin: {pin}";
        }

        //class methods
        public double Withdraw()
        {           
            balance - userinput = newbalance;

            return newbalance;
        }

    }
}
