using System;

namespace ExtensionMethod_CodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Man kan lägga till ExtensionMethods. Genom att skapa en klass. 

            if (ExtensionMethods.IsOdd(9))
                Console.WriteLine("Udda tal");


            int i = 7;
            if (i.IsOdd())          //ExtensionMethod utförs här. Det ovan exp e inte extension.
                Console.WriteLine("Udda tal");

            //-----------------------------------------------------------------

            int j = ExtensionMethods.ToInt("1962");
            int k = "1962".ToInt();     //Vi kan använda den här syntaxen med extensionmethods. När vi lägger till this.


            //---------------------------------------------------------

            if (ExtensionMethods.IsOdd(ExtensionMethods.ToInt(Console.ReadLine())))
                Console.WriteLine("udda tal");

            
            if (Console.ReadLine().ToInt().IsOdd())
                Console.WriteLine("udda tal");
        
        }
    }      
}
