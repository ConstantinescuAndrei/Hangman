using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class ReadWords
    {
        private string key;
        List<string> values = new List<string>();
        private Dictionary<string, string[]> dict = new Dictionary<string, string[]>();
        string path = @"C:\Users\const\source\repos\Hangman\Hangman\Resources\hangmanWords.csv";
        public ReadWords() 
        { 
            using (StreamReader sr = new StreamReader(path))
            {
                while(sr.Peek() >= 0)
                {
                    string str;
                    str = sr.ReadLine();

                    List<string> strArray = str.Split(',').ToList<string>();
                    key = strArray[0];
                    strArray.RemoveAt(0);
                    foreach(string st in strArray)
                    {
                        values.Add(st);
                    }

                    dict.Add(key, values.ToArray());
                    values.Clear();
                }                
            }            
        }
        public Dictionary<string, string[]> getWords()
        {
            return dict;
        }

    }
}
