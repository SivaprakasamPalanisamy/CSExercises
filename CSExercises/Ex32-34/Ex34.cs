using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int [,] M = new int [15,5]; //Marks array
            string[] S = new string[5] { "Subject1", "Subject2", "Subject3", "Subject4", "Average" };
            string[] A = new string[15] {"Student1","Student2","Student3","Student4","Student5","Student6","Student7",
                                          "Student8","Student9","Student10","Student11","Student12",
                                          "Subject Average","Subject Std Dev","Overall Class Average Score"};
            int [] SAverage = new int[4];
            int[] SSTD = new int[4];
 
            // Taking in the Marks for the Students.

            for (int i = 0; i <= 2; i++) 
            {
                Console.WriteLine(" Please Marks in order of Subject1 to Subject4 for "+A[i]);

                int Student_Total = 0;

                for (int j = 0; j<=3; j++)
                {
                    Console.Write(" " + S[j]); Console.Write(" : ");
                    M[i, j] = Convert.ToInt16(Console.ReadLine());
                    Student_Total = Student_Total + M[i, j];
                }

                M[i, 4] = Student_Total / 4; // Calculate & Store Student Average Score
                Console.WriteLine("Average Score is " + M[i, 4]);
            }

            int class_total = 0;

            for (int j =0; j<=3;j++)
            {
                int subject_total = 0;

                for (int i = 0; i<=2;i++)
                {
                    subject_total = subject_total + M[i, j];
                }
 
                SAverage [j] = subject_total / 12;

                Console.Write("{0}\t Average Score \t {1}", S[j], SAverage[j]);
                Console.WriteLine();
                class_total = class_total + subject_total;
            }
            int class_average = class_total / 48;

            string exit = Console.ReadLine();

            Console.WriteLine();
            Console.Write("\t\t{0}  {1}  {2}  {3}\t{4}", S[0], S[1], S[2], S[3], S[4]);
            Console.WriteLine();

            for (int i =0; i <=2; i++)
            {
                Console.Write("{0}\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}", A[i], M[i, 0], M[i, 1], M[i, 2], M[i, 3],M[i,4]);
                Console.WriteLine();
             }
            string exit1 = Console.ReadLine();
        }
    }
}
