using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance traveled by the taxi");
            string v = Console.ReadLine();
            double x = Convert.ToDouble(v);
            double f = 2.4 + x * 0.4;
            double f2 = Math.Floor(f);
            double y = Math.Ceiling ((f-f2)*10);
            double w = f2 + (y / 10);
            string TotalFare = string.Format("{0:C}", w);
            Console.Write("The total fare is ");
            Console.Write(TotalFare);
            string exit = Console.ReadLine();                    
                 
        }
    }
}
