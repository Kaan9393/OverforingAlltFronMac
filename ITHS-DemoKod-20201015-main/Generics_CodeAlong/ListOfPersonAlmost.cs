using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics_CodeAlong
{
    class ListOfPersonAlmost : IEnumerable<Person>, IEnumerator<Person>
    {
        Person[] people = new Person[2];
        int usedElementInPeople = 0;
        int loopIndex = -1;

        public void Add(Person p)
        {
            people[usedElementInPeople] = p;
            usedElementInPeople++;
        }

        public Person Current => people[loopIndex];

        object IEnumerator.Current => people[loopIndex];

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            loopIndex++;
            return loopIndex < usedElementInPeople;
        }

        public void Reset()
        {
            loopIndex = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
