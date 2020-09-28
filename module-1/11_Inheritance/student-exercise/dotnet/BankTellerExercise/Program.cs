using BankTellerExercise.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount CheckingAccount = new CheckingAccount("Bernice", "CHK:1234");
            BankAccount SavingsAccount = new SavingsAccount("Bernice", "SAV:9876");

            decimal amountToDeposit = 231212310.00M;
            decimal newBalance = CheckingAccount.Deposit(amountToDeposit);
            Console.WriteLine("New Balance: " + newBalance.ToString("C1"));

        }
    }
}
