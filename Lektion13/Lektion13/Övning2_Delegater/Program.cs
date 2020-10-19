using System;

namespace Övning2_Delegater
{
    class Program
    {

        static void Main(string[] args)
        {
            Action<string, bool> a = PrintIt;
            a("ItHs", false);
        }

        static void PrintIt(string s, bool b)
        {
            if (b)
            {
                Console.WriteLine(s.ToUpper());
            }
            else
                Console.WriteLine(s.ToLower());

        }
    }
   
}
