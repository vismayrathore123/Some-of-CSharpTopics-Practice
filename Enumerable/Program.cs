using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class Program
    {
        static void Main(string[] args)
        {
            var names = new List<int>() { 1,2,3,4,5,6,7,8,9};
            //iteration using enumberable
            IEnumerator  <int> enumerator =names.GetEnumerator();
            while(enumerator.MoveNext())
            {
                int number=enumerator.Current;
                Console.WriteLine(number);
                Console.ReadLine();
            }

        }
    }
}
