using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializes_and_Access_data_throught_method
{
    class Student
    {
        public int Id;
        public String Name;

        public void Insert(int i, String n)
        {
            Id = i;
            Name = n;
        }
        public void Display()
        {
            Console.Write(Id + "  " + Name);
        }
    }
    public class Program
    {
       public static void Main(string[]args)
        {
            Student sc=new Student();
            Student sc1 = new Student();
            sc.Insert(1,"vismay");
            sc1.Insert(2, "shanu");
            sc.Display();
            sc1.Display ();
            Console.ReadLine();
          
        }
    }
}
