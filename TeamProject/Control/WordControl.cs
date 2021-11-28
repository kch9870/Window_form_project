using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProject.Model;

namespace TeamProject.Control
{
    class WordControl
    {
        public static List<Word> words = new List<Word>();

        public static void addWord(Word word)
        {
            words.Add(word);
        }
        public static void WordsDown()
        {
            for(int i = 0; i < words.Count; i++) words[i].down();
        }
        public static bool isMissed()
        {
            for (int i = 0; i < words.Count; i++)
                if(words[i].miss())
                {
                    words.Remove(words[i]);
                    return true;
                }
            return false;
        }
        public static bool wordChecker(string text)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].check(text))
                {
                    words.Remove(words[i]);
                    return true;
                }
            }
            return false;
        }
    }
}