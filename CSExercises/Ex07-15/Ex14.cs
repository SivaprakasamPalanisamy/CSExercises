using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            Console.WriteLine("Please enter valid three side lengths of the Triangle");
            
            do 
            {
            Console.WriteLine("a?");
            string xa = Console.ReadLine();
            a = Convert.ToDouble(xa);
            } while (a <=0);
            
            do
            {
                Console.WriteLine("b?");
                string xb = Console.ReadLine();
                b = Convert.ToDouble(xb);
            } while (b <= 0);

            do
            {
                Console.WriteLine("c?");
                string xc = Console.ReadLine();
                c = Convert.ToDouble(xc);
            } while (c <= 0);
            double s = (a+b+c)/2;
            double area = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            Console.Write("The total area of the triangle is ");
            Console.Write(area);
            string exit = Console.ReadLine();                 
        }
    }
}