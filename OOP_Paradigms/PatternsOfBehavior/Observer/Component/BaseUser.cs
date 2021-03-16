using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.PatternsOfBehavior.Observer.Component
{
    public abstract class BaseUser
    {
        public BaseUser()
        {
        }

        protected BaseUser(int userId, string name, int age)
        {
            UserId = userId;
            Name = name;
            Age = age;
        }

        protected BaseUser(int userId, int age, string name, string firstName, string lastName)
        {
            UserId = userId;
            Age = age;
            Name = name;
            Surname = firstName;
            LastName = lastName;
        }

        public abstract string UserType { get; }
        public virtual int UserId { get; set; }
        public virtual int Age { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string LastName { get; init; }

        public abstract void SurfBySite();
    }
}
