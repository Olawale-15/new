using System;

namespace Number6
{
    class Program
    {
        static void Main(string[] args)
        {
            String oldString = "aeiou";
    char[] characters = oldString.ToCharArray();

      string word = "application";
            char[] letters = word.ToCharArray();
            char x = new char { };
            for (int j = 0; j < letters.Length; j++)
            {
if ((letters[j] == 'a') | (letters[j] == 'e' ) | (letters[j] == 'i' ) | (letters[j] == 'o' ) | (letters[j] == 'u'))


                {
                    for (int i = 0; i < letters.Length - 1; i++)
                    {
                        x = letters[i];
                        letters[i] = letters[i + 1];
                        letters[i + 1] = x;
                    }
                }
            }
            string s = new string(letters);
            Console.WriteLine(s);
        }
    }
}  

