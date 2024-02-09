using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class DataStore<T>
    {
        private T[] _data = new T[10];
        public void AddOrUpdate(int index, T item)
        {
            if(index>=0 && index<_data.Length)
            {
                _data[index] = item;
            }

        }
        public T GetData(int index)
        {
            if(index>= 0 && index<_data.Length) { return _data[index]; }
            else { return default(T); }

        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            DataStore<int> sc = new DataStore<int>();
            sc.AddOrUpdate(0, 100);
            sc.AddOrUpdate(0, 50);
            Console.WriteLine(sc.GetData(0));
            Console.WriteLine(sc.GetData(1));

            DataStore<string> stringDataStore = new DataStore<string>();
            stringDataStore.AddOrUpdate(0, "Hello");
            stringDataStore.AddOrUpdate(1, "World");
            Console.WriteLine(stringDataStore.GetData(0));
            Console.WriteLine(stringDataStore.GetData(1));
            Console.ReadLine();        
        }
    }
}
