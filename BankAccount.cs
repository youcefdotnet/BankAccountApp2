using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp2
{
    public class BankAccount
    {
        public string Owner {get; set;}
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;

        }

        public string Deposit(decimal amount)
        {

            if (amount <= 0)
                return "nothing to deposit";

            if (amount > 20000)
            return "ANti Laundry Law prohibit a deposit of such amount";  
                                  
            Balance += amount;
            return "Deposit made successfully";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                MessageBox.Show("Nothing to withdraw");

            Balance -= amount;
            return "Withdrawal made successfully";
        }

    }
}
