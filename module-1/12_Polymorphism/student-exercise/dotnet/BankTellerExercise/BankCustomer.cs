using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer
    {
        public string Name { get;  set; }
        public string Address { get;  set; }
        public string PhoneNumber { get;  set; }
        public bool IsVip
        {
            get
            {
                int allBalances = 0;

                foreach (IAccountable moneyAccs in allAccounts)
                {
                    allBalances += moneyAccs.Balance;
                }
                return allBalances >= 25000;
            }
        }
        private List<IAccountable> allAccounts = new List<IAccountable>();
            
        public void AddAccount(IAccountable newAccount)
        {
            allAccounts.Add(newAccount);
        }
        public IAccountable[] GetAccounts()
        {
            return allAccounts.ToArray();
        }
    }
}
