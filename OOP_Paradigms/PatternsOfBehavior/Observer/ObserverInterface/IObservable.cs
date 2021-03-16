namespace OOP_Patterns.PatternsOfBehavior.Observer.ObserverInterface
{
    public interface IObservable<TSourse>
    {
        void RegisterUser(IObserver<TSourse> observer);
        void RemoveUser(IObserver<TSourse> observer);
        void NotifyUsers(TSourse news);
    }
}
