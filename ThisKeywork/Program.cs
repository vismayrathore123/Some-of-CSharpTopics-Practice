using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeywork
{
   public class Student
    {
        public int Id;
        public string Name;
        public int age;
        public Student(int id, string  name, int age )
        {
            this.Id = id;
            this.Name = name;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine(Id+""+Name+""+age);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student sc = new Student(101, "Sonu", 20);
            Student sc2 = new Student(102, "Vismay", 24);
            sc.Display();
            sc2.Display();
            Console.ReadLine();

        }
    }
}
