using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.RV.LIB;

namespace DKExDiceOtherSums
{

    public class Dice
    {
        // Attributes
        private int faceup;

        // Methods
        public int GetFaceUp()
        {
            return faceup;
        }

        public void Throw()
        {
            faceup = ISSMath.RNDInt(6);
        }

        // Constructors
        public Dice()
        {
            Throw();
        }

        // Properties
        public string StrFaceUp
        {
            get
            {
                if (GetFaceUp() == 0) return "1";
                if (GetFaceUp() == 1) return "2";
                if (GetFaceUp() == 2) return "3";
                if (GetFaceUp() == 3) return "4";
                if (GetFaceUp() == 4) return "5";
                else return "6";

            }
        }
    }

    public class DiceApp
    {
        public static void Main()
        {
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            Console.WriteLine("Enter the Sum that you want ie. between 2 to 12 ");
            int Sum = Convert.ToInt16(Console.ReadLine());


            int count = 0;

            for (int i = 0; i < 1000; i++)
            {
                dice1.Throw(); //Console.WriteLine("Dice1: {0}", dice1.StrFaceUp);
                int d1 = Convert.ToInt16(dice1.StrFaceUp);

                dice2.Throw(); //Console.WriteLine("Dice2: {0}", dice2.StrFaceUp);
                int d2 = Convert.ToInt16(dice2.StrFaceUp);

                //      Console.WriteLine("Total {0}", d1 + d2);
                if (d1 + d2 == Sum) count++;
            }
            double count1 = Convert.ToDouble(count);
            double p = count1 * 0.001;
            double s = count1 / 1000;
            //double std = Convert.ToDouble(5.0 / 36.0);



            Console.WriteLine("\n Total {0} occurrences {1}   and the probability is {2:0.00###} .", Sum, count, p);
    

            string exit = Console.ReadLine();

        }
    }
}

