using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
          int[] A = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
          for (int i=0;i<=A.Length-1;i++)
            {
                int minNumber = A[i];
                //Console.Write("{0}\t i {1}\t A[i]  {2}\t minNumber" , i, A[i], minNumber);
                //Console.WriteLine();
                //for (int k = 0; k <= A.Length - 1; k++)
                //{
                //    Console.Write(" " + A[k]);
                //}
                //Console.WriteLine();
     
                for (int j =i + 1; j<=A.Length-1;j++)
                {
                    if (A[j] < minNumber)
                    {
                        minNumber = A[j];
                        A[j] = A[i];
                        A[i] = minNumber;
                    }
                }

                for (int k = 0; k <= A.Length-1; k++)
                {
                    Console.Write(" " + A[k]);
                }
                Console.WriteLine();
               // string exit1 = Console.ReadLine();
            }
            string exit = Console.ReadLine();
        }
    }
}
