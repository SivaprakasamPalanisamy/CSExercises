using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter the salary of Employee");
            string x = Console.ReadLine();
            double y = Convert.ToDouble(x);
            double h = y*0.1;
            double t = y * 0.03;
            double total = Math.Round(y + h + t,2);
            string TotalIncome = string.Format("{0:C}", total);
            Console.Write("The Total Income is ");
            Console.Write(TotalIncome);
            string exit = Console.ReadLine();           
        }
    }
}
