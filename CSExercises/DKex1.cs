
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    using ISS.RV.LIB;  


    public class Coin
    {
        // Attributes
        private int face;

        // Methods
        public int GetFace()
        {
            return face;
        }

        public void Flip()
        {
            face = ISSMath.RNDInt(2);
        }

        // Constructors
        public Coin()
        {
            Flip();
        }

        // Properties
        public string StrFace
        {
            get
            {
                if (GetFace() == 0) return "HEAD";
                else return "TAIL";
            }
        }
    }

    public class CoinApp
    {
        public static void Main()
        {
            Coin coin1 = new Coin();
            coin1.Flip();
            coin1.Flip(); Console.WriteLine("Coin1: {0}", coin1.StrFace);
            coin1.Flip(); Console.WriteLine("Coin1: {0}", coin1.StrFace);
            coin1.Flip(); Console.WriteLine("Coin1: {0}", coin1.StrFace);

            Coin coin2 = new Coin();
            coin2.Flip(); Console.WriteLine("Coin2: {0}", coin2.StrFace);

            Console.WriteLine("Coin1: {0}", coin1.StrFace);
            string exit = Console.ReadLine();
        }
    }       
}
