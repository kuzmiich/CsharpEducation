using OOP_Patterns.PatternsOfBehavior.Observer.Component;
using OOP_Patterns.PatternsOfBehavior.Observer.ObserverInterface;
using System.Collections.Generic;

namespace OOP_Patterns.PatternsOfBehavior.Observer.UserObservable
{
    class NewsAggregator : IObservable<News>
    {
        public string Name { get; set; }
        public string UserId { private get; init; }

        public List<IObserver<News>> Observers { get { return _observers; } }
        private List<IObserver<News>> _observers;

        public NewsAggregator()
        {
        }

        public NewsAggregator(List<IObserver<News>> observers)
        {
            _observers = observers;
        }

        public NewsAggregator(string name, string userId)
        {
            Name = name;
            UserId = userId;
        }

        public NewsAggregator(string userId, string name, List<IObserver<News>> observers) : this(userId, name)
        {
            _observers = observers;
        }

        public void NotifyUsers(News message)
        {
            if (Observers != null)
            {
                foreach (IObserver<News> observer in Observers)
                {
                    observer.Update(message);
                }
            }
        }

        public void RegisterUser(IObserver<News> observer)
        {
            _observers.Add(observer);
        }

        public void RemoveUser(IObserver<News> observer)
        {
            _observers.Remove(observer);
        }
        /*public void Mailing(News message)
        {
            _message = message;
            NotifyObservers(_message);
        }*/
    }
}
