using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.PatternsOfBehavior.Observer.Component
{
    public sealed class News
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public News(string title, string smallDescription, string longDescription)
        {
            Title = title;
            ShortDescription = smallDescription;
            LongDescription = longDescription;
        }

        public News()
        {
        }
    }
}
