using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITM_Lab02
{
    class Account
    {
        public String UserName { get; set; }
        public String Address { get; set; }
        public int Iban { get; set; }
        public int Amount { get; set; }

        public Account(string user, string address, int iban)
        {
            UserName = user;
            Address = address;
            Iban = iban;
            Console.WriteLine("The account for {0}, address: {1}, with IBAN: {2} has been created.", UserName, Address, Iban);

        }

        //public void AddDeposit(int sum)
        //{
        //    Amount += sum;
        //    Console.WriteLine("You added {0} $ into yout account.", sum);
        //    Console.WriteLine("Total amount is:  {0} $", Amount);

        //}

        //public void WitdrawFromDeposit(int sum)
        //{
        //    Amount -= sum;
        //    Console.WriteLine("You witdrawed {0} $ from yout account.", sum);
        //    Console.WriteLine("Remaining amount is:  {0} $", Amount);
        //}

        //public void DisplayAmount( int iban)
        //{
        //    Console.WriteLine("Your total amount is: {0}" ,Amount);
        //}

    }
}
