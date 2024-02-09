using DependencyInjectionCSharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionCSharp
{
   
    public class Program
    {
        static void Main(string[] args) {
             IAccount ac=new CurrentClass();
            Account a = new Account(ac);
            a.PrintAccounts();
    } 
    }
}
