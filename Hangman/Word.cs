using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Word
    {
        private List<char> characters = new List<char>();
        private WordGenerator newWord;
        private string word;
        int numberOfCharactersLeft;
        int wordLength;
        public Word()
        {
            newWord = new WordGenerator();
            word = newWord.getWord();
            wordLength = word.Length;
            numberOfCharactersLeft = word.Length;
            wordBreakdown();
        }
        public void wordBreakdown()
        {
            foreach (char letter in word)
            {
                char l = char.ToUpper(letter);
                characters.Add(l);
            }
        }
        public string getWord()
        {
            return word;
        }
        public List<int> checkCharacter(char inputCharacter)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < characters.Count; i++)
            {
                if (inputCharacter == characters[i])
                {
                    indexes.Add(i);
                    characters[i] = ' ';
                    numberOfCharactersLeft--;
                }
            }
            if (indexes.Count == 0)
                indexes.Add(-1);

            return indexes;
        }

        internal int howManyGuess()
        {
            return word.Length / 2;
        }

        public bool isGameWon()
        {
            return (numberOfCharactersLeft > 0) ? false : true;
        }

        public char guessCharacter()
        {
            Random rnd = new Random();
            char guessedCharacter = ' ';
            while(guessedCharacter == ' ')
            {
                int randomGuess = rnd.Next(0, wordLength);
                guessedCharacter = characters[randomGuess];
            }
            
            return guessedCharacter;
        }
        public string getCategorie()
        {
            return newWord.getCategorie().ToLower();
        }
    }
}
