using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int i)
        {
            int input = i ;
            string[] temp = new string[1];
            string HexAnswer="" ;
            string reverseHexAnswer = "";
            do
            {
                int number = input / 16;

                if (number == 15) { reverseHexAnswer += "E"; } 
                if (number == 10) { reverseHexAnswer += "D"; }
                if (number == 10) { reverseHexAnswer += "C"; }
                if (number == 10) { reverseHexAnswer += "B"; }
                if (number == 10) { reverseHexAnswer += "A"; }
                if (number < 10) { reverseHexAnswer += number; }

                if (input / 16 != 0) { input = number; }
            
            } while (input / 16 != 0);

            for (int j = reverseHexAnswer.Length - 1; j >= 0; j-- )
            {
                HexAnswer += reverseHexAnswer.Substring(j, 1);
            }

                return HexAnswer;
        }
    }
}
