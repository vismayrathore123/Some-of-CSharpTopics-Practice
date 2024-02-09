using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectIntializer
{
    // Object Intializer- It is a new way to assign the value at the time of creation of object and
    // does not requires constructor call to assign field values;
    
    public class Student{
        public int Id { get; set; }
        public String name { get; set; }
        public int age { get; set; }
    
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // using object intializer
            Student student = new Student { Id = 101, name = "vismay", age = 24 };
            //displaying intialized values
            Console.WriteLine(student.Id);
            Console.WriteLine(student.name);
            Console.WriteLine(student.age);
            Console.ReadLine();
            
        }
    }
}
