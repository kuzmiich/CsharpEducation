﻿namespace DesignPatterns.GeneratingPatterns.Builder.ProductComponent
{
    class Additive
    {
        public Additive()
        {
        }

        public Additive(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
