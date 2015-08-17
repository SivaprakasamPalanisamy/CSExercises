using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int tv ;
            int dvd;
            int mp3;
            double tvcost;
            double dvdcost;
            double mp3cost;
            double tvcostd;
            double dvdcostd;
            double mp3costd;

            double TotalPrice;

            Console.Write("Enter quantity for TV: ");
            tv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for DVD: ");
            dvd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for MP3: ");
            mp3 = Convert.ToInt32(Console.ReadLine());

            mp3cost = mp3costd= mp3 * 700;
            tvcost = tvcostd= tv * 900;
            dvdcost = dvdcostd= dvd * 500;


            if (tvcost > 5000 && tvcost<=10000) {tvcostd=tvcost*0.9;}
            if (tvcost > 10000) {tvcostd=tvcost*0.85;}
            if (dvdcost > 5000 && dvdcost<=10000) {dvdcostd=dvdcost*0.9;}
            if (dvdcost > 10000) {dvdcostd=dvdcost*0.85;}

            TotalPrice = Math.Round((mp3costd+tvcostd+dvdcostd),2);

            Console.Write("Total price for this order is $ ");
            Console.Write(TotalPrice);

 
            string exit = Console.ReadLine();                   
        }
    }
}