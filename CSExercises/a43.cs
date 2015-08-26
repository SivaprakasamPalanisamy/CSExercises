
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Exa43
    {
        public static void Main(string[] args)
        {

            for (int i = 1; i <= 300; i++)
            {
                Console.Write("\n  Hex conversion of " + i + " is " + Hex(i));

            }
  
            string exit = Console.ReadLine();
 
  
      }
        public static string Hex(int i)
        {
            int input = i ;
            string[] temp = new string[1];
            string HexAnswer="" ;
            string reverseHexAnswer = "";
            
            while ( input!=0)
            {
                int number = input % 16;

                if (number == 15) { reverseHexAnswer += "F"; } 
                if (number == 14) { reverseHexAnswer += "E"; }
                if (number == 13) { reverseHexAnswer += "D"; }
                if (number == 12) { reverseHexAnswer += "C"; }
                if (number == 11) { reverseHexAnswer += "B"; }
                if (number == 10) { reverseHexAnswer += "A"; }
                if (number < 10) { reverseHexAnswer += number; }

                input = input/16;         
            }

            for (int j = reverseHexAnswer.Length - 1; j >= 0; j-- )
            {
                HexAnswer += reverseHexAnswer.Substring(j, 1);
            }

                return HexAnswer;
        }


        
    }
}


