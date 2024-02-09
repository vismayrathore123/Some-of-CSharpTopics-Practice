using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstructor
{
    public class Student
    {
        public int MyProperty { get; set; }
        public string MyProperty2 { get; set; }
        //default constructor
        public Student()
        {
            MyProperty = 0;
            MyProperty2 = "Default";

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();//call the default constructor
        }
    }
}
