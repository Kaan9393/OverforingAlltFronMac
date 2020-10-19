using System;

namespace LambdaDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Named method...
            //TakeAMethodAsParameter(VoidParameterLess);

            //Lambda expression...      --Ett annat sätt att göra en metod
            TakeAMethodAsParameter(() =>
                {
                    Console.WriteLine("Any old message");
                    Console.WriteLine("Another old message");
                });
        }

        static void VoidParameterLess()     //det här är en vanlig metod
        {
            Console.WriteLine("Any old message");
            Console.WriteLine("Another old message");
        }

        static void TakeAMethodAsParameter(Action a)
        {
            a();
        }
    }
}
