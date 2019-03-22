using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("=========================================\n        WELCOME TO ABC BANK ATM        \n=========================================");
            Console.WriteLine(">Insert your card then press Enter");
            Console.ReadKey();
            ATM user = new ATM("VISA", "Hamza", 1474);
            user.GetBalance();
            user.GetPin();
            Console.Write(">Enter your PIN> ");
            if (int.Parse(Console.ReadLine()) != user.pin) { Console.WriteLine("Incorrect PIN"); goto Start; }
        Menu:
            Console.Write("*Press A to check Balance\n*Press B to change PIN\n*Press C to withdraw amount\n*Press D to deposit amount\n*Press E to view your last 5 transactions>");
            switch (Console.ReadLine())
            {
                case "A":
                    {
                        Console.WriteLine("Your account balance is {0}", user.balance);
                        Console.WriteLine("Press any key to return to the Menu");
                        Console.ReadKey();
                        break;
                    }
                case "B":
                    {
                        user.ChangePin();
                        Console.WriteLine("Press any key to return to the Menu");
                        Console.ReadKey();
                        goto Start;
                    }
                case "C":
                    {
                        user.Withdraw();
                        Console.WriteLine("Press any key to return to the Menu");
                        Console.ReadKey();
                        break;
                    }
                case "D":
                    {
                        user.Deposit();
                        Console.WriteLine("Press any key to return to the Menu");
                        Console.ReadKey();
                        break;
                    }
                case "E":
                    {
                        user.LastFiveTrans();
                        Console.WriteLine("Press any key to return to the Menu");
                        Console.ReadKey();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Key Pressed");
                        Console.WriteLine("Press any key to return to the Menu");
                        Console.ReadKey();
                        break;
                    }
            }
           ;
            Console.WriteLine("=========================================");
            Console.WriteLine("=========================================\n        WELCOME TO ABC BANK ATM        \n=========================================");
            goto Menu;
        }
    }
  
}
