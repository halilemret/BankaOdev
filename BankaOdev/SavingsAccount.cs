using System;

namespace BankSystem
{

    public class SavingsAccount : BankAccount
    {
        // Faiz oranı
        public decimal InterestRate { get; private set; } = 0.05m; // %5 varsayılan faiz oranı


        public SavingsAccount(string accountHolder, decimal initialBalance)
            : base(accountHolder, initialBalance)
        {
        }

        public SavingsAccount(string accountHolder, decimal initialBalance, decimal interestRate)
            : base(accountHolder, initialBalance)
        {
            InterestRate = interestRate;
        }

        public override decimal CalculateInterest()
        {
            // Vadeli hesaplar için bakiyenin %5'i (veya belirtilen oran) kadar faiz hesapla
            decimal interest = Balance * InterestRate;
            Console.WriteLine($"Interest earned: {interest:C} (Rate: {InterestRate:P0})");

            // Hesaplanan faizi bakiyeye ekle
            Balance += interest;
            Console.WriteLine($"New balance after interest: {Balance:C}");

            return interest;
        }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine("SAVINGS ACCOUNT");
            base.DisplayAccountInfo();
            Console.WriteLine($"Interest Rate: {InterestRate:P0}");
        }
    }
}