using System;
using System.Collections.Generic;

namespace курсач
{
    public class WordGenerator : IWordGenerator
    {
        private readonly IList<string> _words ;
        public string GetNewWord()
        {
            var word = _words[new Random().Next(0, _words.Count)];
            return word;
        }

        public WordGenerator()
        {
            _words = new [] { "интуиция", "пользователей", "чиновник", "имущество", "телефон", "марганец" };
        }
    }
}
