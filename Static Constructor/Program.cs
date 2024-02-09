using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    public class Student
    {
        static int age;
        static Student()
        {
            Console.WriteLine("static constructor");
            age = 32;

        }
        public static void Dispaly()
        {
            Console.WriteLine($"{age}");
        }
    }
    public  class Program
    {
        static void Main(string[] args)
        {
            Student.Dispaly();
            Student.Dispaly();
            Console.ReadLine();
        }
    }
}
