using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Boolean.CSharp.Main
{
    public class SavingsAccount : AccountBase
    {
        public SavingsAccount(string accountname, BankStatementBuilder bankStatementBuilder) : base(accountname, bankStatementBuilder)
        {
        }
    }
}
