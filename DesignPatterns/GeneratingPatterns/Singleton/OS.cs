﻿namespace DesignPatterns.GeneratingPatterns.Singleton
{
    class OS
    {
        private static readonly object syncRoot = new object();
        private static OS instance;

        public string Name { get; private set; }

        protected OS(string name)
        {
            this.Name = name;
        }

        public static OS GetInstance(string name)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new OS(name);
                    }
                }
            }
            return instance;
        }
    }
}
