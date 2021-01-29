using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class KonsolInputOgOutput
    {
        public void toHeltal()
        {
            
            string strNr1;
            string strNr2;
            int nr1;
            int nr2;
            do
            {
                Console.WriteLine("Skriv heltal nr 1");
                strNr1 = Console.ReadLine();
            } while (!int.TryParse(strNr1, out nr1));
            do
            {
                Console.WriteLine("Skriv heltal nr 2");
                strNr2 = Console.ReadLine();
            } while (!int.TryParse(strNr2, out nr2));

            Console.WriteLine(nr1 + " + " + nr2 + " = " + (nr1 + nr2));
            Console.WriteLine(nr1 + " / " + nr2 + " = " + (nr1 / nr2));
            decimal decNr = nr2/nr1;
            Console.WriteLine(Math.Floor(decNr));
            Console.WriteLine(Math.Pow(nr1, nr2));
        }
        public void pythagoras()
        {
            string strNr1;
            string strNr2;
            double nr1;
            double nr2;
            do
            {
                Console.WriteLine("Skriv det tal du vil have a til at være ");
                strNr1 = Console.ReadLine();
            } while (!double.TryParse(strNr1, out nr1));
            do
            {
                Console.WriteLine("Skriv det tal du vil have b til at være ");
                strNr2 = Console.ReadLine();
            } while (!double.TryParse(strNr2, out nr2));
            double c = Math.Sqrt(Math.Pow(nr1, 2) + Math.Pow(nr2, 2));
            Console.WriteLine("c = " + c);
            if (nr1 < nr2)
            {
                Console.WriteLine("a var det største tal i regnestykket");
            }
            else
            {
                Console.WriteLine("a var det største tal i regnestykket");
            }
        }
        public void alderOgNavn()
        {
            string navn;
            string strAlder;
            int alder;
            Console.WriteLine("Skriv et navn");
            navn = Console.ReadLine();
            do
            {
                Console.WriteLine("Skriv din alder");
                strAlder = Console.ReadLine();            
            } while (!int.TryParse(strAlder, out alder) || alder<0);

            if (alder < 3) Console.WriteLine(navn + ", du må gå med ble");
            else if (alder < 16) Console.WriteLine(navn + ", du må ingenting");
            else if (alder < 18) Console.WriteLine(navn + ", du må drikke ");
            else Console.WriteLine(navn + ", du må stemme og køre bil ");
        }

    }
}
