using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            if (s1.Length < s2.Length) { return -1; }
            else
            {
                int s2width = s2.Length;
                int s1width = s1.Length;

                for (int i = 0; i < s1.Length - s2.Length; i++)
                {
                    string check = s1.Substring(i, s2width);
                    if (check == s2) { return i; }
                }
                return -1;
            }
        }
    }
}
