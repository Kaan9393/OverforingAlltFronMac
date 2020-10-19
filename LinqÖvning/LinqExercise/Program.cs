using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person.AddPersonsToList(Person.person);
            //Det ovan går också att skriva men då måste man göra en List<Person> i Person classen.
            List<Person> person = new List<Person>();
            Person.AddPersonsToList(person);

            Console.WriteLine("2.A -------------------------------------------");

            var q1 = person
                .Where(p => p.Name.ToLower().StartsWith("and"));

            foreach (var item in q1)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("2.B -------------------------------------------");

            var q2 = person
                .Where(p => p.NameDay.Day == 23 && p.NameDay.Month == 7);
            foreach (var item in q2)
            {
                Console.WriteLine($"{item.Name}, {item.NameDay}");
            }

            Console.WriteLine("2.C -------------------------------------------");

            var q3 = person
                .Where(p => p.Name.ToLower().StartsWith("p") && p.NameDay.Month == 4);
            foreach (var item in q3)
            {
                Console.WriteLine($"{item.Name}, {item.NameDay}");
            }

            Console.WriteLine("3. ----------------------------------------------");

            //Console.WriteLine("Mata in namn som du vill se");
            //string inputName = Console.ReadLine();

            //var q4 = person
            //    .Where(p => p.Name.Contains(inputName));
            //foreach (var item in q4)
            //{
            //    Console.WriteLine($"{item.Name}, {item.NameDay}");
            //}

            Console.WriteLine("4. ----------------------------------------------");

            //Console.WriteLine($"[1]Mata in Dag först\n[2]Mata in månad");
            //int inputDay = int.Parse(Console.ReadLine());
            //int inputMonth = int.Parse(Console.ReadLine());

            //var q5 = person
            //    .Where(p => p.NameDay.Day == inputDay && p.NameDay.Month == inputMonth);
            //foreach (var item in q5)
            //{
            //    Console.WriteLine($"{item.Name},{item.NameDay}");
            //}

            Console.WriteLine("5. ----------------------------------------------");

            //Console.WriteLine("Tryck på en bokstav för att lista namn");
            //string inputAlp = Console.ReadLine();

            //var q6 = person
            //    .GroupBy(p => p.Name.ToLower()
            //    .StartsWith(inputAlp));

            //foreach (var item in q6)        //Vill lägga in så namnen också syns?? Vet ej hur
            //{
            //    if (item.Key == true)
            //    {
            //        Console.WriteLine($"{item.Count()}");

            //        foreach (var group in item)
            //        {
            //            Console.WriteLine($"\t{group.Name}");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("6.A ----------------------------------------------");

            //var q7 = person
            //    .GroupBy(p => p.NameDay.Month)
            //    .OrderBy(p => p.Key);
            //foreach (var item in q7)
            //{
            //    Console.WriteLine($"Månad: {item.Key} \tAntal: {item.Count()}");
            //}

            Console.WriteLine("6.B ----------------------------------------------");

            var q8 = person
                //.Select(p => p.NameDay)
                .GroupBy(p => (p.NameDay.Month - 1) / 3)
                .OrderBy(p => p.Key);


            foreach (var item in q8)
            {
                Console.WriteLine($"Kvartal: {item.Key + 1} \tAntal: {item.Count()}");
            }

            Console.WriteLine("6.C ----------------------------------------------");

            var q9 = person
                .GroupBy(p => p.NameDay) //p.NameDay.ToString("yyy-MMM-d") för att få datum utskrivet
                .OrderByDescending(p => p.Count())
                .Take(5);
                

            foreach (var item in q9)
            {
                Console.WriteLine($"År: {item.Key}\tAntal: {item.Count()}");
            }
        }
    }
}
