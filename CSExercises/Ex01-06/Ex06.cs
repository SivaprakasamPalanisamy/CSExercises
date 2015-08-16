using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer Number");
            string x = Console.ReadLine();
            int y = Convert.ToInt16(x);
            double w = Math.Sqrt(y);
            Console.Write("The Square Root of " + y);
            Console.Write(" is " + w);
            string exit = Console.ReadLine();
            
             
        }
    }
}
