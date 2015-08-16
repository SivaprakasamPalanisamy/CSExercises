using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer Number");
            string x = Console.ReadLine(); // No ReadInt for Console hence input is read as string first then converted
            int y = Convert.ToInt16(x);
            int w = y * y;
            Console.Write("The Square of " + y);
            Console.Write(" is " + w);
            string exit = Console.ReadLine(); // to pause the console prompt screen
            
        }
    }
}
