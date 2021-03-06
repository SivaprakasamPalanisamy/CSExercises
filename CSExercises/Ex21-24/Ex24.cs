using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            //Finding square root a given number using a random number between 1 and the given number itself
            Random r = new Random();
            double N;
            double Nestimate;

            Console.WriteLine("Please enter the integer number you want to perform squareroot.");
            N = Convert.ToDouble(Console.ReadLine());
            if (N>=0)
            { 
            Nestimate = Math.Round(Convert.ToDouble(N), 6);
            int E = Convert.ToInt16(N);
            double G = r.Next(1,E );//remember that Next(a,b) means inclusive of a but exclusive of b
            double Gestimate = Math.Round(G, 6);
            
            while (Gestimate != Nestimate)
                {
                 G = (G + N / G) / 2;
                // Console.WriteLine(" G =" + G); debug code to check iteration progress Remove when ok.
                 Gestimate = Math.Round((G*G),6);
                }
            G = Math.Round(G, 5);
            Console.Write("The square root of " + N);
            Console.Write(" is " + G);
            Console.Write("\n The intrinsic squareroot [math.Sqrt()] answer is  {0:0.00000}" , Math.Sqrt(N));

            string exit = Console.ReadLine();
            }
            else { Console.WriteLine("Invalid input"); string exit = Console.ReadLine();
            }
          
        }
    }
}
