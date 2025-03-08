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

        public SavingAccount(string owner, decimal interestrate): base(owner)
        {
            InterestRate = interestrate;
        }
    }
}
