using System;
using System.Collections.Generic;
using System.Text;
using static TestDataGeneratorLibrary.Person;

namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator
    {
        enum Sex { Male = 0, Female = 1}
        List<Person> person = new List<Person>();
        public string FirstName;
        public string LastName;

        public string getRandomStringFromArray(string[] firstNameMales)
        {
            Random rnd = new Random();
            int firstNameIndex = rnd.Next(firstNameMales.Length);

            //Console.WriteLine("Name:        {0}", firstNameMales[mIndex]);
            return firstNameMales[firstNameIndex];

        }

        public string getRandomlastName(string[] lastNames)
        {
            Random rnd = new Random();
            int lastNameIndex = rnd.Next(lastNames.Length);
            return lastNames[lastNameIndex];
        }

        public int getRandomAge()
        {
            Random rnd = new Random();
            int age = rnd.Next(20, 50);

            return age;

        }

        public int getRandomSex()
        {
            Random rnd = new Random();
            int sex = rnd.Next(0, 2);


            return sex;
        }
            

        public string generateRandomPerson()
        {
            

            string FirstName = Convert.ToString(getRandomStringFromArray(Person.firstNameMales));
            string LastName = Convert.ToString(getRandomlastName(Person.lastNames));
            int Age = getRandomAge();
            int sex = getRandomSex();
            
            Sex gender = (Sex)sex;

            Console.WriteLine($"{FirstName} {LastName} Age:{Age} Gender:{gender}");
            person.Add(new Person { FirstName = FirstName, LastName = LastName, Age = Age });
            return null;
        }

    }
}
