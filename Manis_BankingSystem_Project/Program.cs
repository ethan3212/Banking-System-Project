using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace Manis_BankingSystem_Project
{
    class CustomerInformation
    {
        string[] Name = {"John", "Jane", "Scott", "Sally", "Molly", "Jeff", "Ethan", "Brian", "Jess", "Justin" };
        int[] Age = {21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
        string[] SSN = {"1234", "4321", "5678", "8765", "1928", "8291", "4037", "6453", "9081", "3725", };
        string[] Checking = { "yes", "yes", "no", "no", "yes", "no", "yes", "no", "yes", "no", };
        string[] Saving = { "yes", "no", "yes", "no", "no", "no", "yes", "no", "yes", "yes" };

        public CustomerInformation()
        {
            WriteLine("Who's account are you looking for? ");       // ask user for the name of the account holder
            string name = ReadLine();       // read input and assign to variable "name"
            int index = 0;                  // initialize index to first element

            for (int i = 0; i < Name.Length; i++)       // search "Name" array for element matching variable "name"
                if (name == Name[i])                    // if match found
                    index = i;                          // "index" equals array location

            string holder = Name[index];
            int age = Age[index];
            string ssn = SSN[index];
            string checking = Checking[index];
            string saving = Saving[index];

            
            WriteLine("Account Holder: " + holder);     // display information pertaining to the account
            WriteLine("Account Holder age: " + age);
            WriteLine("Account Holder SSN: " + ssn);
            WriteLine("Checking account: " + checking);
            WriteLine("Savings account: " + saving);
        }
    }
    class Customer
    {
        public Customer()
        {
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            CustomerInformation bnk = new CustomerInformation();
        }
    }
}