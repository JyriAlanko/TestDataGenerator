using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class Person
    {
        public enum Sex { Male = 0 , Female = 1 }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }




        public static string[] firstNameMales = { "Jesse", "Jamppa" };
        public static string[] lastNames = { "Peränen", "Taukola", "Sukunimi" };

        public Person()
        {

        }

        public Person(string FirstName, string LastName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
    }
}
