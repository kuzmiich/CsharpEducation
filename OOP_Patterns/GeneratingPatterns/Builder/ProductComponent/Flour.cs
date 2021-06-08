namespace OOP_Paradigms.GeneratingPatterns.Builder
{
    class Flour
    {
        public Flour()
        {
        }

        public Flour(string type)
        {
            Type = type;
        }

        public string Type { get; set; }
    }
}
