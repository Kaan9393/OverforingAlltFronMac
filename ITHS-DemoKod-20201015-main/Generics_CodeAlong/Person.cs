using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_CodeAlong
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int BirthYear { get; set; }

        //Antingen skriver man som här nedan, eller:
        public int Age => DateTime.Now.Year - BirthYear;
       
        //Eller såhär: 
        //public int Age 
        //{ 
        //    get
        //    {
        //        return DateTime.Now.Year - BirthYear;
        //    }
        //}
    }
}
