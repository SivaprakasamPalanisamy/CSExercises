using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("\t X \t Y");
            Console.WriteLine();
            Console.Write("\t");

            for (int i = 1; i <=40; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            
            for (int i = -5; i<=5;i++)
            {
                double no = Convert.ToDouble(i);
                Console.Write("\t {0:0.0}\t{1:0.0}", no, ((2 * no * no) - 4 * no + 3));
                Console.WriteLine();
            }
            string exit = Console.ReadLine();
        }
    }
}
