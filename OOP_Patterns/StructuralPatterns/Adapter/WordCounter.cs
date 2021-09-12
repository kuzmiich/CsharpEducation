using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    public class WordCounter
    {
        public WordCounter(string text)
        {
            Text = text;
        }
        public string Text { get; set; }
        private string[] ArrayElement => Text.Split(" ");
        
        public int CountWords => ArrayElement.Length;
        
        public int GetCount(string word) => ArrayElement.Select(w => w.Equals(word)).Count();
    }
}