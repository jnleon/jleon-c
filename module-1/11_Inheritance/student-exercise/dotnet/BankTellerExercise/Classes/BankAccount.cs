namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
      public string AccountHolderName { get; private set; }
      public string AccountNumber { get; set; }
        public decimal Balance { get; private set; } = 0;

        public BankAccount()
        {
        }
        public BankAccount(string AccountHolderName, string AccountNumber, decimal Balance)
        {
            this.AccountHolderName = AccountHolderName;
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }
        public BankAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
        }

        public virtual decimal Deposit(decimal amountToDeposit)
        {
            Balance += amountToDeposit;
            return Balance;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance -= amountToWithdraw;
            return Balance;
        }
     

    }
}
