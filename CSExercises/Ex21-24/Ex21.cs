using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int lucky = 88;
            int guess = -1;
   
            do
            {
                Console.WriteLine("Enter guess number:");
                guess = Convert.ToInt16(Console.ReadLine());
            } while (guess != lucky); 
            Console.WriteLine("Lucky you....");
            string exit = Console.ReadLine();
        }
    }
}
