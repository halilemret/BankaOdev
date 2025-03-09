using System;
using System.Collections.Generic;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Account Polymorphism Example");
            Console.WriteLine("=================================");

            var savingsAccount = new SavingsAccount("Ahmet Yılmaz", 5000);
            var checkingAccount = new CheckingAccount("Ayşe Demir", 3000);

            List<BankAccount> accounts = new List<BankAccount>
            {
                savingsAccount,
                checkingAccount,
                new SavingsAccount("Mehmet Şahin", 10000, 0.07m), // %7 faiz oranlı özel hesap
                new CheckingAccount("Zeynep Kaya", 2000, 1500)    // 1500 TL günlük limit
            };


            foreach (var account in accounts)
            {
                Console.WriteLine("\n-----------------------------");
                account.DisplayAccountInfo(); // Polimorfik çağrı

                // Para yatırma işlemi
                account.Deposit(1000);

                // Faiz hesaplama
                account.CalculateInterest();

                Console.WriteLine("-----------------------------\n");
            }

            Console.WriteLine("\nDirect operations with specific account types:");

            // Vadeli hesap işlemleri
            Console.WriteLine("\n=== Savings Account Operations ===");
            savingsAccount.Deposit(2000);
            savingsAccount.CalculateInterest();
            savingsAccount.Withdraw(1000);

            // Vadesiz hesap işlemleri
            Console.WriteLine("\n=== Checking Account Operations ===");
            checkingAccount.Deposit(500);
            checkingAccount.CalculateInterest();
            checkingAccount.Withdraw(1500);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}