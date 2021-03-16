using OOP_Patterns.PatternsOfBehavior.Observer.Component;
using OOP_Patterns.PatternsOfBehavior.Observer.Component.State;
using OOP_Patterns.PatternsOfBehavior.Observer.ObserverInterface;
using OOP_Patterns.PatternsOfBehavior.Observer.UserObservable;
using System;
using System.Collections.Generic;

namespace OOP_Patterns.PatternsOfBehavior.Observer.UserObserver
{
    public sealed class Admin : BaseUser, ObserverInterface.IObserver<News>
    {

        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override int UserId { get; set; }
        public long VisitCount { get; private set; }
        public override string UserType => "Admin";

        public static ICollection<ObserverInterface.IObserver<News>> News
        {
            get
            {
                NewsAggregator news = new NewsAggregator();
                return news.Observers;
            }
        }
        public static ICollection<BaseUser> User { get { return _users; } }

        private InterestingState _state;
        private static ICollection<BaseUser> _users;

        static Admin()
        {
            _users = new BaseUser[]
            {
                new User(1, "Oleg", "Gomzukov", InterestingState.Interesting),
                new User(2, "Victor", "Miletov", InterestingState.NonInteresting),
                new User(3, "Yura", "Kolosov", InterestingState.VeryInteresting),
                new User(4, "Yura", "Katlinskie", InterestingState.Interesting),
                new Manager(5, "Nik"),
                new User(6, "Julia", "Katlinskie", InterestingState.Interesting),
            };
        }

        public Admin() { }

        public Admin(int userId)
        {
            UserId = userId;
        }

        public Admin(int userId, long visitCount, InterestingState interestingState)
        {
            VisitCount = visitCount;
            UserId = userId;
            _state = interestingState;
        }

        public Admin(int userId, string name, string surname, long visitCount)
        {
            UserId = userId;
            Name = name;
            Surname = surname;
            VisitCount = visitCount;
        }

        public override void SurfBySite()
        {
            Console.WriteLine("Зашел на сайт, читает статистику...");
            Console.WriteLine(_state switch
            {
                InterestingState.NonInteresting => "Пользователям не нравится сайт, нужно переделывать",
                InterestingState.Interesting => "Пользователю всё нравится",
                InterestingState.VeryInteresting => "Пользователям очень понравилось",
                _ => throw new ArgumentException("Не инициализированно состояние пользователей"),
            });
        }

        public string Update(News data)
        {
            string title = data.Title;
            string shortDescription = data.ShortDescription;
            string longDescription = data.LongDescription;
            return $"{title}\n{shortDescription}\n{longDescription}\n";
        }
    }
}
