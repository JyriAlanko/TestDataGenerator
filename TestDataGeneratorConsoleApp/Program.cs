﻿using System;
using System.Collections.Generic;
using TestDataGeneratorLibrary;
namespace TestDataGeneratorConsoleApp
{
     class Program
    {
        static void Main(string[] args)
        {

            List<Person> person = new List<Person>();

            var dataGenerator = new TestDataGenerator();

            //dataGenerator.getRandomStringFromArray(Person.firstNameMales);
            //dataGenerator.getRandomlastName(Person.lastNames);
            //dataGenerator.getRandomAge();
            Start:
            var newPerson = dataGenerator.generateRandomPerson();
            person.Add(newPerson);

            for (int i = 0; i < person.Count; i++)
            {
                Console.WriteLine($"Name: {person[i].FirstName} {person[i].LastName} Age: {person[i].Age} Gender: {person[i].sex}");
            }

            Console.ReadKey();
            Console.Clear();
            goto Start;
        }
    }
}
