using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    class BC3
    {
        static void Main(string[] args)
        {
            string word;
            string SecondT = "";

            Console.WriteLine("Please enter the word to encrypt ");
            word = Console.ReadLine();
            char[] FirstT = new char[word.Length];


            // First Transformation

            for (int i = 0; i < word.Length; i++)
            {

                char c = Convert.ToChar(word.Substring(i, 1));
                if (c == '9') { FirstT[i] = '0'; }
                else if (c == 'Z') { FirstT[i] = 'A'; }
                else if (c == 'z') { FirstT[i] = 'a'; }
                else { FirstT[i] = Convert.ToChar(c + 1); }


            }

            for (int i = 0; i < word.Length; i++) { Console.Write("" + FirstT[i]); }   // To display First Transformation

            for (int i = word.Length - 1; i >= 0; i--) { SecondT += FirstT[i]; }

            Console.Write("\n" + SecondT + "     Encrypted word");   // To display Second Transformation

            string exit2 = Console.ReadLine();


        }
    }
}
