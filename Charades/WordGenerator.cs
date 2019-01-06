using System;

namespace курсач
{
    class WordGenerator
    {
        private readonly IReadOnlyCollection _words;
        public string GetNewWord()
        {
            throw new System.NotImplementedException();
        }

        public WordGenerator()
        {
            _words[] arr = { "интуиция", "пользователей", "чиновник", "имущество", "телефон", "марганец" }
             _words _word = arr[new Random().Next(0, arr.Length)];
            return _word;
        }
    }
}
