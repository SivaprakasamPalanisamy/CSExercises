using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises

{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name, Gender and Age");
            Console.WriteLine("Name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Gender? Enter M for Male or F for Female");
            string gender = Console.ReadLine();
            Console.WriteLine("Age?");
            int Age = Convert.ToInt16(Console.ReadLine());

            if ((gender == "M" || gender == "m") && Age > 39) { Console.WriteLine("Good Morning Uncle " + name);}

            else if ((gender == "M" || gender == "m") && Age < 40) { Console.WriteLine("Good Morning Mr." + name);}

            else if ((gender == "F" || gender == "f") && Age > 39) { Console.WriteLine("Good Morning Aunty " + name);}
            else if ((gender == "F" || gender == "f") && Age < 40) { Console.WriteLine("Good Morning Ms." + name);}
            else  { Console.WriteLine("You may have entered an invalid Gender notation or Age."); }
            string exit = Console.ReadLine();
        }
    }
}