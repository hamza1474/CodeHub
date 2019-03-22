using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATM
{
    class ATM
    {
        string typeOfTransaction;
        string cardType;
        string name;
        int cardNumber;
        int securityCode;
        int expiry;

        public int balance;
        public int pin;
        public ATM(string cardType, string name, int cardNumber)
        {
            this.cardType = cardType;
            this.name = name;
            this.cardNumber = cardNumber;
        }
        public void GetBalance()
        {
            StreamReader readBalance = new StreamReader(@"balance.txt");
            balance = int.Parse(readBalance.ReadLine());
            readBalance.Close();
        }
        public void SaveBalance()
        {
            StreamWriter saveBalance = new StreamWriter(@"balance.txt");
            saveBalance.WriteLine(balance);
            saveBalance.Close();
        }
        public void GetPin()
        {
            StreamReader getPin = new StreamReader(@"pin.txt");
            pin = int.Parse(getPin.ReadLine());
            getPin.Close();
        }
        public void ChangePin()
        {
            Console.WriteLine("Enter New PIN");
            int newPin = int.Parse(Console.ReadLine());
            Console.WriteLine("Confirm New PIN");
            if (int.Parse(Console.ReadLine()) == newPin)
            {
                StreamWriter changePin = new StreamWriter(@"pin.txt");
                changePin.WriteLine(Convert.ToString(newPin));
                Console.WriteLine("PIN changed successfully, please login with new PIN");
                changePin.Close();
            }
            else Console.WriteLine("PIN does not match");
        }
        public void Withdraw()
        {
            typeOfTransaction = "debit";
            Console.WriteLine("How much money you want to withdraw\nA: 500\nB: 1000\nC: 5000\nD: Custom Amount");

            int withdrawAmount = 0;
            switch (Console.ReadLine())
            {
                case "A":
                    withdrawAmount = 500;
                    break;
                case "B":
                    withdrawAmount = 1000;
                    break;
                case "C":
                    withdrawAmount = 5000;
                    break;
                case "D":
                CustomAmount:
                    Console.Write("Enter the amount> ");
                    withdrawAmount = int.Parse(Console.ReadLine());
                    if (withdrawAmount > 0) break;
                    else
                    {
                        Console.WriteLine("Invalid amount, please re-enter");
                        goto CustomAmount;
                    }

                default:
                    Console.WriteLine("No valid input detected");
                    break;
            }
            balance = balance - withdrawAmount;
            GenerateReceipt(withdrawAmount, typeOfTransaction);
            SaveBalance();
            Console.WriteLine("Your new balance is {0}", balance);

        }
        public void GenerateReceipt(int amount, string typeOfTransaction)
        {
            DateTime time = DateTime.Now;
            if (amount != 0)
            {
                string receipt;
                if (typeOfTransaction.ToLower() == "debit")
                {
                    receipt = ">>>> Amount " + amount + " debitted from account " + cardNumber + " at " + time + " <<<<";

                }
                else
                {
                    receipt = ">>>> Amount " + amount + " creditted to account " + cardNumber + " at " + time + " <<<<";
                }
                Console.WriteLine(receipt);
                AddReceiptToFile(receipt);
            }
            else Console.WriteLine("Invalid Input");
        }
        public void AddReceiptToFile(string receipt)
        {
            if (File.Exists(@"lastTransactions.txt"))
            {
                string oldText = File.ReadAllText(@"lastTransactions.txt");
                using (var sw = new StreamWriter(@"lastTransactions.txt", false))
                {
                    sw.WriteLine(receipt);
                    sw.WriteLine(oldText);
                }
            }
            else File.WriteAllText(@"lastTransactions.txt", receipt);
        }
        public void LastFiveTrans()
        {
            using (var fileStream = new FileStream(string.Format(@"lastTransactions.txt"), FileMode.Open))
            using (var streamReader = new StreamReader(fileStream))
            {
                Console.WriteLine("Your Last Five Transactions Are");
                string[] trans = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    trans[i] = streamReader.ReadLine();
                }
                foreach (string str in trans)
                {
                    Console.WriteLine(str);
                }
            }
        }
        public void Deposit()
        {
            typeOfTransaction = "credit";
            Console.Write("Enter the amount you want to deposit> ");
            int depositAmount = int.Parse(Console.ReadLine());
            if (depositAmount > 0)
            {
                balance = balance + depositAmount;
                GenerateReceipt(depositAmount, typeOfTransaction);
                SaveBalance();
                Console.WriteLine("Your new balance is {0}", balance);
            }
            else
            {
                Console.WriteLine("Invalid amount, please re-enter");
            }

        }
    }
}
