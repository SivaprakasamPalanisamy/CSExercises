using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BC2
    {
        static void Main(string[] args)
        {
            string Address;
            string b1 = "Block ", b2 = "Blk ";
            int[] NewPCode = new int[6];
            char[] BlockNo = new char[4];
            int[] NewFrontCode = new int[2];
            bool BlockFound = false;
            bool BlkFound = false;
            bool BlockNumberFound = false;
            bool OldPCodeFound = false;


            Console.WriteLine("Please enter the address of the customer ");
            Address = Console.ReadLine();


            // To find the Block Number

            for (int i = 0; i < Address.Length - 1; i++)
            {
                if (Address.Substring(i, 5) == b1)
                {
                    BlockNo[0] = Convert.ToChar(Address.Substring(i + 6, 1));
                    BlockNo[1] = Convert.ToChar(Address.Substring(i + 7, 1));
                    BlockNo[2] = Convert.ToChar(Address.Substring(i + 8, 1));
                    BlockNo[3] = Convert.ToChar(Address.Substring(i + 9, 1));
                }

                if (Address.Substring(i, 4) == b2)
                {
                    BlockNo[0] = Convert.ToChar(Address.Substring(i + 4, 1));
                    BlockNo[1] = Convert.ToChar(Address.Substring(i + 5, 1));
                    BlockNo[2] = Convert.ToChar(Address.Substring(i + 6, 1));
                    BlockNo[3] = Convert.ToChar(Address.Substring(i + 7, 1));
                }

            }

            Console.WriteLine("\n Block No is " + BlockNo);
            string exit = Console.ReadLine();






        }
    }
}
