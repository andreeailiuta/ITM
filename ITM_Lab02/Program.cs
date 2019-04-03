using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITM_Lab02
{
    class Program       
    {
        
        static void Main(string[] args)
        {
            //create bank
            Console.WriteLine(" ---Please create a new bank---");
            Console.WriteLine("Insert the bank name:");
            var bankName = Console.ReadLine().ToString();
            System.Threading.Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine(" ---Please create a new bank---");
            Console.WriteLine("Insert banck address");
            var bankAddress = Console.ReadLine();
            System.Threading.Thread.Sleep(800);
            Console.Clear();
            var bank = new Bank(bankName, bankAddress);
            Console.WriteLine("Bank {0} with address in {1} was created ", bank.BankName, bank.BankAddress);
            System.Threading.Thread.Sleep(800);
            Console.Clear();
            //main menu
            if (bank.BankName != null && bank.BankName != null)
            {
                DisplayMenu();
                Operations(bank);
            }

            else
            {
                Console.WriteLine("No bank was created!");
            }

        }

        // ITM Menu
        static void DisplayMenu()
        {
            Console.WriteLine("   Please select option:");
            Console.WriteLine("Create account ----------> press \"1\" ");
            Console.WriteLine("Deposit ---------> press \"2\" ");
            Console.WriteLine("Withdraw ---------> press \"3\" ");
            Console.WriteLine("Display sold ----> press \"4\" ");
            Console.WriteLine("Exit -------------> press \"5\" ");
        }

       
        
        // Opeations
        static void Operations(Bank bank)
        {
            bool operation = true;

            while (operation)
            {
                var menuOption = Convert.ToInt32(Console.ReadLine());
                DisplayMenu();

                switch (menuOption)
                {
                    //Create Account
                    case 1:
                        
                        Console.Clear();
                        Console.WriteLine("       Create new account");
                        Console.WriteLine("Insert account name:");
                        var accountName = Console.ReadLine();
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("         Create new account");
                        Console.WriteLine("Insert account address:");
                        var accountAddress = Console.ReadLine();
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("         Create new account");
                        Console.WriteLine("Insert account iban:");
                        var accountIban = Console.ReadLine();
                        System.Threading.Thread.Sleep(1000);
                       
                        Console.Clear();
                        bank.CreatAccount(accountName, accountAddress, accountIban);
                       
                        System.Threading.Thread.Sleep(1200);
                        Console.Clear();
                        DisplayMenu();                        
                        break;
                    //Deposit
                    case 2:
                        Console.Clear();
                        Console.WriteLine("      Deposit");
                        Console.WriteLine("Please insert the Iban:");
                        var iban = Console.ReadLine();
                        var foundAccount = bank.GetAccount(iban);
                        
                        if (foundAccount != null)
                        {
                            Console.WriteLine("Insert amount you want to deposit:");
                            var amout = Convert.ToInt32(Console.ReadLine());
                            foundAccount.AddDeposit(amout);                            
                            
                        }
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();                        
                        DisplayMenu();                        
                        break;
                    //Withdraw
                    case 3:
                        Console.Clear();
                        Console.WriteLine("      Withdraw");
                        Console.WriteLine("Please insert the Iban:");
                        iban = Console.ReadLine();
                        foundAccount = bank.GetAccount(iban);

                        if (foundAccount != null)
                        {
                            Console.WriteLine("Insert amount you want to withdraw:");
                            var amout = Convert.ToInt32(Console.ReadLine());
                            foundAccount.WitdrawFromDeposit(amout);
                        }
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();                       
                        DisplayMenu();
                        break;
                    //Display amount
                    case 4:
                        Console.Clear();
                        Console.WriteLine("     Display sold");
                        Console.WriteLine("Please insert the Iban:");
                        iban = Console.ReadLine();
                        foundAccount = bank.GetAccount(iban);

                        if (foundAccount != null)
                        {
                            foundAccount.DisplayAmount(iban);                          
                        }           
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                        DisplayMenu();
                        break;
                    //Exit
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Thank you. Have a good day!");
                        System.Threading.Thread.Sleep(1000);
                        operation = false;
                        Environment.Exit(0);
                        break;
                }
            }

        }
    }
}
