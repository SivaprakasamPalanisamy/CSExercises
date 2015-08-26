using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    class Ex42a
    {
        public static void Main(string[] args)
        {

     
                Console.Write("\n  Enter string S1 followed by string S2");
                Console.Write("\n  string s1   :");
                string s1 = Console.ReadLine();
                Console.Write("\n  string s2   :");
                string s2 = Console.ReadLine();

                int j = FindWord(s1, s2);

                Console.WriteLine(" FindWord result position is  "+ j);


            string exit = Console.ReadLine();


        }
        public static int FindWord(string s1, string s2)
        {
          if (s1.Length < s2.Length) { return -1; }
          else
          {


              for (int i=0; i< s1.Length-s2.Length; i++)
              {
                  string check = s1.Substring(i, s2.Length);
                  if (check == s2) { return i; }
              }
              return -1;
          }

        }


    }
}
