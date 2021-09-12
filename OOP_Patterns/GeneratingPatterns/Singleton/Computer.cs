namespace DesignPatterns.GeneratingPatterns.Singleton
{
    class Computer
    {
        public OS OS { get; set; }
        public void Launch(string osName)
        {
            OS = OS.GetInstance(osName);
        }
    }
}
