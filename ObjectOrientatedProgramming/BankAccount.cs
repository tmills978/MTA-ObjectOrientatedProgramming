﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientatedProgramming
{
    class BankAccount
    {
        private string AcctName;
        private decimal balance;
        public void Deposit(decimal money)
        {
            balance = balance + money;
        }

        public void Withdraw(decimal money)
        {
            if (money <= balance)
                balance = balance - money;
        }

        public string Statement()
        {
            return "Account " + AcctName + "\x0A Balance: £" + string.Format("{0:0.00}", balance);
        }

        public BankAccount(string name)
        {
            AcctName = name;
        }
        public BankAccount()
        {
            AcctName = "Temp Account";
        }
        public string GetAccount()
        {
            return AcctName;
        }

    }
}
