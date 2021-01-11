using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class NewGame
    {
        private Word word;
        private int lives = 6;
        public NewGame()
        { 
            word = new Word();
        }
        public void decreaseLives()
        {
            lives--;
        }
        public List<int> checkCharacter(char submitedLetter)
        {
            return word.checkCharacter(submitedLetter);
        }
        public string getWord()
        {
            return word.getWord();
        }
        
        public int getLives()
        {
            return lives;
        }
        public string getCategorie()
        {
            return word.getCategorie();
        }        
        public bool isGameWon()
        {
            return word.isGameWon();
        }
        public char guessCharacter()
        {
            return word.guessCharacter();
        }
        public int howManyGuess()
        {
            return word.howManyGuess();
        }
    }
}
