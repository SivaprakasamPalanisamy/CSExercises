using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name & Gender");
            Console.WriteLine("Name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Gender? Enter M for Male or F for Female");
            string gender = Console.ReadLine();
            if (gender == "M"|| gender=="m") { Console.WriteLine("Good Morning Mr." + name); }
            else if (gender == "F" || gender == "f") {Console.WriteLine("Good Morning Ms." + name); }
            else { Console.WriteLine("You may have entered an invalid Gender notation."); }
            string exit = Console.ReadLine();
        }
    }
}