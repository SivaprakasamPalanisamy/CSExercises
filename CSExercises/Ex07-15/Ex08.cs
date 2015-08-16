using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Temperature in Celsius");
            string x = Console.ReadLine();
            double c = Convert.ToDouble(x);
            double f = 32 + 1.8*c;        
            Console.Write("The Temperature in Fahrenheit is ");
            Console.Write(f);
            string exit = Console.ReadLine();               
        }
    }
}
