using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int count;
            int i;
            int Number;

            Console.WriteLine("Please enter a positive integer number");
            i = Number = Convert.ToInt16(Console.ReadLine());

                count = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) { count = count + 1; }
                }
                if (count == 2)
                { Console.Write(i); Console.Write("  Prime  "); Console.WriteLine(""); }
                else
                {
                    Console.Write(i); Console.Write("  Not Prime "); Console.WriteLine("");
                }
            string exit = Console.ReadLine();            
        }
    }
}
