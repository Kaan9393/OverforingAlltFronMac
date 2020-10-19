using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LINQ_Demo
{
    class Person : IEqualityComparer<Person>            //Håkan :ignonera IEquality...
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Titel { get; set; }
        public int BirthYear { get; private set; }
        public int Age          //Denna hämtar bara år och subtraherar med birthyear
        {
            get
            {
                return DateTime.Now.Year - BirthYear;
            }
        }

        // Alternative get syntax:
        //public int Age => DateTime.Now.Year - BirthYear;

        public Person(string firstName, string lastName, string titel, int birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            Titel = titel;
            BirthYear = birthYear;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Titel} {BirthYear} {Age}";
        }

        public bool Equals([AllowNull] Person x, [AllowNull] Person y)
        {
            return
                x.BirthYear == y.BirthYear &&
                x.FirstName.ToLower() == y.FirstName.ToLower() &&
                x.LastName.ToLower() == y.LastName.ToLower();
        }

        public int GetHashCode([DisallowNull] Person obj)
        {
            return obj.BirthYear.GetHashCode() + obj.FirstName.GetHashCode() + obj.LastName.GetHashCode();
        }
    }
}
