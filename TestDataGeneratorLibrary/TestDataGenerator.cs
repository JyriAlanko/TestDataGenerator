using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static TestDataGeneratorLibrary.Person;

namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator
    {
        enum Sex { Male = 0, Female = 1}
        public List<Person> person = new List<Person>();
        public string FirstName;
        public string LastName;

        public static string getRandomStringFromArray(string[] firstNameMales)
        {
            Random rnd = new Random();
            int firstNameIndex = rnd.Next(firstNameMales.Length);

            //Console.WriteLine("Name:        {0}", firstNameMales[mIndex]);
            return firstNameMales[firstNameIndex];

        }

        public static string getRandomlastName(string[] lastNames)
        {
            Random rnd = new Random();
            int lastNameIndex = rnd.Next(lastNames.Length);
            return lastNames[lastNameIndex];
        }

        public static int getRandomAge()
        {
            Random rnd = new Random();
            int age = rnd.Next(20, 50);

            return age;

        }

        public static int getRandomSex()
        {
            Random rnd = new Random();
            var sex = rnd.Next(0, 2);
            
            return sex;
        }
            

        public Person generateRandomPerson()
        {
            int gender = getRandomSex();
            
            if(gender == 0)
            {
            string FirstName = getRandomStringFromArray(Person.firstNameMales);
            string LastName = (getRandomlastName(Person.lastNames));
            var Age = getRandomAge();

                Person toReturn = new Person(FirstName, LastName, Age, (Person.Sex)gender);
                return toReturn;
            }

            if(gender == 1)
            {
                string FirstName = getRandomStringFromArray(Person.firstNameFemales);
                string LastName = getRandomlastName(Person.lastNames);
                var Age = getRandomAge();
                Person toReturn = new Person(FirstName, LastName, Age, (Person.Sex)gender);
                return toReturn;
            }


            //Console.WriteLine($"{FirstName} {LastName} Age:{Age} Gender:{Enum.GetName(typeof(Sex), sex)}");
            //person.Add(new Person { FirstName = FirstName, LastName = LastName, Age = Age  });
            //return new Person(FirstName, LastName, Age);

            return null;
        }

    }
}
