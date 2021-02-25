using System;

namespace ClassLibrary.Base
{
    /// <summary>
    /// class Person
    /// </summary>
    public class Person : IComparable
    {
        // main fields
        public string Gender { get; set; }
        public string FIO { get; set; }
        public uint Age { get; private set; }

        // other fields
        public string Mind { get; private set; }
        public string Agility { get; private set; }
        public string Skill { get; private set; }
        public string Ability { get; private set; }
        public string Hobby { get; private set; }
        public int IQ { get; private set; }

        /// <summary>
        /// Constructor of the Person class
        /// </summary>
        /// <param name="name">Person name</param>
        /// <param name="gender">Person gender</param>
        /// <param name="age">Person age</param>
        public Person(string name, string gender, uint age)
        {
            FIO = name;
            Gender = gender;
            Age = age;
        }

        /// <summary>
        /// Get information fields
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"Name = { FIO }, Gender = { Gender }, Age = { Age }";
        }
        /// <summary>
        /// Method for compare objects
        /// </summary>
        /// <param name="obj">Get any object</param>
        /// <returns>int value or Exception</returns>
        public int CompareTo(object obj)
        {
            if (obj is Person person)
            {
                return person.Age.CompareTo(Age);
            }
            else
            {
                throw new InvalidOperationException("Invalid operation.");
            }
        }
    }
}
