
using System;

namespace lab2
{
    class WordSeparation
    {
        public string[] Separate(string str)
        {
            string[] words = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
    }
}
