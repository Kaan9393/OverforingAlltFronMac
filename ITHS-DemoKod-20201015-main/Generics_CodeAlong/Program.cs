using System;
using System.Collections;

namespace Generics_CodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfPerson list = new ListOfPerson();
            list.Add(new Person { FirstName = "Håkan", LastName = "Johansson", BirthYear = 1962 });
            list.Add(new Person { FirstName = "Mrilyn", LastName = "Pot", BirthYear = 1911 });
            list.Add(new Person { FirstName = "Jan", LastName = "Zan", BirthYear = 2002 });
            list.Add(new Person { FirstName = "Hej", LastName = "Larsson", BirthYear = 1902 });

            foreach (Person person in list)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
