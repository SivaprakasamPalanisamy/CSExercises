using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.Write("\tNO  \tINVERSE \tSQUARE ROOT\tSQUARE");
            Console.WriteLine();
            Console.Write("\t");
            for (int i = 1; i <= 54; i++ )
            {
                Console.Write("-");
            }
            Console.WriteLine();
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("\t{0:0.0}\t{1:0.0##}\t\t {2:0.0##}\t\t{3:0.0}", (i * 1.0), (1.0 / i), (Math.Sqrt(i)), (i * i * 1.0));
                    Console.WriteLine();
                }
            string exit = Console.ReadLine();
       
   
        }
    }
}
