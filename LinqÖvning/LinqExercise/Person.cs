using System;
using System.Collections.Generic;
using System.IO;

namespace LinqExercise
{
    class Person
    {
        public string Name { get; set; }
        public DateTime NameDay { get; set; }
        public static void AddPersonsToList(List<Person> persons)
        {
            const string filePath = @"C:\Users\KaanWin\source\repos\OverforingAlltFronMac\LinqÖvning\LinqExercise\bin\Debug\netcoreapp3.1\names.csv";
            //const string filePath = @"C:\Data\C#\Academy\2018\HT\Patriks övningar\Övning_24_LINQ\Övning_24_LINQ\names.csv";
            

            foreach (string person in File.ReadLines(filePath, System.Text.Encoding.UTF7))
            {
                string[] personData = person.Split(';');        //det här splittar och skiljer på Name för sig och Födelsedagsdatum för sig

                if (PersonNotInList(personData[0], persons))
                {
                    Person p = new Person();
                    p.Name = personData[0];
                    p.NameDay = DateTime.Parse(personData[1]);

                    persons.Add(p);

                    // OR ...
                    //persons.Add(new Person { Name = personData[0], NameDay = DateTime.Parse(personData[1]) });
                }

                //rowCount++;
            }
           // Console.WriteLine($"");
        }

        public static bool PersonNotInList(string name, List<Person> persons)
        {
            bool nameFound = false;

            foreach (Person person in persons)
            {
                nameFound = person.Name.ToLower() == name.ToLower();

                if (nameFound)
                    break;
                //Om vi hittar ett namn så drar vi oss ifrån den här loopen.
            }

            return !nameFound;
            //Om personen redan finns i listan
        }

    }
}
