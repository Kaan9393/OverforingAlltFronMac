using System;

namespace Delegater03
{
    class Program
    {
        static bool IsLessThan(int i, int j)
        {
            return i < j;
        }

        public static void Main(string[] args)
        {
            Func<int, int, bool> a = IsLessThan;

            if(a(5, 10))
                Console.WriteLine("5 is less than 10");
        }

    }
}