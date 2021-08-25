using DesignPatterns.PatternsOfBehavior.Strategy.CarState;

namespace DesignPatterns.PatternsOfBehavior.Strategy.BaseCar
{
    class Car
    {
        protected int PassengersCount; // кол-во пассажиров
        protected string CarModel; // модель автомобиля

        public IMovable Movable { private get; set; }

        public Car(int count, string model, IMovable movable)
        {
            PassengersCount = count;
            CarModel = model;
            Movable = movable;
        }

        public void Move()
        {
            Movable.Move();
        }
    }
}
