using System;

namespace CIA_Agent
{
    class Program
    {
        static void Main(string[] args)
        {
            CentralIntelligenceAgency cia = new CentralIntelligenceAgency();
            cia.Run();
        }
    }

    class CentralIntelligenceAgency // A.k.a the CIA.
    {
        public void Run()
        {
            SecretAgent secretAgent = new SecretAgent();

            // Named Method
            secretAgent.CollectEncryptedIntelligence(DecryptIntelligence);

            //// Lambda expression
            //secretAgent.CollectEncryptedIntelligence();
        }

        public string DecryptIntelligence(string encryptedIntelligence)
        {
            // Decrypt (I.e. reverse the string).
            char[] charArr = encryptedIntelligence.ToCharArray();
            Array.Reverse(charArr);
            string plainText = new string(charArr);

            // Return decrypted (reversed) string.
            return $"\nThe next president of the USA is {plainText.ToUpper()}\n";
        }
    }

    class SecretAgent // Imagine a class in a "class library" where we only have the DLL.
    {
        public void CollectEncryptedIntelligence(Func<string, string> decrypt)
        {
            Console.WriteLine("- Secret agent collecting intelligence...");

            string intelligence = "pmurT eoJ"; // Encrypted intelligence!
            Console.WriteLine("- Secret agent will now let the CIA handle the secret info (if CIA so wishes)");

            //intelligence = decrypt(intelligence);
            intelligence = decrypt?.Invoke(intelligence);

            Console.WriteLine(intelligence);
            Console.WriteLine("- Secret agent will now continue doing secret agent work...");
        }
    }
}
