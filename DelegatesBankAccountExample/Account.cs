using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesBankAccountExample
{
    class Account
    {
        private int _balance;

        public delegate int Deposit(int deposit);
        public delegate int Withdrawal(int withdrawal);

        public Deposit AccountDeposit;
        public Withdrawal AccountWithdrawal;

        public int DepositRegular(int deposit)
        {
            _balance += deposit;
            return Balance;
        }
        public int DepositWhiteWash(int deposit)
        {
            if (deposit > 1000)
            {
                Console.WriteLine("Error!");
                return Balance;
            }
            _balance += deposit;
            return Balance;
        }

        public int WithdrawalRegular(int withdrawal)
        {
            _balance -= withdrawal;
            return Balance;
        }

        public int WithdrawalMaxThousand(int withdrawal)
        {
            if (withdrawal > 1000)
            {
                Console.WriteLine("Error!");
                return Balance;
            }
            _balance -= withdrawal;
            return Balance;
        }

        public int WithdrawalDebit(int withdrawal)
        {
            if (withdrawal > _balance)
            {
                Console.WriteLine("Error!");
                return Balance;
            }
            _balance -= withdrawal;
            return Balance;
        }

        public int Balance
        {
            get { return _balance; }
        }

    }
}
