using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            int i;
            string r;
            string[] s;
            string[] u;
            string modified = "";

            Console.WriteLine(" Please enter the phrase ");
            r = Console.ReadLine();
            s = r.Split(' ');
            u = r.Split(' ');
            for (i=0;i<=s.Length-1; i++)
            {
               // Console.WriteLine(" ui  " + u[i] + "  si  " + s[i]);
                u[i] = u[i].Substring(0,1).ToUpper();
                s[i] = u[i].Substring(0, 1) + s[i].Substring(1);
                modified += s[i] + ' ';
            }
            Console.WriteLine(modified);

            string exit = Console.ReadLine();
        }
    }
}
