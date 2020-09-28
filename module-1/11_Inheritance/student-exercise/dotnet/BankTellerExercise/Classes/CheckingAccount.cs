namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount()
        {
        }

        public CheckingAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {
        }
        public CheckingAccount(string AccountHolderName, string AccountNumber, decimal Balance):base(AccountHolderName, AccountNumber, Balance)
        { 
        }


        public override decimal Withdraw (decimal amountToWithdraw)
        {
            decimal overdraftFee = 10;
            if (Balance - amountToWithdraw < 0 && Balance - amountToWithdraw > -100)
            {
                return base.Withdraw(amountToWithdraw + overdraftFee);
            }
            if (Balance - amountToWithdraw > 0)
            {
                return base.Withdraw(amountToWithdraw);
            }
            else if (Balance - amountToWithdraw < -100)
                return -100;

            return base.Withdraw(Balance);
        }
    }

}