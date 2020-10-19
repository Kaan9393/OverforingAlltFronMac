using System;

namespace Övning3_Delegater
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> foo = IsLessThan;

           

        }

        static bool IsLessThan(int i, int j)
        {
            if (i < j)
            {
                return true;
            }
            
            else if (i > j)
            {
                return false;
            }
        }
    }
}

