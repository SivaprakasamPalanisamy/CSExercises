using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            string s;
            string input;
            string inputline ="";
            string reverseline  = "";

            Console.WriteLine(" Please enter your word or phrase");
            s = Console.ReadLine();
            input = s.ToLower();
            
            for (int i = 0; i <= input.Length -1; i++)
            {
                if (input[i]!= ' ' && input[i]  != '.' && input[i]!='!')
                {
                    inputline += input[i];
                }
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] != ' ' && input[i] != '.' && input[i] != '!')
                {
                    reverseline += input[i];
                }
            }

            if (inputline == reverseline) { Console.WriteLine(" Palindrome");}
            else { Console.WriteLine(" NOT Palindrome"); }

            string exit = Console.ReadLine();

        }
    }
}
