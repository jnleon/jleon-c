namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {

        public SavingsAccount()
        {

        }
        public SavingsAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {
        }

        public SavingsAccount(string AccountHolderName, string AccountNumber, decimal Balance) : base(AccountHolderName, AccountNumber, Balance)
        {
        }
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal additionalServiceCharge = 2;

            if (amountToWithdraw > Balance || Balance -amountToWithdraw -additionalServiceCharge < 0)
            {
                return base.Withdraw(0);

            }                     
            if (Balance - amountToWithdraw < 150)
            {
                return base.Withdraw(amountToWithdraw + additionalServiceCharge);
            }
            return base.Withdraw(amountToWithdraw);
        }
    }
}
