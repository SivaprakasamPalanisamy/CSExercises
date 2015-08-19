using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] MonthSales = new int[12];
            int Max = 0, Min = 0, Average = 0, TotalSales = 0;
            for (int i = 0; i <= 11; i++)
            {
                Console.Write(" Enter sales for the month " + i); Console.Write(" :");
                MonthSales[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxsalesmonth = MonthSales[0];
            int minsalesmonth = MonthSales[0];

            for (int i = 0; i<= 11; i++)
            {
                TotalSales = TotalSales+MonthSales[i];
                if (MonthSales[i] > maxsalesmonth) { Max = i; maxsalesmonth = MonthSales[i]; }
                if (MonthSales[i] < minsalesmonth) { Min = i; minsalesmonth = MonthSales[i]; }
            
            }
            Average = TotalSales/12 ;
            Console.WriteLine(" Maximum Sales: " +Max );
            Console.WriteLine(" Minimum Sales: " +Min );
            Console.WriteLine(" Average Sales: " +Average);
            string exit = Console.ReadLine();
        }
    }
}
