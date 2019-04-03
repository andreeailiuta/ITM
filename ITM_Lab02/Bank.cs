using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITM_Lab02
{
    class Bank
    {

        public string BankName { get; set; }
        public string BankAddress { get; set; }

        public List<Account> Accounts { get; set; }

        public Bank(string name, string address)

        {
            BankName = name;
            BankAddress = address;
            Accounts = new List<Account>();
        }

        public void CreatAccount(string accountName, string accoutAddress, int iBan)
        {
            var account = new Account(accountName, accoutAddress, iBan);
            Accounts.Add(account);
        }

        public Account GetAccount(int iBan)
        {
            foreach (var item in Accounts)
            {
                if (item.Iban == iBan)
                {
                    return item;
                }
                
            }
            return null;
        }

        public Account AddDeposit2(int iBan, int sum)
        {
            foreach (var item in Accounts)
            {
                if (item.Iban == iBan)
                {
                    item.Amount += sum;
                    Console.WriteLine("You added {0} $ into yout account.", sum);
                    Console.WriteLine("Total amount is:  {0} $", item.Amount);
                }

            }
            return null;
        }

        public Account WitdrawFromDeposit2(int iBan, int sum)
        {
            var commisionWitdraw = CalculateCommision(sum);
            foreach (var item in Accounts)
            {
                if (item.Iban == iBan)
                {
                    item.Amount = item.Amount - sum - commisionWitdraw;
                    Console.WriteLine("You witdrawed {0} $ from yout account.", sum);
                    Console.WriteLine("Remaining amount is:  {0} $", item.Amount);
                }
            }
            return null;
        }

        public void DisplayAmount2(int iBan)
        {

            foreach (var item in Accounts)
            {
                if (item.Iban == iBan)
                {
                    Console.WriteLine("Your total amount is: {0}", item.Amount);                  
                }
            }            
           
        }

        public int CalculateCommision(int amount)
        {
            var commision = Convert.ToInt32(amount * 0.05);
            Console.WriteLine("Your commision is {0}", commision);
            return commision;
        }

        //delete account by iban
        public Account DeleteAccount(int accountIBan)
        {
            foreach (var item in Accounts)
            {
                if (item.Iban == accountIBan)
                {
                    var initialAccountsNumber = Accounts.Count();
                    Accounts.Remove(item);

                    var actualAccountsNumber = Accounts.Count();
                    if (initialAccountsNumber > actualAccountsNumber)
                    {
                        Console.WriteLine("Account was deleted!");
                    }
                }

            }
            return null;
        }

        public Account DeleteAccount(string accountName)
        {
            foreach (var item in Accounts)
            {
                if (item.UserName == accountName)
                {
                    var initialAccountsNumber = Accounts.Count();
                    Accounts.Remove(item);
                    
                    var actualAccountsNumber = Accounts.Count();
                    if (initialAccountsNumber > actualAccountsNumber)
                    {
                        Console.WriteLine("Account was deleted!");
                    }
                }

            }
            return null;
        }
    }
}

