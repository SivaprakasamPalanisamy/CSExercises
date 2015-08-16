using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance traveled by the taxi");
            string v = Console.ReadLine();
            double x = Convert.ToDouble(v);
            double y = 2.4 + x*0.4;
            Console.Write("The total fare is ");
            Console.Write(y);
            string exit = Console.ReadLine();                    
        }
    }
}
