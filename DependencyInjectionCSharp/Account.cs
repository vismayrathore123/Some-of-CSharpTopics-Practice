using DependencyInjectionCSharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionCSharp
{
    public class Account
    {
        //variable name interface type
        private IAccount account;
        public Account(IAccount account)//paramterized constructor
        {
            this.account = account;
        }
        public void PrintAccounts() 
        {
            account.PrintDetails();
        }


    }
}
