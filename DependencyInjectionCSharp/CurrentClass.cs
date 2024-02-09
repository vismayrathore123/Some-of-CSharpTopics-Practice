using DependencyInjectionCSharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionCSharp
{
    public class CurrentClass : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("calling current class");
        }
    }
}
