using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Demo
{
    // Anonymous types.
    // LINQ methods can be called on any class implementing the IEnumerable<T> interface.
    // Most LINQ methods are extension methods.
    // Deferred (execution) LINQ methods such as Where() always retun a collection.
    // Immediate (execution) LINQ methods such as Sum() always retun a single value.

    class LINQExamples
    {
        public static void Run()
        {
            //Enumerable
            List<Person> people = new List<Person>()
            {
                new Person("Håkan", "Johansson", "Lärare", 1962),
                new Person("Nathalie", "Johansson", "Barn", 2006),
                new Person("Marilyn", "Johansson", "Tandsköterska", 1976),
                new Person("Kenneth", "Johansson", "Barn", 2009),
                new Person("Mikael", "Engström", "Lärare", 1965),
                new Person("Anna", "Lindh", "Utrikesminister", 1957),
                new Person("Jan O", "Karlsson", "Utrikesminister", 1939),
                new Person("Laila", "Freivalds", "Utrikesminister", 1942),
                new Person("Bosse", "Ringholm", "Utrikesminister", 1942),
                new Person("Carin", "Jämtin", "Utrikesminister", 1964),
                new Person("Jan", "Eliasson", "Utrikesminister", 1940),
                new Person("Carl", "Bildt", "Utrikesminister", 1949),
                new Person("Margot", "Wallström", "Utrikesminister", 1954),
                new Person("Ann", "Linde", "Utrikesminister", 1961),
                new Person("Håkan", "Johansson", "Lärare", 1962),
            };

            var q1 = people
                //När man förkortar: 
                //.Where(p => p.Age < 65 && p.Titel.ToLower() == "utrikesminister");
                .Where(RetireesMethod); // Deferred execution   = Menas att den exekverar när den kmr in i foreach    
                //Tar in Person som parameter och returnerar en bool
                //Alla personer kommer att komma in i q1. Och denna metod listar alla personer som är pensionärer
                //Dessa pensionärer kommer komma med i den nya listan som skapats. Dvs q1.
            foreach (var item in q1)
                Console.WriteLine(item);

            Console.WriteLine("1--------------------------------------------");

            var q2 = people
                .Where(NonRetiredForeignMinistersMethod); // Deferred execution

            foreach (var item in q2)
                Console.WriteLine(item);

            Console.WriteLine("2--------------------------------------------");

            var q3 = people
                .Select(LastNameAgeMethod); // Deferred execution
            //*****Select = Vilken data som vi vill ha tillbaka från quarry. 
            //*****.Where = Tar fram rader      // Select tar fram kolumner  ---- Tänk som excel fil
            foreach (var item in q3)
                Console.WriteLine(item);

            Console.WriteLine("3--------------------------------------------");

            var q4 = people
                .Select(BirthYearMethod); // Deferred execution

            foreach (var item in q4)
                Console.WriteLine(item);

            Console.WriteLine("4--------------------------------------------");

            var q5 = people
                .FirstOrDefault(RetireesMethod); // Immediate execution             == Exekverar direkt, för q5 inte e Enumrable. Man ser det när när håller för q5.
                //

            Console.WriteLine(q5);

            Console.WriteLine("5-------------------------------------------");

            var q6 = people
                .LastOrDefault(RetireesMethod); // Immediate execution

            Console.WriteLine(q6);

            Console.WriteLine("6-------------------------------------------");

            var q7 = people
                .Max(BirthYearMethod); // Immediate execution. Also see Min, Average, and Sum

            Console.WriteLine(q7);

            Console.WriteLine("7-------------------------------------------");

            var q8 = people
                .OrderBy(ByLastNameMetod); // Deferred execution.

            foreach (var item in q8)
                Console.WriteLine(item);

            Console.WriteLine("8-------------------------------------------");
            //Först körs orderby, och sedan körs thenby. Så thenby sorterar från orderby
            //Thenby används om man vill sortera mer än en grej. Då lägger man till Thenby.
            var q9 = people
                .OrderBy(ByLastNameMetod) // Deferred execution. Also see: OrderByDescending and ThenByDescending
                .ThenBy(ByFirstNameMethod);

            foreach (var item in q9)
                Console.WriteLine(item);

            Console.WriteLine("9-------------------------------------------");

            var q10 = people
                .SingleOrDefault(CarlBildtMethod);

            Console.WriteLine(q10);

            Console.WriteLine("10------------------------------------------");

            var q11 = people
                .Take(4);

            foreach (var item in q11)
                Console.WriteLine(item);

            Console.WriteLine("11------------------------------------------");

            var q12 = people
                .ToList(); // Also see ToArray, ToDictionary, To... etc.

            foreach (var item in q12)
                Console.WriteLine(item);

            Console.WriteLine("12------------------------------------------");

            var q13 = people
                .Where(NonRetireesMethod)
                .OrderBy(ByLastNameMetod)
                .ThenBy(Ages)
                .Take(2)
                .Select(LastNameFirstNameAgeMethod);

            foreach (var item in q13)
                Console.WriteLine(item);

            Console.WriteLine("13------------------------------------------");

            var q14 = people
                .GroupBy(ByTitleMethod);

            foreach (var group in q14)
            {
                Console.WriteLine($"{group.Count()} {group.Key}");

                foreach (var person in group)
                    Console.WriteLine($"\t{person}");

                Console.WriteLine();
            }

            Console.WriteLine("14------------------------------------------");
        }

        static string ByTitleMethod(Person p)
        {
            return p.Titel;
        }

        static bool RetireesMethod(Person p)
        {
            //p.LastName = "ANDERSSON";
            return p.Age >= 65;
        }

        static bool NonRetiredForeignMinistersMethod(Person p)
        {
            return p.Titel.ToLower() == "utrikesminister" && p.Age < 65;
        }

        static string LastNameAgeMethod(Person p)
        {
            return $"{p.LastName} {p.Age}";
        }
        static int Ages(Person p)
        {
            return p.Age;
        }
        static int BirthYearMethod(Person p)
        {
            return p.BirthYear;
        }
        static string ByFirstNameMethod(Person p)
        {
            return p.FirstName;
        }
        static string ByLastNameMetod(Person p)
        {
            return p.LastName;
        }
        static bool CarlBildtMethod(Person p)
        {
            return p.FirstName.ToLower() == "carl" && p.LastName.ToLower() == "bildt";
        }

        static string LastNameFirstNameAgeMethod(Person p)
        {
            return $"Förnamn: {p.FirstName} Efternamn: {p.LastName} Age: {p.Age}";
        }

        static bool NonRetireesMethod(Person p)
        {
            return p.Age < 65;
        }
    }
}
