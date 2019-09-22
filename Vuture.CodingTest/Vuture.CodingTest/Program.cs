using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuture.CodingTest
{
    public class Program
    {

        public int CountOccurs(char lett, string text)
        {
            int count = 0;
            foreach (char ch in text)
            {
                if (char.ToLower(ch).Equals(char.ToLower(lett))) count++;
            }
            return count;
        }

        public int CountOccurs(string sString, string text)
        {
            int count = 0;
            int subLength = sString.Length;
            for(int i = 0; i<text.Length-subLength; i ++)
            {
                if (text.Substring(i, subLength).Equals(sString, StringComparison.OrdinalIgnoreCase)) count++;
            }
            return count;
        }

        public bool IsPalindrome(string text)
        {
            char[] textRev = text.ToCharArray();
            Array.Reverse(textRev);

            return string.Equals(text, new string(textRev), StringComparison.OrdinalIgnoreCase);
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
                    int start = text.IndexOf(CenWord, StringComparison.OrdinalIgnoreCase);
                    string wordToCensor = text.Substring(start, CenWord.Length);
                    cenText = cenText.Replace(wordToCensor, Censored(wordToCensor));
                    occurs--;

                }
                
            }
            return cenText;
        }

        private string Censored(string cenWord)
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
                if (IsPalindrome(Word)) censoredText.Append(Censored(Word));
                else censoredText.Append(Word);

                censoredText.Append(" ");
            }
            censoredText.Remove(censoredText.Length - 1, 1);
            return censoredText.ToString();
        }

        static void Main(string[] args)
        {

        }
    }
}
