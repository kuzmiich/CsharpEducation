using DesignPatterns.PatternsOfBehavior.Strategy.CarState;

namespace DesignPatterns.PatternsOfBehavior.Strategy.BaseCar
{
    class Car
    {
        protected int passengersCount; // кол-во пассажиров
        protected string carModel; // модель автомобиля

        public IMovable Movable { private get; set; }

        public Car(int count, string model, IMovable movable)
        {
            passengersCount = count;
            carModel = model;
            Movable = movable;
        }

        public void Move()
        {
            Movable.Move();
        }
    }
}
