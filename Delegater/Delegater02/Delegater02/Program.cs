using System;

namespace Delegater02
{
    class Program
    {
        static void PrintIt(string s, bool upper)
        {
            if (upper)
                Console.WriteLine(s.ToUpper());
            else
                Console.WriteLine(s.ToLower());
        }

        public static void Main(string[] args)
        {
            Action<string, bool> a = PrintIt;
            a("Academy", true);
        }
    }
}
