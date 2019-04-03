using System;

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
            Console.WriteLine("Insert bank address");
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
            Console.WriteLine("Delete account ----> press \"5\" ");
            Console.WriteLine("Exit -------------> press \"6\" ");
        }

        //generate random iban from 1 to 20
        static int RandomNumber()
        {
            Random iban = new Random();
            return iban.Next(1, 20);
        }

        // Opeations
        static void Operations(Bank bank)
        {
            bool operation = true;
            var accountIban = RandomNumber();

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

                        System.Threading.Thread.Sleep(1000);

                        Console.Clear();
                        bank.CreatAccount(accountName, accountAddress, accountIban);

                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                        DisplayMenu();
                        break;
                    //Deposit
                    case 2:
                        Console.Clear();
                        Console.WriteLine("      Deposit");
                        Console.WriteLine("Insert amount you want to deposit:");
                        var depositAmount = Convert.ToInt32(Console.ReadLine());
                        bank.AddDeposit2(accountIban, depositAmount);
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                        DisplayMenu();
                        break;
                    //Withdraw
                    case 3:
                        Console.Clear();
                        Console.WriteLine("      Withdraw");
                        Console.WriteLine("Insert amount you want to withdraw:");
                        var amountWitdraw = Convert.ToInt32(Console.ReadLine());
                        bank.WitdrawFromDeposit2(accountIban, amountWitdraw);
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                        DisplayMenu();
                        break;
                    //Display amount
                    case 4:
                        Console.Clear();
                        Console.WriteLine("     Display sold");
                        bank.DisplayAmount2(accountIban);
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                        DisplayMenu();
                        break;
                    //Delete account
                    case 5:
                        Console.Clear();
                        Console.WriteLine("     Delete account");
                        Console.WriteLine("Enter the account name or iban:");
                        var deleteByNameOrIban = Console.ReadLine();
                          
                        string finalType = "String";
                        if (!string.IsNullOrEmpty(deleteByNameOrIban))
                        {
                            // Check integer before Decimal
                            int tryInt;                            
                            if (Int32.TryParse(deleteByNameOrIban, out tryInt))
                            {
                                finalType = "Integer";
                                bank.DeleteAccount(Convert.ToInt32(deleteByNameOrIban));
                            }
                            else 
                            {
                                finalType = "String";
                                bank.DeleteAccount(deleteByNameOrIban);
                            }

                        }

                        Console.WriteLine(finalType);


                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                        DisplayMenu();
                        break;
                    //Exit
                    case 6:
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
