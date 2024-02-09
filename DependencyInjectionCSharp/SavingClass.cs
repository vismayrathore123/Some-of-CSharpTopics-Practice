﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionCSharp.Interface;

namespace DependencyInjectionCSharp
{
    public class SavingClass : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Calling saving class");
        }
    }
}
