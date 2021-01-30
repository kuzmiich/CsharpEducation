using Education.interfaces;
using System;

namespace Education.classes.Advanced.AdditionalFeaturesInOOP
{
    class InitPropertyTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Свойства с модификатором init ----\n" +
                "Данный модификатор означает, что для установки значений свойств необходимо\n" +
                "использовать только конструктор или инициализатор\n"
            );

            Dog dog = new Dog(2, "");
            //dog.Name = "value";

            Dog dog1 = new Dog(3, "") { Name = "Rocks" };

            Dog dog2 = new Dog(5, "erk");
        }
    }
    class Dog
    {
        public Dog(uint age, string breed)
        {
            age = Age;
            breed = Breed;
        }

        public string Name { get; init; }
        public byte Age { get; set; }
        public string Breed { get; }
    }
}
