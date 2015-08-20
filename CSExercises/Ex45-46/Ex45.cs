using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            int[] CoinsAmount = new int[5] { 100, 50, 20,10, 5 };
            int[] CoinsCount = new int[5];
         //   bool calculated = false;


            Console.Write("\n Please enter the amount [between 0.05 and 3.50] :  ");

            double input1 = Convert.ToDouble(Console.ReadLine()) * 100;

            int input = Convert.ToInt16(input1);
  
            for (int i =0; i<=4; i++)
            {
                CoinsCount[i] = input / CoinsAmount[i];
                input = input % CoinsAmount[i];

            }

            for (int i = 0 ; i<=4;i++)
            {
                if ( CoinsCount[i] != 0)
                    for (int j = 1; j <= CoinsCount[i]; j++) { Console.WriteLine(" {0}c", CoinsAmount[i]); }

            }

            string exit = Console.ReadLine();
        }
    }
}
