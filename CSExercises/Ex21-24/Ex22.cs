using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int A;
            int Aoriginal;
            int Boriginal;
            int B;
            int X;
            int HCF;
            int LCM;

            Console.Write("Enter A:");
            A = Aoriginal=Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter B:");
            B = Boriginal=Convert.ToInt32(Console.ReadLine());

            if (A > B) 
            {
                while (A != B) 
                {
                    X = A - B;
                    if (X>=B) { A = X; }
                    if (X < B) { A = B; B = X; }
                } 
            }
            else if ( B > A)
            {
                while (B != A)
                {
                    X = B - A;
                    if (X >= A) { B = X; }
                    if (X < A) { B = A; A = X; }
                }
            }

            HCF = B;
            LCM = (Aoriginal*Boriginal/HCF);
            Console.WriteLine("HCF: " + HCF);
            Console.WriteLine("LCM: "+LCM);
            string exit = Console.ReadLine();            
        }
    }
}
