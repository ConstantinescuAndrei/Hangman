using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Tutorial
    {
        private string tutorial;
        public Tutorial() 
        {
            tutorial = System.IO.File.ReadAllText(@"C:\Users\const\source\repos\Hangman\Hangman\Resources\Cum se joaca spanzuratoarea.txt");
        }

        public string getTutorial()
        {
            return tutorial;
        }
    }
}
