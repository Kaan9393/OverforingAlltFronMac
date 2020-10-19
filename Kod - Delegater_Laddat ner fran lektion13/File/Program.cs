using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("data.txt");
            // Du får felet "System.IO.FileNotFoundException: 'Could not find file 'C:\Users\Mikael Engström\OneDrive\Zocom\ITHS\Csharp\Lektion13\Kod\ConsoleApp1\bin\Debug\netcoreapp3.1\data.txt'.'"
            // Skapa en fil på den plats som saknar filen.
            Console.WriteLine(text);


            string text2 = File.ReadAllText("data2.txt");
            string[] dataParts = text2.Split('\n');

            Hashtable demo = new Hashtable();
            demo.Add("VäderinfoFredag", "Imorgon kommer det regna");
            demo.Add("VäderinfoLördag", "I helgen lyser solen");
            Console.WriteLine(demo["VäderinfoLördag"]);



            Hashtable dataList = new Hashtable();
            foreach(string data in dataParts)
            {
                string[] keyValue = data.Split('=');
                dataList.Add(keyValue[0], keyValue[1]);      
            }

            Console.WriteLine(dataList["data2"]);


            foreach(string key in dataList.Keys)
            {
                Console.WriteLine(key + " har värdet " + dataList[key]);
            }


            List<int> randomNumbers = new List<int>();
            Random rnd = new Random();
            for(int i = 1; i < 10; i++)
            {
                randomNumbers.Add(rnd.Next(1, 10000));
            }


            int counter = 0;
            StreamWriter sw = new StreamWriter("slumptal.txt", true); // Append = true
            foreach (int r in randomNumbers)
            {
                sw.WriteLine("Slumptal " + counter + "=" + r);
                counter++;
            }
            sw.Close(); // Viktigt


            counter = 0;
            using (StreamWriter sw2 = new StreamWriter("slumptal2.txt", true))
            {
                foreach (int r in randomNumbers)
                {
                    sw2.WriteLine("Slumptal " + counter + "=" + r);
                }
            }
        }
    }
}
