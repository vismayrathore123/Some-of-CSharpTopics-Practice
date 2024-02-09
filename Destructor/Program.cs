using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    
    class Destructor
    {
       public Destructor()
        {
            Console.WriteLine("constructor invoked");

        }
        ~ Destructor() {
            Console.WriteLine("destructor invoked");        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Destructor sc = new Destructor();
            Destructor sc1=new Destructor();
            Console.ReadLine();

        }
    }
}
