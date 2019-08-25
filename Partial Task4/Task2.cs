using System;
using System.Collections.Generic;
using Partial_Task4;

namespace Partial_Task4_Task2
{
    class Task2 : IRun
    {
        public void Run() 
        {
            List<Person> people = new List<Person>()
            {
                new Person() {Name = "Anie", Age = 15, PhoneNumbers = new List<string>(){"0851736183", "0751864258", "0851468348" } },
                new Person() {Name = "Garen", Age = 33, PhoneNumbers = new List<string>(){"0986742276", "00943761835", "0458436182" } },
                new Person() {Name = "Zoi", Age = 18, PhoneNumbers = new List<string>(){"0751683489", "0564832444", "0943715867" } },
                new Person() {Name = "Jasuo", Age = 30, PhoneNumbers = new List<string>(){"046791256", "0734924831", "0714682349" } },
                new Person() {Name = "Dariys", Age = 35, PhoneNumbers = new List<string>(){"0453189716", "0786148325", "0412398756" } },
                new Person() {Name = "Morgana", Age = 28, PhoneNumbers = new List<string>(){"0746583459", "0748638915", "0498347625" } }
            };

            Person[] addPerson = new Person[2];
            addPerson[0] = new Person() { Name = "Ginx", Age = 18, PhoneNumbers = new List<string>() { "0721468522", "0145667797", "09476161855" } };
            addPerson[1] = new Person() { Name = "Jin", Age = 18, PhoneNumbers = new List<string>() { "09975259999", "09484543414", "0194348644" } };
            people.AddRange(addPerson);
            
            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
                foreach (var number in person.PhoneNumbers)
                {
                    Console.WriteLine(number);
                }
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

