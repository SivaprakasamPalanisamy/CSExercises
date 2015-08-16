using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Double Precision Number");
            string x = Console.ReadLine();
            double y = Convert.ToDouble(x);
            double w = Math.Sqrt(y);
            w = Math.Round(w, 3);
            Console.Write("The Square Root of " + y);
            Console.Write(" is " + w);
            string exit = Console.ReadLine();                 
        }
    }
}
