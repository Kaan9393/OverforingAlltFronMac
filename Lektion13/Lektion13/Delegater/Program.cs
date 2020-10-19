using System;
using System.Collections.Generic;

namespace Delegater
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            {
                new Person() { Name = "Johansson", Age = 58},
                new Person() { Name = "Andersson", Age = 85 },
                new Person() { Name = "Jansson", Age = 45 },
                new Person() { Name = "Pettersson", Age = 35 },
                new Person() { Name = "Andersson", Age = 25 },
            }

            people.Sort(MyComparison);

            foreach (Person i in people)
            {
                Console.WriteLine($"{i.Name} {i.Age}");
            }
            
        }
        static int MyComparison(Person you, Person me)
        {
            if (string.Compare(you.Name, me.Name) < 0)           //När man ska sortera på string går det inte att skriva <, >
            {               //Om you mindre än me...->
                return -1;
            }
            else if (string.Compare(you.Name, me.Name) > 0)
                return 1;   //om det inte är sant
            else if (you.Age < me.Age)
            {
                return -1;
            }

            else if (you.Age > me.Age)
            {
                return 1;
            }
            else
                return 0;

        }
    }
}
