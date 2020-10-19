using System;

namespace AnonymousDelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> a = delegate (int i)
            {
                return i < 10;
            };

            if (a(5))
                Console.WriteLine("Yes!");

            SomeMethod(delegate (int i)
            {
                return i < 10;
            });
        }

        static void SomeMethod(Func<int, bool> f)
        {
            if (f(7))
                Console.WriteLine("Yes!");
        }
    }
}
