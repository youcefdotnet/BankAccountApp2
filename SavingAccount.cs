using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp2
{
    public class SavingAccount: BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingAccount(string owner, decimal interestrate): base(owner+ " (% "+ interestrate+")")
        {
            InterestRate = interestrate;
        }

        public override string Deposit(decimal amount)
        {

            if (amount <= 0)
                return "nothing to deposit";

            if (amount > 20000)
                return "ANti Laundry Law prohibit a deposit of such amount";

            decimal amountinterest = amount *InterestRate/100;
            Balance += amount + amountinterest;

            return "Deposit made successfully";
        }

    }
}
