using System;
using System.Collections.Generic;
using Partial_Task4;

namespace Partial_Task4_Task1
{
    class Task1 : IRun
    {
        public void Run()
        {
            List<Person> people = new List<Person>()
            {
                new Person() {Name = "Anie", Age = 15, PhoneNumbers = new List<string>(){"0851736183", "0751864258", "0851468348" } },
                new Person() {Name = "Garen", Age = 33, PhoneNumbers = new List<string>(){"0986742276", "00943761835", "0458436182" } },
                new Person() {Name = "Zoi", Age = 18, PhoneNumbers = new List<string>(){"0751683489", "0564832444", "0943715867" } },
                new Person() {Name = "Jasuo", Age = 18, PhoneNumbers = new List<string>(){"046791256", "0734924831", "0714682349" } },
                new Person() {Name = "Darius", Age = 18, PhoneNumbers = new List<string>(){"0453189716", "0786148325", "0412398756" } },
                new Person() {Name = "Morgana", Age = 18, PhoneNumbers = new List<string>(){"0746583459", "0748638915", "0498347625" } }
            };

            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name }; Age: {person.Age} ");
            }
        }      
    }
           

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }
    }
}
