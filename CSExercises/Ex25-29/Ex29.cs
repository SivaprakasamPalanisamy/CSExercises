using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int count;
            int factortotal;
            int Number;
            int i;

            Console.WriteLine("Please enter a positive integer number");
            i= Number = Convert.ToInt16(Console.ReadLine());

                factortotal = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i != j)
                    {
                        if (i % j == 0) { factortotal = factortotal + j; }
                    }
                }
                if (Number == factortotal)
                { Console.Write(i); Console.Write("  is a Perfect Number "); Console.WriteLine(""); }
                else
                {
                    { Console.Write(i); Console.Write("  is Not a Perfect Number "); Console.WriteLine(""); }
                }
            
            string exit = Console.ReadLine();           
        }
    }
}
