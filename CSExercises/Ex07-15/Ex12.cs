using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance traveled by the taxi");
            string v = Console.ReadLine();
            double x = Convert.ToDouble(v);
            double f = 2.4 + x * 0.4;
            double y = Math.Round(Math.Round(f,1),2);
            string TotalFare = string.Format("{0:C}", y);
            Console.Write("The total fare is ");
            Console.Write(TotalFare);
            string exit = Console.ReadLine();                    
               
        }
    }
}
