using System;

namespace Övning1_Delegater
{
    class Program
    {
        static void Accelerate()
        {

        }

        static void Decelerate()
        {

        }
        static void Main(string[] args)
        {
            Action carAction = Accelerate;
            carAction();

            carAction = Decelerate;
            carAction();
        }
    }
}
