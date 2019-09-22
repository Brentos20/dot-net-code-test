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
                if (ch.Equals(lett)) count++;
            }
            return count;
        }

        public bool isPalindrome(string text)
        {
            char[] textRev = text.ToCharArray();
            Array.Reverse(textRev);

            for(int i = 0; i < text.Length; i++)
            {
                if (!textRev[i].Equals(text[i])) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {

        }
    }
}
