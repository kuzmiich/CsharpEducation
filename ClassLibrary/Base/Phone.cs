namespace ClassLibrary.Base
{
    public class Phone
    {
        public Phone()
        {
        }

        public Phone(string name, string company)
        {
            Name = name;
            Company = company;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Company { get { return _company; } set { _company = value; } }

        private string _name;
        private string _company;
    }
}
