using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int count;
            int factortotal;
            int Number;

            for (int i = 1; i <= 1000; i++)
            {
                Number = i;
                factortotal = 0;
                
                for (int j = 1; j <= i; j++)
                {
                    if (i != j)
                    {
                        if (i % j == 0) { factortotal = factortotal + j; }
                    }
                }
                if (Number == factortotal )
                { Console.Write(i); Console.Write("  is a Perfect Number "); Console.WriteLine(""); }
            }
            string exit = Console.ReadLine();
                
        }
    }
}
