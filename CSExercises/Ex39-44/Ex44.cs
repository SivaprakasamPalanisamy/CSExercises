using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            string snew = "";

            for (int i = 0; i <= s.Length - 1; i++ )
            {
                if (s.Substring(i, 1) == "c1") 
                {
                    snew += "c2";
                }
                else { snew += s.Substring(i, 1); }
            }
                return snew;
        }
    }
}
