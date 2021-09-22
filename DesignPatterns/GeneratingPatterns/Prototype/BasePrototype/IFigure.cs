namespace DesignPatterns.GeneratingPatterns.Prototype.BasePrototype
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
}
