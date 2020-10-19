namespace MerryMethodsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodBench methodBench = new MethodBench();

            int count = 0;
            do
            {
                count++;
                MethodBench.FirstMethod();

            } while (count < 3);


            
        }
    }
}
