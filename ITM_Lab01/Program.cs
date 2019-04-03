using System;

namespace ITM_Lab01
{
    using System;

    namespace ITM_ATM_Laboratory0
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Please enter PIN code");
                // var pin= Convert.ToInt32(Console.ReadLine());

                var validPin = "1234";
                var numverOfTries = 0;

                while (numverOfTries < 3)
                {
                    var pinCode = Console.ReadLine();
                    if (int.TryParse(pinCode, out int wrongPin))
                    {
                        if (pinCode == validPin)
                        {
                            Console.Clear();
                            DisplayMenu();
                            ItmOperations();
                            //Console.WriteLine("Display menu");                       
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The PIN is incorrect. Try again!");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            if (numverOfTries < 3)
                            {
                                Console.WriteLine("Enter again PIN:");
                            }

                            numverOfTries = numverOfTries + 1;

                        }
                    }
                    else
                    {
                        Console.WriteLine($"{wrongPin} is not a valid PIN, please try again");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        if (numverOfTries < 3)
                        {
                            Console.WriteLine("Enter again PIN:");
                        }

                        numverOfTries = numverOfTries + 1;
                    }

                    if (numverOfTries == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Your card has beel blocked. Please contact the ITM administrator.");
                    }

                }
                Console.ReadLine();

            }

            // ITM Menu
            static void DisplayMenu()
            {
                Console.WriteLine("   Please select option:");
                Console.WriteLine("Deposit ----------> press \"1\" ");
                Console.WriteLine("Withdraw ---------> press \"2\" ");
                Console.WriteLine("Check balance ----> press \"3\" ");
                Console.WriteLine("Exit -------------> press \"4\" ");
            }

            //ITM Opeations
            static void ItmOperations()
            {
                bool operation = true;
               
                while (operation)                    
                {
                    var menuOption = Convert.ToInt32(Console.ReadLine());
                    DisplayMenu();
                   
                    switch (menuOption)
                    {
                        //Deposit
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Please insert the deposit amount:");
                            var depositAmount = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            AddToDeposit(depositAmount);
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            DisplayMenu();
                            operation = true;
                            break;
                        //Witdraw
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Please insert the amount you want to withdraw:");
                            var withdrawAmount = Convert.ToInt32(Console.ReadLine());
                            WithdrawFromDeposit(withdrawAmount);
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            System.Threading.Thread.Sleep(800);
                            DisplayMenu();
                            operation = true;
                            break;
                        //Display amount
                        case 3:
                            Console.Clear();
                            System.Threading.Thread.Sleep(1000);
                            DisplayAmount();
                            System.Threading.Thread.Sleep(800);
                            Console.Clear();
                            DisplayMenu();
                            operation = true;
                            break;
                        //Exit
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Thank you. Have a good day!");
                            System.Threading.Thread.Sleep(1000);
                            Environment.Exit(0);
                            break;
                    }
                }

            }
            static Amount initialAmount = new Amount();

            //make a deposit
            static void AddToDeposit(int sum)
            {

                initialAmount.InitialAmount += sum;
                Console.WriteLine("You have {0} $ into your account", initialAmount.InitialAmount);

            }

            //displays the initial amount 
            static void DisplayAmount()
            {

                Console.WriteLine("You have {0} $ into your account", initialAmount.InitialAmount);

            }

            //make a withdraw
            static void WithdrawFromDeposit(int sum)
            {

                if (initialAmount.InitialAmount > sum)
                {
                    initialAmount.InitialAmount -= sum;
                    Console.Clear();
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You have {0} $ into your account", initialAmount.InitialAmount);
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Would you like to print the receipt? Y/N");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Yes");
                    Console.WriteLine("No, I choose to protect nature");


                    var answer = Console.ReadKey();
                    //Console.WriteLine(answer.Key.ToString());

                    if (answer.Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(800);
                        Console.WriteLine("Printing receipt");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();

                    }
                    else if (answer.Key == ConsoleKey.N)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(800);
                        Console.WriteLine("Thank you for protecting the nature!");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                    }
                }

                else
                {
                    Console.WriteLine("Insufficient funds!");
                }
            }

        }

    }
}