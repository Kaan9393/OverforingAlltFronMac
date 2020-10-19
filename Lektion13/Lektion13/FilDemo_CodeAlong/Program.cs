using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace FilDemo_CodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Läser hela texten i filen:
            string text = File.ReadAllText("data.txt");
            Console.WriteLine(text);

            string text2 = File.ReadAllText("data2.txt");
            Console.WriteLine(text2);

            Hashtable dataList = new Hashtable();

            //Nu ska vi dela upp texten. Varje gång det finns radbrytning delas den upp. Dvs att det blir 3 stk string
            string[] dataLines = text2.Split('\n');

            foreach (string data in dataLines)
            {
                string[] keyValue = data.Split('=');
                //Lägger in detta i listan.
                dataList.Add(keyValue[0], keyValue[1]);
                // 0 är första värdet dvs, name. 1 är andra, vilket e micke?
            }

            //för att se åldern i filen.
            Console.WriteLine(dataList["age"]);


            List<int> randomNumbers = new List<int>();
            Random rnd = new Random();
            //Vi skapar 10 slumptal och lägger i listan:
            for (int i = 0; i < 10; i++)
            {
                randomNumbers.Add(rnd.Next(1, 10000));
            }

            //Nu ska vi skriva ut det här:
            using (StreamWriter sw = new StreamWriter("slumptal.text", true))
            {                               //true gör så att listan fylls på. false gör så att nya tal kmr
                int counter = 0;
                foreach (int r in randomNumbers)
                {
                    sw.WriteLine("slumptal" + counter + "=" + r);
                    counter++;
                }
            }




            //Hashtable demoLista = new Hashtable();
            //demoLista.Add("VäderFredag", "Soligt med lite moln");
            //demoLista.Add("VäderLördag", "Regn och storm");
            ////Vi vill veta vädret på lördag
            //Console.WriteLine(demoLista["VäderLördag"]);   
        }
    }
}
