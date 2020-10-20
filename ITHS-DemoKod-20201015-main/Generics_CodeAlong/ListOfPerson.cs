using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics_CodeAlong
{
    class ListOfPerson : IEnumerable, IEnumerator
    {
        //Vi ska lagra en kollektion av instanser av Person

        Person[] people = new Person[4];
        int usedElementInPeople = 0;
        int loopIndex = -1;

        public void Add(Person p)
        {
            people[usedElementInPeople] = p;
            usedElementInPeople++;
        }

        public object Current => people[loopIndex];

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            loopIndex++;
            return loopIndex < usedElementInPeople; //Om det finns element kvar att loopa igenom i min array
        }

        public void Reset()
        {
            loopIndex = -1;
        }
    }

   
}
