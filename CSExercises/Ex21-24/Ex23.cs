using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            //random number game
            Random r = new Random();
            int secretNo = r.Next(0, 10);//remember that Next(a,b) means inclusive of a but exclusive of b
            int guess = -1;
            int count = 0;
            
            while (guess != secretNo)
            {
                Console.WriteLine("Please enter your guess number.");
                guess = Convert.ToInt16(Console.ReadLine());
                count = count + 1;
                if (guess == secretNo)
                {
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("You were successful in attempt number " +count);
                    if (count <= 2) { Console.WriteLine("You are a Wizard!"); }
                    if (count >2 && count<=5){Console.WriteLine("You are a good guess");}
                    if (count > 5) { Console.WriteLine("You are lousy!"); }
                }
                else
                {
                    Console.WriteLine("Sorry. Not Correct. Pls Try Again");
                }
            }
            string exit = Console.ReadLine();
            
        }
    }
}
