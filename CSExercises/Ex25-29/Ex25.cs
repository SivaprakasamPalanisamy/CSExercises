using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int F;
            int Answer= 1;
            int i,j,k;

            Console.WriteLine("Enter the integer you wish to perform Factorial.");
            F = Convert.ToInt16(Console.ReadLine());

            if (F>=0)
            {   
                Answer=1;
                for (i = 1; i <= F; i++)
                {
                    Answer = Answer * i;
                }
                Console.WriteLine("Using increment counter...");
                Console.Write("The Factorial of " + F);
                Console.Write(" is " + Answer);
                string exit = Console.ReadLine();

                Answer=1; // Resetting Answer back to 1 for Factorial calculation using decrement counter

                for (i = F; i >= 1; i--)
                {
                    Answer = Answer * i;
                }
                Console.WriteLine("Using decrement counter...");
                Console.Write("The Factorial of " + F);
                Console.Write(" is " + Answer);
                string exit1 = Console.ReadLine();

            }
           else {
                Console.WriteLine("**Error** Wrong input given");
                string exit = Console.ReadLine();
                }


 
           
        }
    }
}
