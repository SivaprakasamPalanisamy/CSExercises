using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Score");
            int score = Convert.ToInt16(Console.ReadLine());

            if ((score>=80) && (score <= 100)) { Console.Write("Your Score is " +score);Console.Write(" which is A grade. "); }
            else if ((score>=60) && (score <= 79)) { Console.Write("Your Score is " +score);Console.Write(" which is B grade. "); }
            else if ((score>=40) && (score <= 59)) { Console.Write("Your Score is " +score);Console.Write(" which is C grade. "); }
            else if ((score>=0) && (score <= 39)) { Console.Write("Your Score is " +score);Console.Write(" which is F grade. "); }
            else if (score<0) { Console.Write("**Error**"); }
            else if (score >100) { Console.Write("**Error**"); }
           string exit = Console.ReadLine();
           
        }
    }
}