using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Double Precision Number");
            string x = Console.ReadLine();
            double y = Convert.ToDouble(x);
            double w = y * y;
            Console.Write("The Square of " + y);
            Console.Write(" is " + w);
            string exit = Console.ReadLine();
            
        }
    }
}
