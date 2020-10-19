using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableDemo
{
    // LINQ methods can be called on any class implementing the IEnumerable interface.

    class MyClass : IEnumerable<string>, IEnumerator<string>
    {
        public int Count => data.Length;

        public string this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        int arrIndex = 0;
        //string[] data = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        string[] data = new string[] { "A", "B", "C" };

        public string Current => data[arrIndex++];

        object IEnumerator.Current => data[arrIndex++];

        public void Dispose()
        {
            Reset();
        }

        public IEnumerator<string> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext() => arrIndex < data.Length;

        public void Reset()
        {
            arrIndex = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //foreach (var item in DoYourStuff())
            //{
            //    Console.WriteLine(item);
            //}

            MyClass vs = new MyClass();
            vs[0] = "Anna";
            vs[2] = "Cecilia";
            //vs[4] = "Erika";

            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }

            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(vs[vs.Count - 1]);
        }

        static IEnumerable<int> DoYourStuff()
        {
            for (int i = 0; i < 5; i++)
            {
                yield return i + 1;
            }
        }
    }
}
