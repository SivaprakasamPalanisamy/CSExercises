using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    class BC1
    {

        static void Main()
        {

            string MoneyWord = "";
            string[] Mword = new string[6];
            int[] Value = new int[6];
            string[] Unitary = new string[9] { " One ", " Two ", " Three ", " Four ", " Five ", " Six ", " Seven ", " Eight ", " Nine " };
            string[] Tens = new string[10] { " Ten ", " Eleven ", " Twelve ", " Thirteen ", " Fourteen ", " Fifteen ", " Sixteen ", " Seventeen ", " Eighteen ", " Nineteen" };
            string[] Tys = new string[8] { " Twenty ", " Thirty ", " Forty ", " Fifty ", " Sixty ", " Seventy ", " Eighty ", " Ninety " };
            int DThousand, DHundred, DTen, DUnit, CTen, CUnit;


            Console.WriteLine("Please enter the amount in ####.## format exactly as shown in the invoice \n\n\t ");

            string sAmount = Console.ReadLine();
            double amount = Convert.ToDouble(sAmount);

            int Dollar = Convert.ToInt32(Math.Floor(amount));
            int Cents = Convert.ToInt16((amount - Dollar) * 100);

            // Storing the Dollar Digit Values

            for (int i = 0; i < 4; i++)
            {
                DThousand = Dollar / 1000;
                DHundred = (Dollar - DThousand * 1000) / 100;
                DTen = (Dollar - DThousand * 1000 - DHundred * 100) / 10;
                DUnit = Dollar % 10;
                CTen = Cents / 10;
                CUnit = Cents % 10;


                if (DThousand != 0) { Value[0] = DThousand; }

                if (DHundred != 0) { Value[1] = DHundred; }

                if (DTen != 0) { Value[2] = DTen; }

                if (DUnit != 0) { Value[3] = DUnit; }

                if (CTen != 0) { Value[4] = CTen; }

                if (CUnit != 0) { Value[5] = CUnit; }
            }

            // Console.WriteLine(" Value " + Value[0] + Value[1] + Value[2] + Value[3] + Value[4] + Value[5]);

            // Conversion to MoneyWord

            for (int i = 0; i < 6; i++)
            {
                if (i == 0 || i == 1 || i == 3 || i == 5)
                {
                    if (Value[i] != 0) { Mword[i] = Unitary[Value[i] - 1]; }
                    //   Console.WriteLine("   " + Mword[i]);
                }
            }

            for (int i = 0; i < 6; i++)
            {
                if (i == 2 || i == 4)
                {
                    if (Value[i] == 1)
                    {
                        for (int j = 0; j < 10; j++)
                        { Mword[i] = Tens[Value[i + 1]]; }
                        Mword[i + 1] = "";
                    }


                    if (Value[i] != 1 && Value[i] != 0)
                    {
                        for (int j = 0; j < 8; j++)
                        { Mword[i] = Tys[Value[i] - 2]; }
                    }
                    //  Console.WriteLine(" Mword  {0}    i+1 {1}        " , Mword[i + 1] , i + 1);
                }

            }

            // Conversion to MoneyWord


            if (Value[0] != 0 && Value[1] == 0 && Value[2] == 0 && Value[3] == 0 && Value[4] == 0 && Value[5] == 0)
            { Mword[0] += "Thousand only"; }
            if (Value[0] != 0 && Value[1] == 0 && Value[2] == 0 && Value[3] == 0 && (Value[4] != 0 || Value[5] != 0))
            { Mword[0] += "Thousand and Cents"; }
            else if (Value[0] != 0) { Mword[0] += "Thousand"; }


            if (Value[1] != 0 && Value[2] == 0 && Value[3] == 0 && Value[4] == 0 && Value[5] == 0)
            { Mword[1] += "Hundred only"; }
            if (Value[1] != 0 && Value[2] == 0 && Value[3] == 0 && (Value[4] != 0 || Value[5] != 0))
            { Mword[1] += "Hundred and Cents"; }
            if (Value[1] != 0 && (Value[2] != 0 || Value[3] != 0)) { Mword[1] += "Hundred and"; }


            if (Value[2] != 0 && Value[3] == 0 && Value[4] == 0 && Value[5] == 0) { Mword[2] += "only"; }
            if (Value[2] != 0 && Value[3] == 0 && (Value[4] != 0 || Value[5] != 0)) { Mword[2] += "and Cents"; }


            if (Value[3] != 0 && Value[4] == 0 && Value[5] == 0) { Mword[3] += "only"; }
            if (Value[3] != 0 && (Value[4] != 0 || Value[5] != 0)) { Mword[3] += "and Cents"; }

            if (Value[0] == 0 && Value[1] == 0 && Value[2] == 0 && Value[3] == 0 && (Value[4] != 0 || Value[5] != 0))
            { Mword[0] += "Zero and Cents"; }


            if (Value[4] != 0 && Value[5] == 0)
            { Mword[4] += "only"; }

            if (Value[5] != 0) { Mword[5] += "only"; }

            /*          if (Value[0] == 0 && Value[1] == 0 && Value[2] == 0 && Value[3] == 0 &&( Value[4]!=0 ||Value[5] !=0))
                        { Mword[0] = " Zero and Cents"; }

                        if (Value[0] == 0 && Value[1] == 0 && Value[2] == 0 && Value[3] == 0 && Value[4] == 0 || Value[5] == 0)
                        { Mword[0] = " Zero "; }
             */
            for (int i = 0; i < 6; i++)
            {
                MoneyWord += Mword[i];
            }

            Console.Write("\n\n ");
            Console.Write("Dollar " + MoneyWord);
            string exit = Console.ReadLine();
        }
    }
}
