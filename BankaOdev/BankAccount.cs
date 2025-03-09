using System;

namespace BankSystem
{

    public class BankAccount
    {

        public string AccountHolder { get; set; }

        public decimal Balance { get; set; }


        public BankAccount(string accountHolder, decimal initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public virtual decimal CalculateInterest()
        {

            Console.WriteLine("Base interest calculation method called.");
            return 0;
        }

        // Para yatırma işlemi
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"{amount:C} deposited. New balance: {Balance:C}");
        }

        // Para çekme işlemi
        public virtual bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return false;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return false;
            }

            Balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn. New balance: {Balance:C}");
            return true;
        }

        // Hesap bilgilerini görüntüleme
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Current Balance: {Balance:C}");
        }
    }
}