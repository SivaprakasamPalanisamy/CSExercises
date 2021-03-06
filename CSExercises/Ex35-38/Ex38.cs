using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string [] StudentName = new string[5] {"John","Venkat","Mary","Victor","Betty"};
            int[] Marks = new int[5] { 63, 29, 75, 82, 55 };
            string[] title = new string[2] { "Name", "Mark" };

            // Sorting by Name

            Console.WriteLine("\tMarks in Alphabetical Order\n");
            Console.WriteLine("\t\t{0}\t\t{1}", title[0], title[1]);
            Console.WriteLine("\n");

            for (int i = 0 ; i <= 4 ; i++)
            {
                string firstname = StudentName[i];
                int firstnameMark = Marks[i];

                for (int j = i+1; j <=4;j++)
                {
                   
                    int check = StudentName[j].CompareTo(StudentName[i]);
 
                    if (check == -1)
                    {
                        firstname = StudentName[j];
                        firstnameMark = Marks[j];
                        StudentName[j] = StudentName[i];
                        Marks[j] = Marks[i];
                        StudentName[i] = firstname;
                        Marks[i] = firstnameMark;

                    }
                }
            }

            for (int i = 0; i <= 4;i++ )
            {
                Console.WriteLine("\t\t{0}\t\t{1}", StudentName[i], Marks[i]);
                Console.WriteLine();
            }

                // Sorting by rank

            Console.WriteLine("\n\n\tMarks in Rank Order");
            Console.WriteLine("\n\t\t{0}\t\t{1}", title[0], title[1]);
            Console.WriteLine("\n");
                for (int i = 0; i <= 4; i++)
                {
                    string firstrankName = StudentName[i];
                    int firstrank = Marks[i];

                    for (int j = i +1 ; j <= 4; j++)
                    {
                        //int check = StudentName[j].CompareTo(StudentName[i]);

                        if (Marks[j] > Marks[i])
                        {
                            firstrankName = StudentName[j];
                            firstrank = Marks[j];
                            StudentName[j] = StudentName[i];
                            Marks[j] = Marks[i];
                            StudentName[i] = firstrankName;
                            Marks[i] = firstrank;

                        }
                    }
                }
            for (int i = 0; i <= 4;i++ )
            {
                Console.WriteLine("\t\t{0}\t\t{1}", StudentName[i], Marks[i]);
                Console.WriteLine();
            }

            string exit = Console.ReadLine();
        }
    }
}
