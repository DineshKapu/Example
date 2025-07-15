using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Csharp
{
    public class DailyLimitExceededException : Exception
    {
        public decimal AttemptedAmount { get; }

        public DailyLimitExceededException(string message, decimal attemptedAmount)
            : base(message)
        {
            AttemptedAmount = attemptedAmount;
        }
    }

    public class BankAccount
    {
        private decimal balance;
        private const decimal DailyLimit = 50000m;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > DailyLimit)
            {
                throw new DailyLimitExceededException(
                    $"Withdrawal amount ₹{amount} exceeds the daily limit of ₹{DailyLimit}.", amount);
            }

            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            balance -= amount;
            Console.WriteLine($"Successfully withdrawed: {amount}");
            Console.WriteLine($" Remaining balance: {balance}");
        }
    }

    // Step 3: Test Program
    public class ExceptionEg
    {
        public static void Main()
        {
            var account = new BankAccount(100000m);

            try
            {
                account.Withdraw(50000m); 
            }
            catch (DailyLimitExceededException ex)
            {
                Console.WriteLine($"Transaction failed: {ex.Message} (Attempted: ₹{ex.AttemptedAmount})");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.Read();
        }
    }
}