using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            string[] Argumen = new string[4] { "NO", "INVERSE", "SQUARE ROOT", "SQUARE" };
            double [,] attribute = new double[10,4];
            double no;

         for (int j=1;j<=4; j++)
            {
                for (int i =1; i<11 ; i++)
                {
                    no = Convert.ToDouble(i);
                    if (j==1)
                    {
                        attribute[i, j] = Convert.ToDouble(no);
                        Console.WriteLine(" No is " + attribute[1, j]);
                    }
                    else if (j==2)
                    {
                        attribute[i, j] = Convert.ToDouble(1 / no);
                    }
                    else if (j == 3)
                    {
                        attribute[i, j] = Convert.ToDouble(Math.Sqrt(no));
                    }
                    else if (j == 4)
                    {
                        attribute[i, j] = Convert.ToDouble(no*no);
                    }
                    string exit = Console.ReadLine();
                }

            }
        }
    }
}
