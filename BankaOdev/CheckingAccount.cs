using System;

namespace BankSystem
{

    public class CheckingAccount : BankAccount
    {

        public int DailyTransactionLimit { get; set; } = 1000;

        public CheckingAccount(string accountHolder, decimal initialBalance)
            : base(accountHolder, initialBalance)
        {
        }

        public CheckingAccount(string accountHolder, decimal initialBalance, int transactionLimit)
            : base(accountHolder, initialBalance)
        {
            DailyTransactionLimit = transactionLimit;
        }

        public override decimal CalculateInterest()
        {
            // Vadesiz hesaplar faiz kazanmaz
            Console.WriteLine("Checking accounts do not earn interest.");
            return 0;
        }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine("CHECKING ACCOUNT");
            base.DisplayAccountInfo();
            Console.WriteLine($"Daily Transaction Limit: {DailyTransactionLimit:C}");
        }
    }
}