using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Address = "";
            string b1 = "Block ", b2 = "Blk ";
            int[] NewPCode = new int[6];
            string[] BlockNo = new string[4];
            int[] NewFrontCode = new int[2];

            Console.WriteLine("Please enter the address of the customer ");
            Address = Console.ReadLine();


            // To find the Block Number



            for (int i = 0; i < Address.Length - 7; i++)
            {
                if (Address.Substring(i, 6) == "Block ")
                {
                   // Console.WriteLine(Address.Substring(i, 6));
                    BlockNo[0] = Address.Substring(i + 6, 1);
                    BlockNo[1] = Address.Substring(i + 7, 1);
                    BlockNo[2] = Address.Substring(i + 8, 1);
                    BlockNo[3] = Address.Substring(i + 9, 1);
                    //               Console.WriteLine("\n Block No is " + BlockNo[0] + BlockNo[1] + BlockNo[2]+BlockNo[3]);
                    //  string exit = Console.ReadLine();

                }

                if (Address.Substring(i, 4) == "Blk ")
                {
                    BlockNo[0] = Address.Substring(i + 4, 1);
                    BlockNo[1] = Address.Substring(i + 5, 1);
                    BlockNo[2] = Address.Substring(i + 6, 1);
                    BlockNo[3] = Address.Substring(i + 7, 1);
                }

            }

            // To reassign a no if the last part of the Block no is an alphabet

            {
                if (BlockNo[3] == " ") { BlockNo[3] = "0"; }
                if (BlockNo[3] == "A") { BlockNo[3] = "1"; }
                if (BlockNo[3] == "B") { BlockNo[3] = "2"; }
                if (BlockNo[3] == "C") { BlockNo[3] = "3"; }
                if (BlockNo[3] == "D") { BlockNo[3] = "4"; }
                if (BlockNo[3] == "E") { BlockNo[3] = "5"; }
                if (BlockNo[3] == "F") { BlockNo[3] = "6"; }
                if (BlockNo[3] == "G") { BlockNo[3] = "7"; }
                if (BlockNo[3] == "H") { BlockNo[3] = "8"; }
            }

            for (int i = 0; i < Address.Length - 11; i++)
            {
 //               Console.WriteLine(Address.Substring(i, 10));
               if (Address.Substring(i, 10) == "Singapore ")
                {
                    NewFrontCode[0] = Convert.ToInt16(Address.Substring(i + 12, 1));
                    NewFrontCode[1] = Convert.ToInt16(Address.Substring(i + 13, 1));
 //                   Console.WriteLine("\n Front Code is " + NewFrontCode[0] + NewFrontCode[1]);
                }
            }


   //         Console.WriteLine("\n Block No is " + BlockNo[0] + BlockNo[1] + BlockNo[2] + BlockNo[3]);
     //       Console.WriteLine("\n Front Code is " + NewFrontCode[0] + NewFrontCode[1]);
       //     string exit1 = Console.ReadLine();

            // Assigning the new Postal Code


            {
                NewPCode[0] = NewFrontCode[0];
                NewPCode[1] = NewFrontCode[1];
                NewPCode[2] = Convert.ToInt16(BlockNo[3]);
                NewPCode[3] = Convert.ToInt16(BlockNo[0]);
                NewPCode[4] = Convert.ToInt16(BlockNo[1]);
                NewPCode[5] = Convert.ToInt16(BlockNo[2]);

            }


            Console.WriteLine("\n  The New Postal Code is " + NewPCode[0]+NewPCode[1]+NewPCode[2]+NewPCode[3]+NewPCode[4]+NewPCode[5]);

            string exit2=Console.ReadLine();


        }
    }
}
