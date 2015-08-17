using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double x;
            double f;
            int d;
            string TotalFare;

            Console.WriteLine("Please enter the distance traveled by the taxi");
            x = Convert.ToDouble(Console.ReadLine());
            if (x>0 && x<=9)
            {
                d = Convert.ToInt32( Math.Ceiling((x-0.5)/0.1));
                f = 2.4 + d * 0.04;
                TotalFare = string.Format("{0:C}", f);
                Console.WriteLine("The Total Taxi Fare is " + TotalFare);
            }

            else if (x>9)
            {
                d = Convert.ToInt32(Math.Ceiling((x - 9) / 0.1));
                f = 2.4 + 85 * 0.04 + d*0.05;
                TotalFare = string.Format("{0:C}", f);
                Console.WriteLine("The Total Taxi Fare is " + TotalFare);
            }
            else if (x < 0) { Console.WriteLine("Not a valid distance! entered."); }
            else { Console.WriteLine("**Error**"); }
           
            string exit = Console.ReadLine();        
        }
    }
}