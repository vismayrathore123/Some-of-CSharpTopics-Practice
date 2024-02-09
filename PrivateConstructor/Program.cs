using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructor
{
    public class MyClass
    {
        private MyClass()
        {
            Console.WriteLine("private constructor called ");
        }
        public static MyClass CreateInstance()
        {
            return new MyClass();
        }
        public void PublicMethod()
        {
            Console.WriteLine("calling public method ");

               
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject=MyClass.CreateInstance();
            myObject.PublicMethod();
            Console.ReadLine();
        }
    }
}
