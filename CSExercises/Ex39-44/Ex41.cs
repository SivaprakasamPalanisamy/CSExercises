using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {
            if (s1.Length < s2.Length) { return false; }
            else
            {
                int s2width = s2.Length;
                int s1width = s1.Length;

                for (int i = 0; i <= s1.Length - s2.Length; i++)
                {
                    string check = s1.Substring(i, s2width);
                    if (check == s2) { return true; }
                }
                return false;
            }
        }
    }
}
