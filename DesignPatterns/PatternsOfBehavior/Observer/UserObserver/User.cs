using OOP_Patterns.PatternsOfBehavior.Observer.Component;
using OOP_Patterns.PatternsOfBehavior.Observer.Component.State;
using OOP_Patterns.PatternsOfBehavior.Observer.ObserverInterface;
using System;

namespace OOP_Patterns.PatternsOfBehavior.Observer.UserObserver
{
    class User : BaseUser, ObserverInterface.IObserver<News>
    {
        public User(string name, int userId)
        {
            Name = name;
            UserId = userId;
        }

        public User(int userId, string name, string surname, InterestingState state)
        {
            UserId = userId;
            Name = name;
            Surname = surname;
            _state = state;
        }

        public override string UserType => "User";
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Surname { get => base.Surname; set => base.Surname = value; }
        public override int UserId { get => base.UserId; set => base.UserId = value; }

        private InterestingState _state;

        public override void SurfBySite()
        {
            Console.WriteLine("Зашел на сайт, читает новости...");
            Console.WriteLine(_state switch
            {
                InterestingState.NonInteresting => "Пользователю не понравилось",
                InterestingState.Interesting => "Пользователю понравилось",
                InterestingState.VeryInteresting => "Пользователю очень понравилось",
                _ => throw new ArgumentException("Не инициализированно состояние пользователя"),
            });
        }

        public string Update(News data)
        {
            string title = data.Title;
            string shortDescription = data.ShortDescription;
            return $"{title}\n{shortDescription}\n";
        }
    }
}
