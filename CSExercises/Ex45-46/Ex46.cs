using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int [] Number = new int [10] {0,1,2,3,4,5,6,7,8,9};
            int[] NumberCount = new int[10] ;
            int[] Rnumber = new int[50];

            for (int i = 0; i <= 49; i ++)
            {
                Rnumber[i] = r.Next(0, 10);//remember that Next(a,b) means inclusive of a but exclusive of b
            }
           
            for (int j = 0; j <= 9; j++) 
            {
                int count = 0;
                
                for (int i = 0; i<=49 ; i++)
                {
                    if (Rnumber[i] == Number[j]) { count++; }
                }
                NumberCount[j] = count;
            }

            Console.WriteLine(" Part 1 Format \n\n");
            Console.WriteLine("\tNumber\tCount");


            for (int i = 0 ; i <= 9 ; i++ )
            {
                Console.WriteLine("\t  {0}   \t  {1}",Number[i], NumberCount[i]);
            }

            Console.WriteLine(" \n\n Part 2 Format \n\n");
            Console.WriteLine("\tNumber\t");


            for (int i = 0; i <= 9; i++)
            {
                Console.Write("\n\t  {0}   \t   ", Number[i]);

                if ( NumberCount [i] !=0)
                {
                    for (int j = 1; j <= NumberCount[i]; j++)
                        Console.Write("*");
                }
                else { Console.Write(""); }
            }
            string exit = Console.ReadLine();

        }
    }
}
