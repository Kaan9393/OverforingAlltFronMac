using System;

namespace DemoHåkan_UseOfDelegateEvent
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Action OnBirthDay;

        public void YearIncreased()
        {
            Age++;
            OnBirthDay();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person();
            me.Age = 58;
            me.Name = "Håkan";
            me.OnBirthDay = Celebrate;
            Console.WriteLine($"{me.Name} {me.Age}");
            me.YearIncreased();
            Console.WriteLine($"{me.Name} {me.Age}");
        }

        static void Celebrate()
        {
            Console.WriteLine("Jippi, nu var det din födelsedag!");
        }
    }
}