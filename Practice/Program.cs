using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Student {
        public int rollno;//field
        public String name;//field
    }
    public class Program
    {
        static void Main(string[] args)
        {
            
            Student sc=new Student();
            sc.rollno = 30;
            sc.name = "vismay";
            Console.WriteLine(sc.rollno);
            Console.WriteLine(sc.name);
            Console.ReadLine();
        }
    }
}
