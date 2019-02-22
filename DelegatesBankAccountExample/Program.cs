using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesBankAccountExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Account nikolajsAccount = new Account();
            Account johansAccount = new Account();

            nikolajsAccount.AccountDeposit = nikolajsAccount.DepositRegular;
            nikolajsAccount.AccountWithdrawal =
                nikolajsAccount.WithdrawalRegular;

            johansAccount.AccountDeposit = johansAccount.DepositWhiteWash;
            johansAccount.AccountWithdrawal = johansAccount.WithdrawalDebit;

            Console.WriteLine(nikolajsAccount.AccountDeposit(3));
            Console.WriteLine(johansAccount.AccountDeposit(1001));

            Console.WriteLine(nikolajsAccount.AccountDeposit(10));
            Console.WriteLine(johansAccount.AccountWithdrawal(1000));
        }
    }
}
