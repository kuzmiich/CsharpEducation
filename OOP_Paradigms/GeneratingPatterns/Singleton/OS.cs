namespace OOP_Paradigms.GeneratingPatterns.Singleton
{
    class OS
    {
        private static object syncRoot = new object();
        private static OS instance;

        public string Name { get; private set; }

        protected OS(string name)
        {
            this.Name = name;
        }

        public static OS getInstance(string name)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    instance = new OS(name);
                }
            }
            return instance;
        }
    }
}
