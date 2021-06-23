using OOP_Paradigms;
using OOP_Patterns.PatternsOfBehavior.Observer.Component;
using OOP_Patterns.PatternsOfBehavior.Observer.Component.State;
using OOP_Patterns.PatternsOfBehavior.Observer.UserObservable;
using OOP_Patterns.PatternsOfBehavior.Observer.UserObserver;
using System;

namespace OOP_Patterns.PatternsOfBehavior.Observer
{
    class LaunchObserver : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Console.WriteLine("IObserver - наблюдатель, IObservable - наблюдаемый объект\n" +
                "Внутри библиотеки System есть данные интерфейсы.В нормальном проекте необходимо использовать их." +
                "В каких случаях используется паттерн Observer:\n" +
                "-Когда система состоит из множества классов, объекты которых должны находиться в согласованных состояниях\n" +
                "-Когда общая схема взаимодействия объектов предполагает две стороны: одна рассылает сообщения и является главным,\n" +
                "другая получает сообщения и реагирует на них. Отделение логики обеих сторон позволяет их рассматривать независимо\n" +
                "и использовать отдельно друга от друга.\n" +
                "-Когда существует один объект, рассылающий сообщения, и множество подписчиков, которые получают сообщения.\n" +
                "При этом точное число подписчиков заранее неизвестно и процессе работы программы может изменяться.\n");

            var sender = new NewsAggregator();
            var admin = new Admin(
                
            );
            var manager = new Manager(0, "Manager");
            var user = new User(1, "Vasya", "KTR", InterestingState.Interesting);

            // имитация торгов
            var news = new News() 
            { 
                Title= "Hello, this is Microsoft news", 
                ShortDescription= "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmodtempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam,",
                LongDescription= "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod" +
                    "tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam,quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo" +
                    "consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse" +
                    "cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non" +
                    "proident,sunt in culpa qui officia deserunt mollit anim id est laborum."
            };
            /*sender.RegisterUser(user);
            sender.RemoveUser(manager);*/

            /*sender.NotifyUsers(news);
            news.LongDescription = "da";
            // имитация торгов
            sender.NotifyUsers(news);*/
        }
    }
}
