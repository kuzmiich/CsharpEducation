using OOP_Patterns.PatternsOfBehavior.Observer.Component;
using OOP_Patterns.PatternsOfBehavior.Observer.Component.State;
using System;

namespace OOP_Patterns.PatternsOfBehavior.Observer.UserObserver
{
    public class Manager : BaseUser, ObserverInterface.IObserver<News>
    {
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string Surname { get => base.Surname; set => base.Surname = value; }
        public override int UserId { get => base.UserId; set => base.UserId = value; }
        private ObserverInterface.IObservable<News> _observable;
        private SiteState _siteState;

        public Manager(int userId, string name)
        {
            UserId = userId;
            Name = name;
        }

        public Manager(int userId, string name, string surname, ObserverInterface.IObservable<News> observable)
        {
            UserId = userId;
            Name = name;
            Surname = surname;
            _observable = observable;
        }

        public Manager(
            int userId,
            string name,
            string surname,
            ObserverInterface.IObservable<News> observable,
            SiteState siteState) : this(userId, surname, name, observable)
        {
            _siteState = siteState;
        }

        public override string UserType => "Manager";

        public override void SurfBySite()
        {
            Console.WriteLine("Зашел на сайт, просматривает статистику посещений...");
            Console.WriteLine(_siteState switch
            {
                SiteState.VeryBadStatistic => "Пользователю не понравилось",
                SiteState.BadStatistic => "Пользователю понравилось",
                SiteState.FineStatistic => "Пользователю очень понравилось",
                SiteState.GoodStatistic => "Пользователю очень понравилось",
                SiteState.PerfectStatistic => "Пользователю очень понравилось",
                _ => throw new ArgumentException("Не инициализированно состояние пользователя"),
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
