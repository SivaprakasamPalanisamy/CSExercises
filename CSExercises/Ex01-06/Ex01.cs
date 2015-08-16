using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine("Good Morning " + name);
            string exit = Console.ReadLine(); // This command to pause console prompt screen
        }
    }
}
