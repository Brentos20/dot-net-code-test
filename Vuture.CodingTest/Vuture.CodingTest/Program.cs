using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Vuture.CodingTest
{
    public class Program
    {

        private StringComparison IgnoreCase;

        public Program()
        {
            IgnoreCase = StringComparison.OrdinalIgnoreCase;
        }

        public int CountOccurs(char lett, string text)
        {
            int count = 0;
            lett = char.ToLower(lett);
            text = text.ToLower();
            foreach (char ch in text)
            {
                if (ch.Equals(lett)) count++;
            }
            return count;
        }

        public int CountOccurs(string sString, string text)
        {
            int count = 0;
            int subLength = sString.Length;
            for(int i = 0; i<text.Length-subLength; i ++)
            {
                if (text.Substring(i, subLength).Equals(sString, IgnoreCase)) count++;
            }
            return count;
        }

        public bool IsPalindrome(string text)
        {
            text = text.ToLower();
            int Length = text.Length;
            for(int i = 0; i < Length/2; i++)
            {
                if (text[i] != text[Length - i - 1]) return false;
            }
            return true;
        }

        public string CensoredWordsOccurSum(List<string> CenWords, string text)
        {
            StringBuilder ToReturn = new StringBuilder();
            int total = 0;

            foreach(string cenWord in CenWords)
            {
                int thisTotal = CountOccurs(cenWord, text);
                total += thisTotal;
                ToReturn.Append(string.Format("{0}: {1}, ", cenWord, thisTotal));
            }
            return ToReturn.Append("total: " + total).ToString();
        }

        public string CensorText(List<string> CenWords, string text)
        {
            string cenText = text;

            foreach (string CenWord in CenWords)
            {
                int occurs = CountOccurs(CenWord, text);
                
                while (occurs>0)
                {
                    int start = text.IndexOf(CenWord, IgnoreCase);
                    string wordToCensor = text.Substring(start, CenWord.Length);
                    cenText = cenText.Replace(wordToCensor, Censor(wordToCensor));
                    occurs--;
                }
            }
            return cenText;
        }

        private string Censor(string cenWord)
        {
            int length = cenWord.Length;
            char fLett = cenWord[0];
            char lLett = cenWord[length - 1];
            StringBuilder Censored = new StringBuilder().Append(fLett);
            for (int i = 0; i < length - 2; i++) Censored.Append("$");

            return Censored.Append(lLett).ToString();
        }

        public string CensorPalindrones(string text)
        {
            List<string> TextAsList = text.Split(' ').ToList<string>();
            StringBuilder censoredText = new StringBuilder();

            foreach(string Word in TextAsList)
            {
                if (IsPalindrome(Word)) censoredText.Append(Censor(Word));
                else censoredText.Append(Word);

                censoredText.Append(" ");
            }
            censoredText.Remove(censoredText.Length - 1, 1);
            return censoredText.ToString();
        }
        static void Main(string[] args){}
    }
    

}
