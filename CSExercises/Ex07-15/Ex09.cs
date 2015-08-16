using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the x value");
            string v = Console.ReadLine();
            double x = Convert.ToDouble(v);
            double y = 2*(x*x)- (4*x) +3;
            Console.Write("The result for 2x^2 - 4x + 3 is ");
            Console.Write(y);
            string exit = Console.ReadLine();             
        }
    }
}
