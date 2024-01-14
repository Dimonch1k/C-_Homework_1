using System;

namespace Tasks
{
    internal class Task4
    {
        public void Task_4()
        {
            Person person = new Person();

            person.Name = "Jura";
            person.Age = 10;

            Console.WriteLine($"Name before change: {person.Name}");
            Console.WriteLine($"Age before change: {person.Age}");

            person.Name = "Andriy";
            person.Age = 20;

            Console.WriteLine($"\nName after change: {person.Name}");
            Console.WriteLine($"Age after change: {person.Age}");
        }
    }
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
