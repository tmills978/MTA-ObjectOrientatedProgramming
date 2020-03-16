using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientatedProgramming
{
    class BankAccount
    {
        private string AcctName;
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
