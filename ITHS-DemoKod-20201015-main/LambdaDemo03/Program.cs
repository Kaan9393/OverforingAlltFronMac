using System;

namespace LambdaDemo03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Named method...
            //TakeAMethodAsParameter(IntParameterless);

            //Lambda expression...
            TakeAMethodAsParameter(() => {
                Console.Write("Vänligen ange din ålder: ");
                return int.Parse(Console.ReadLine());
            });
        }

        //static int IntParameterless()
        //{
        //    Console.Write("Vänligen ange din ålder: ");
        //    return int.Parse(Console.ReadLine());
        //}

        static void TakeAMethodAsParameter(Func<int> a)
        {
            int i = a();
            Console.WriteLine($"i = {i}");
        }
    }
}
