using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class WordGenerator
    {
        private Dictionary<string, string[]> dict = new Dictionary<string, string[]>();
        private string[] words;
        private string word;
        private string wordCategorie;
        Random rnd = new Random();
        string[] categories = { "Animale", "Acasa", "Haine", "Mancare", "Calculator" };
        public WordGenerator()
        {

            int randomCategorie = rnd.Next(0, 4);
            int randomWord = rnd.Next(0, 15);
            populateWordsDictionary();
            words = dict[categories[randomCategorie]];
            word = words[randomWord];
            wordCategorie = categories[randomCategorie];
        }
        private void populateWordsDictionary()
        {
            ReadWords readWords = new ReadWords();
            dict = readWords.getWords();
        }
        public string getWord()
        {
            return word;
        }
        public string getCategorie()
        {
            return wordCategorie;
        }
    }
}
