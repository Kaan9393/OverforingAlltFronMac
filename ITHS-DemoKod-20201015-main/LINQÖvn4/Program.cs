using System;

namespace LINQÖvn4
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeMethod("ItHs", UpperOrLowerCase);
        }

        static bool UpperOrLowerCase()
        {
            Console.Write("Vill du skriva ut med [S]tora bokstäver annars små?: ");
            string input = Console.ReadLine();
            return input.ToLower() == "s";
        }

        static void SomeMethod(string message, Func<bool> foo)
        {
            if(foo())
                Console.WriteLine(message.ToUpper());
            else
                Console.WriteLine(message.ToLower());
        }
    }
}
