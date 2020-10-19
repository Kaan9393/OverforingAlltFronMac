using System;

namespace GeneralStuff
{
    class Program
    {
        static void Accelerate()
        {
            Console.WriteLine("Vroom Vroom.");
        }

        static void Decelerate()
        {
            Console.WriteLine("Screeeeeeech");
        }

        public static void Main(string[] args)
        {
            Action carAction = Accelerate;
            carAction();

            carAction = Decelerate;
            carAction();
        }
    }
}