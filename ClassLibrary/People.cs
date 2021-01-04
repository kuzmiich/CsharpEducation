using System;

namespace ClassLibrary
{
    public class People : IComparable
    {
        // main fields
        public string Gender { get; }
        public string Name { get; }
        public uint Age { get; private set; }

        // other fields
        public string Mind { get; private set; }
        public string Agility { get; private set; }
        public string Skill { get; private set; }
        public string Ability { get; private set; }
        public string Hobby { get; private set; }
        public int IQ { get; private set; }

        // constructor
        public People(string name, string gender, uint age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
        //\constructor

        // Information about Class
        public string getInfo()
        {
            return $"Name = { Name }, Gender = { Gender }, Age = { Age }";
        }
        // object comparison
        public int CompareTo(object obj)
        {
            if (obj is People person)
            {
                return person.Age.CompareTo(Age);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
