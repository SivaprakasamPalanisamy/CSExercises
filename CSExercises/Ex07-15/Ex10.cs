using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the coordinates of the two coordinate points in sequence x1,y1,x2 and y2");
            Console.WriteLine("x1?");
            string xa = Console.ReadLine();
            double x1 = Convert.ToDouble(xa);
            Console.WriteLine("y1?");
            string ya = Console.ReadLine();
            double y1 = Convert.ToDouble(ya);
            Console.WriteLine("x2?");
            string xb = Console.ReadLine();
            double x2 = Convert.ToDouble(xb);
            Console.WriteLine("y2?");
            string yb = Console.ReadLine();
            double y2 = Convert.ToDouble(yb);
            double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));  
            Console.Write("The distance between the two points is ");
            Console.Write(d);
            string exit = Console.ReadLine();             
                
        }
    }
}
