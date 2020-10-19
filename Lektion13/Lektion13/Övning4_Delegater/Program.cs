using System;

namespace Övning4_Delegater
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeMethod("ItHs", UpperorLowerCase);   
        }

        static bool UpperorLowerCase()
        {
            Console.WriteLine("Vill du skriva ut med [S]tora bokstäver annars små? ");
            string input = Console.ReadLine();
            return input.ToLower() == "s";
        }
        static void SomeMethod(string message, Func<bool> foo)
        {
            //Foo returnerar true eller false

            if (foo())
            {
                Console.WriteLine(message.ToUpper());
            }
            else
                Console.WriteLine(message.ToLower());
            

        }
    }
}
